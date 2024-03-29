USE [QuanLyQuanAn]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NULL,
	[PassWord] [varchar](100) NULL,
	[Name] [nvarchar](100) NULL,
	[Role] [nvarchar](100) NULL,
	[Gender] [nvarchar](10) NULL,
	[Birthday] [date] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillId] [int] IDENTITY(1,1) NOT NULL,
	[TableId] [int] NULL,
	[DateOrder] [date] NULL,
	[DatePayment] [date] NULL,
	[Status] [nvarchar](50) NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[BillDetailsId] [int] IDENTITY(1,1) NOT NULL,
	[BillId] [int] NULL,
	[FoodId] [int] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[BillDetailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[FoodId] [int] IDENTITY(1,1) NOT NULL,
	[Price] [int] NULL,
	[FoodName] [nvarchar](100) NULL,
	[FoodTypeId] [int] NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodType]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodType](
	[FoodTypeId] [int] IDENTITY(1,1) NOT NULL,
	[FoodTypeName] [nvarchar](100) NULL,
 CONSTRAINT [PK_FoodType] PRIMARY KEY CLUSTERED 
(
	[FoodTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReserveTable]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReserveTable](
	[TableId] [int] NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[TableName] [nvarchar](30) NULL,
 CONSTRAINT [PK_ReseveTable] PRIMARY KEY CLUSTERED 
(
	[TableId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([UserId], [UserName], [PassWord], [Name], [Role], [Gender], [Birthday]) VALUES (1, N'admin', N'2251022057731868917119086224872421513662', N'admin', N'admin', N'nam', CAST(N'1999-01-02' AS Date))
INSERT [dbo].[Account] ([UserId], [UserName], [PassWord], [Name], [Role], [Gender], [Birthday]) VALUES (2, N'hung', N'19551103112211718024621419829237533289', N'hung', N'staff', N'nam', CAST(N'1999-01-02' AS Date))
INSERT [dbo].[Account] ([UserId], [UserName], [PassWord], [Name], [Role], [Gender], [Birthday]) VALUES (1002, N'12314', N'2251022057731868917119086224872421513662', N'toan', N'staff1', N'nam', CAST(N'1999-11-05' AS Date))
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (1, 3, CAST(N'2021-12-05' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (2, 2, CAST(N'2021-12-05' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (3, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (4, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (5, 3, CAST(N'2021-12-05' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (6, 6, CAST(N'2021-12-05' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (7, 4, CAST(N'2021-12-05' AS Date), NULL, NULL, NULL)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (8, 7, CAST(N'2021-12-05' AS Date), CAST(N'2021-12-05' AS Date), N'Paid', 150000)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (13, 1, CAST(N'2021-12-05' AS Date), CAST(N'2021-12-01' AS Date), N'Paid', 30000)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (14, 8, CAST(N'2021-12-05' AS Date), CAST(N'2021-11-27' AS Date), N'Paid', 40000)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (15, 9, CAST(N'2021-12-05' AS Date), CAST(N'2021-11-23' AS Date), N'Paid', 270000)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (16, 6, CAST(N'2021-12-05' AS Date), CAST(N'2021-11-15' AS Date), N'Paid', 90000)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (1010, 2, CAST(N'2021-12-06' AS Date), CAST(N'2021-12-06' AS Date), N'Paid', 140000)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (1011, 11, CAST(N'2021-12-19' AS Date), NULL, N'Unpaid', 0)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (1012, 5, CAST(N'2021-12-19' AS Date), NULL, N'Unpaid', 0)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (2011, 12, CAST(N'2022-01-13' AS Date), CAST(N'2022-01-13' AS Date), N'Paid', 60000)
INSERT [dbo].[Bill] ([BillId], [TableId], [DateOrder], [DatePayment], [Status], [Total]) VALUES (2012, 12, CAST(N'2022-01-13' AS Date), CAST(N'2022-01-13' AS Date), N'Paid', 150000)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillDetails] ON 

INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1, 1, 1, 3)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (2, 2, 2, 2)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (3, 5, 1, 3)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (4, 6, 2, 1)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (5, 7, 1, 1)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (6, 8, 2, 3)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (7, 8, 1, 3)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (8, 8, 2, 2)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (9, 8, 3, 2)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (10, 13, 1, 3)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (11, 14, 1, 2)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (12, 14, 2, 1)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (13, 14, 9, 1)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (14, 15, 10, 1)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (15, 15, 2, 6)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (16, 15, 11, 6)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (17, 15, 12, 6)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (18, 16, 15, 3)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (19, 16, 13, 3)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1002, 1010, 1, 4)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1003, 1010, 14, 3)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1004, 1011, 1, 4)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1005, 1011, 2, 1)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1006, 1011, 6, 1)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1007, 1012, 10, 2)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1008, 1012, 9, 5)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1009, 1012, 15, 6)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1010, 1012, 10, 1)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1011, 1012, 2, 5)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (1012, 1012, 1, 1)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (2004, 2011, 1, 3)
INSERT [dbo].[BillDetails] ([BillDetailsId], [BillId], [FoodId], [Quantity]) VALUES (2007, 2012, 10, 1)
SET IDENTITY_INSERT [dbo].[BillDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (1, 20000, N'cơm chiên', 1)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (2, 10000, N'bia', 3)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (3, -35000, N'cháo gà', 3)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (4, 15000, N'thập cẩm', 1)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (5, 15000, N'cơm rang', 1)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (6, 30000, N'phở bò', 6)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (7, 25000, N'phở gà', 6)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (8, 25000, N'phở ngan', 6)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (9, 10000, N'coca-cola', 3)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (10, 150000, N'lẩu thập cẩm', 7)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (11, 5000, N'ngô', 2)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (12, 5000, N'Khoai', 2)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (13, 20000, N'cháo gà', 4)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (14, 20000, N'cháo trứng', 4)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (15, 10000, N'bánh kem', 5)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (16, 15000, N'bánh hoa quả', 5)
INSERT [dbo].[Food] ([FoodId], [Price], [FoodName], [FoodTypeId]) VALUES (1002, 10000, N'cháo bò', 1002)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodType] ON 

INSERT [dbo].[FoodType] ([FoodTypeId], [FoodTypeName]) VALUES (1, N'cơm')
INSERT [dbo].[FoodType] ([FoodTypeId], [FoodTypeName]) VALUES (2, N'Đồ nướng')
INSERT [dbo].[FoodType] ([FoodTypeId], [FoodTypeName]) VALUES (3, N'Drinks')
INSERT [dbo].[FoodType] ([FoodTypeId], [FoodTypeName]) VALUES (4, N'cháo')
INSERT [dbo].[FoodType] ([FoodTypeId], [FoodTypeName]) VALUES (5, N'cake')
INSERT [dbo].[FoodType] ([FoodTypeId], [FoodTypeName]) VALUES (6, N'phở')
INSERT [dbo].[FoodType] ([FoodTypeId], [FoodTypeName]) VALUES (7, N'Lẩu')
INSERT [dbo].[FoodType] ([FoodTypeId], [FoodTypeName]) VALUES (1002, N'cơm1')
SET IDENTITY_INSERT [dbo].[FoodType] OFF
GO
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (1, N'Empty', N'Table 1')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (2, N'Empty', N'Table 2')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (3, N'Empty', N'Table 3')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (4, N'Empty', N'Table 4')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (5, N'Already someone', N'Table 5')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (6, N'Empty', N'Table 6')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (7, N'Empty', N'Table 7')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (8, N'Empty', N'Table 8')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (9, N'Empty', N'Table 9')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (10, N'Empty', N'Table 10')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (11, N'Already someone', N'Table 11')
INSERT [dbo].[ReserveTable] ([TableId], [Status], [TableName]) VALUES (12, N'Empty', N'Table 12')
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_DatePayment]  DEFAULT (NULL) FOR [DatePayment]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_Status]  DEFAULT (N'Unpaid') FOR [Status]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_Total]  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[ReserveTable] ADD  CONSTRAINT [DF_ReseveTable_status]  DEFAULT (N'(Empty)') FOR [Status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_ReserveTable] FOREIGN KEY([TableId])
REFERENCES [dbo].[ReserveTable] ([TableId])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_ReserveTable]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Bill] FOREIGN KEY([BillId])
REFERENCES [dbo].[Bill] ([BillId])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Bill]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Food] FOREIGN KEY([FoodId])
REFERENCES [dbo].[Food] ([FoodId])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Food]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_Food_FoodType] FOREIGN KEY([FoodTypeId])
REFERENCES [dbo].[FoodType] ([FoodTypeId])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_Food_FoodType]
GO
/****** Object:  StoredProcedure [dbo].[AddFoodCategory]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddFoodCategory]
	 @foodType nvarchar(100)
AS
BEGIN
	INSERT INTO FoodType (FoodTypeName)
	VALUES (@foodType)
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateFoodCategory]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateFoodCategory]
	@newName nvarchar(100), 
	@oldName nvarchar(100)
AS
BEGIN
	UPDATE FoodType SET FoodTypeName = @newName 
	WHERE FoodTypeName = @oldName
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListMenuByIdTable]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetListMenuByIdTable] @tableId int 
	as
	begin
	   select ta.FoodName,ct.Quantity,ta.Price,ct.Quantity*ta.Price as 'Total Money'
       from Food as ta,BillDetails as ct,Bill as hd
       where ta.FoodId=ct.FoodId and ct.BillId=hd.BillId
	and hd.TableId=@tableId and hd.Status='Unpaid'
	end
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Login] @userName varchar(100), @passWord varchar(100)
as
begin
	select * from Account where UserName=@userName and PassWord = @passWord
End
GO
/****** Object:  StoredProcedure [dbo].[USP_MergeTable]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_MergeTable] @tableId1 int,@tableId2 int
as
begin
declare @billId1 int  
declare @billId2 int

select @billId1=BillId from Bill
where TableId=@tableId1 and Status='Unpaid'
select @billId2=BillId from Bill
where TableId=@tableId2 and Status='Unpaid'
 if(@billId2 is null)
  begin 
	insert into Bill(TableId)
	values(@tableId2)
	select @billId2=max(BillId) from Bill
	update BillDetails set BillId=@billId2 where BillId=@billId1
	update ReserveTable set Status='Empty' where TableId=@tableId1
	update ReserveTable set Status='Already someone' where TableId=@tableId2
	delete Bill where BillId=@billId1
  end
  else
  begin
	update BillDetails set BillId=@billId2 where BillId=@billId1;
	delete Bill where BillId=@billId1
	update ReserveTable set Status='Empty' where TableId=@tableId1
  end
  end
GO
/****** Object:  StoredProcedure [dbo].[USP_Signup]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Signup] @UserName varchar(100), @PassWord varchar(100)
as
begin
	insert into Account(UserName, PassWord) values (@UserName, @PassWord)
	end
GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTable]    Script Date: 1/20/2022 8:10:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_SwitchTable] @tableId1 int,@tableId2 int
as
begin
declare @billId1 int  
declare @billId2 int

select @billId1=BillId from Bill
where TableId=@tableId1 and Status='Unpaid'
select @billId2=BillId from Bill
where TableId=@tableId2 and Status='Unpaid'
if(@billId2 is null)
  begin 
	insert into Bill(TableId)
	values(@tableId2)
	select @billId2=max(BillId) from Bill
	update BillDetails set BillId=@billId2 where BillId=@billId1
	update ReserveTable set Status='Empty' where TableId=@tableId1
	update ReserveTable set Status='Already someone' where TableId=@tableId2
	delete Bill where BillId=@billId1
  end
else if(@billId1 is null)
  begin
	insert into Bill(TableId)
	values(@tableId1)
	select @billId1=max(BillId) from Bill
	update BillDetails set BillId=@billId1 where BillId=@billId2
	update ReserveTable set Status='Empty' where TableId=@tableId2
	update ReserveTable set Status='Already someone' where TableId=@tableId1
	delete Bill where BillId=@billId2
  end
else
  begin
	select BillDetailsId into temp
	from BillDetails
	where BillId=@billId1 

	update BillDetails set BillId=@billId1 where BillId=@billId2;
	update BillDetails set BillId=@billId2 
	where BillDetailsId in (select BillDetailsId from temp)
	drop table temp
  end
 

end

GO
