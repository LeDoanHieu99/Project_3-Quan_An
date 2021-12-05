using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Menu = DATA.Menu;
namespace GUI
{
    public partial class frmBill : Form
    {
        public frmBill(int tableId)
        {
            InitializeComponent();
            txtIdTable.Text = tableId.ToString();
            LoadBill(tableId);
        }

        void LoadBill(int tableId)
        {
            GrivBill.DataSource = MenuBLL.Instance.LoadBillByIdTable(tableId);
            DataRow row = BillBLL.Instance.GetInforBillByIdTable(tableId);
            if (row != null)
            {
                txtIdBill.Text = ((int)row["BillId"]).ToString();
                txtIdTable.Text = ((int)row["TableId"]).ToString();
                DateTime now = DateTime.Now;
                txtDate.Text = now.ToString();
                txtTotal.Text = TotalMoney(tableId).ToString();

            }
        }
        int TotalMoney(int tableId)
        {

            List<Menu> menus = MenuBLL.Instance.GetListMenusById(tableId);
            int totalMoney = 0;
            foreach (var i in menus)
            {
                totalMoney += i.TotalMoney;
            }
            return totalMoney;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                int billId = Convert.ToInt32(txtIdBill.Text);
                int totalMoney = Convert.ToInt32(txtTotal.Text);
                int tableId = Convert.ToInt32(txtIdTable.Text);
                DateTime datePayment = Convert.ToDateTime(txtDate.Text);
                if (BillBLL.Instance.UpdateBill(billId, datePayment, totalMoney) == true)
                {
                    BillBLL.Instance.Checkout(billId);
                    TableBLL.Instance.ResetStatusById(tableId);
                    MessageBox.Show("Payment success !!");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Information is empty !!");
            }
            if (GrivBill.Rows.Count > 0)
            {
                int billId = Convert.ToInt32(txtIdBill.Text);
                int totalMoney = Convert.ToInt32(txtTotal.Text);
                int tableId = Convert.ToInt32(txtIdTable.Text);
                DateTime datePayment = Convert.ToDateTime(txtDate.Text);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "BillId-" + billId + ".pdf";
                bool fileError = false;
                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f1 = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Unable to write data to the drive.Error Description: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(GrivBill.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            // Thêm tên cột
                            foreach (DataGridViewColumn column in GrivBill.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                                pdfTable.AddCell(cell);
                            }
                            // Thêm dữ liệu trong từng cột
                            foreach (DataGridViewRow row in GrivBill.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfTable.AddCell(new Phrase("", f));
                                    }
                                    else
                                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), f));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                Paragraph para3 = new Paragraph("Sura BBQ Restaurant", f2);
                                Paragraph para4 = new Paragraph("Address: 123, Trung Do ward, Vinh city, Nghe An province", f);
                                Paragraph para5 = new Paragraph("Phone Number: 0379096558", f);
                                Paragraph para6 = new Paragraph("Email: surabbq@gmail.com", f);
                                Paragraph para7 = new Paragraph("BILL OF SALE", f1);
                                Paragraph para8 = new Paragraph("* * *", f1);
                                Paragraph para9 = new Paragraph("------------------------------------------------------------", f);
                                Paragraph para1 = new Paragraph("Table " + txtIdTable.Text, f2);
                                Paragraph para = new Paragraph("                        " + label2.Text + "" + txtIdBill.Text + "                                                                             " + label4.Text + "" + txtDate.Text, f);
                                Paragraph para2 = new Paragraph("                        " + label3.Text + "" + txtIdTable.Text + "                                                                                     " + label5.Text + "" + txtTotal.Text, f);
                                para3.Alignment = Element.ALIGN_CENTER;
                                para4.Alignment = Element.ALIGN_CENTER;
                                para5.Alignment = Element.ALIGN_CENTER;
                                para6.Alignment = Element.ALIGN_CENTER;
                                para1.Alignment = Element.ALIGN_CENTER;
                                para7.Alignment = Element.ALIGN_CENTER;
                                para8.Alignment = Element.ALIGN_CENTER;
                                para9.Alignment = Element.ALIGN_CENTER;
                                para2.Alignment = Element.ALIGN_LEFT;
                                para.Alignment = Element.ALIGN_LEFT;

                                pdfDoc.Add(para3);
                                pdfDoc.Add(para4);
                                pdfDoc.Add(para5);
                                pdfDoc.Add(para6);
                                pdfDoc.Add(para9);
                                pdfDoc.Add(para7);
                                pdfDoc.Add(new Phrase(" "));
                                pdfDoc.Add(para1);
                                pdfDoc.Add(new Phrase(""));
                                pdfDoc.Add(para);
                                pdfDoc.Add(para2);


                                pdfDoc.Add(new Phrase(" "));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(new Phrase("     "));
                                pdfDoc.Add(para8);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Export bill successful !!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error description :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No bills are exported !!", "Info");
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            //this.Height = 724;
            //this.Width = 1426;
        }

        private void GrivBill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GrivBill.Rows[e.RowIndex];
                txtFoodName.Text = row.Cells["Food Name"].Value.ToString();
                txtUnitPrice.Text = row.Cells["Price"].Value.ToString();
                txtCount.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["Total Money"].Value.ToString();
            }
        }

        private void txtpaymentcustomers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int refundMoney = Convert.ToInt32(txtpaymentcustomers.Text) - Convert.ToInt32(txtTotal.Text);
                txtChange.Text = refundMoney.ToString();
            }
            catch
            {
                MessageBox.Show("Information is not in the correct format !!");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (GrivBill.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "BillId-" + txtIdBill.Text + ".pdf";
                bool fileError = false;
                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f1 = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Cannot write data to disk.Error Description: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(GrivBill.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            // Thêm tên cột
                            foreach (DataGridViewColumn column in GrivBill.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                                pdfTable.AddCell(cell);
                            }
                            // Thêm dữ liệu trong từng cột
                            foreach (DataGridViewRow row in GrivBill.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfTable.AddCell(new Phrase("", f));
                                    }
                                    else
                                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), f));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                Paragraph para3 = new Paragraph("Sura BBQ Restaurant", f2);
                                Paragraph para4 = new Paragraph("Address: 123, Trung Do ward, Vinh city, Nghe An province", f);
                                Paragraph para5 = new Paragraph("Phone Number: 0379096558", f);
                                Paragraph para6 = new Paragraph("Email: surabbq@gmail.com", f);
                                Paragraph para7 = new Paragraph("BILL OF SALE", f1);
                                Paragraph para8 = new Paragraph("* * *", f1);
                                Paragraph para9 = new Paragraph("------------------------------------------------------------", f);
                                Paragraph para1 = new Paragraph("Table " + txtIdTable.Text, f2);
                                Paragraph para = new Paragraph("                        " + label2.Text + "" + txtIdBill.Text + "                                                                             " + label4.Text + "" + txtDate.Text, f);
                                Paragraph para2 = new Paragraph("                        " + label3.Text + "" + txtIdTable.Text + "                                                                                     " + label5.Text + "" + txtTotal.Text, f);
                                para3.Alignment = Element.ALIGN_CENTER;
                                para4.Alignment = Element.ALIGN_CENTER;
                                para5.Alignment = Element.ALIGN_CENTER;
                                para6.Alignment = Element.ALIGN_CENTER;
                                para1.Alignment = Element.ALIGN_CENTER;
                                para7.Alignment = Element.ALIGN_CENTER;
                                para8.Alignment = Element.ALIGN_CENTER;
                                para9.Alignment = Element.ALIGN_CENTER;
                                para2.Alignment = Element.ALIGN_LEFT;
                                para.Alignment = Element.ALIGN_LEFT;

                                pdfDoc.Add(para3);
                                pdfDoc.Add(para4);
                                pdfDoc.Add(para5);
                                pdfDoc.Add(para6);
                                pdfDoc.Add(para9);
                                pdfDoc.Add(para7);
                                pdfDoc.Add(new Phrase(" "));
                                pdfDoc.Add(para1);
                                pdfDoc.Add(new Phrase(""));
                                pdfDoc.Add(para);
                                pdfDoc.Add(para2);


                                pdfDoc.Add(new Phrase(" "));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(new Phrase("     "));
                                pdfDoc.Add(para8);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Export bill successful !!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error description: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No bills have been issued !!", "Info");
            }
        }
    }
}
