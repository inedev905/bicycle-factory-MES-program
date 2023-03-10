USE [master]
GO
/****** Object:  Database [TEAM2]    Script Date: 2022-12-19 오후 5:41:24 ******/
CREATE DATABASE [TEAM2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TEAM2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TEAM2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TEAM2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TEAM2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TEAM2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TEAM2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TEAM2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TEAM2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TEAM2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TEAM2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TEAM2] SET ARITHABORT OFF 
GO
ALTER DATABASE [TEAM2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TEAM2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TEAM2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TEAM2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TEAM2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TEAM2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TEAM2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TEAM2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TEAM2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TEAM2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TEAM2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TEAM2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TEAM2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TEAM2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TEAM2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TEAM2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TEAM2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TEAM2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TEAM2] SET  MULTI_USER 
GO
ALTER DATABASE [TEAM2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TEAM2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TEAM2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TEAM2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TEAM2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TEAM2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TEAM2] SET QUERY_STORE = OFF
GO
USE [TEAM2]
GO
/****** Object:  User [team2]    Script Date: 2022-12-19 오후 5:41:24 ******/
CREATE USER [team2] FOR LOGIN [team2] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [team2]
GO
/****** Object:  Table [dbo].[bom]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bom](
	[bom_id] [int] IDENTITY(1,1) NOT NULL,
	[porduct_id] [int] NULL,
	[material_id] [int] NULL,
	[bom_materialRate] [decimal](10, 4) NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
 CONSTRAINT [PK__bom__0DA7C8871ED76715] PRIMARY KEY CLUSTERED 
(
	[bom_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[commoncode]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[commoncode](
	[code] [nvarchar](10) NOT NULL,
	[category] [nvarchar](20) NULL,
	[name] [nvarchar](30) NULL,
	[pcode] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[company]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company](
	[company_id] [int] IDENTITY(1,1) NOT NULL,
	[business_num] [nvarchar](12) NULL,
	[company_name] [nvarchar](20) NULL,
	[region_code] [nvarchar](5) NULL,
	[phone] [nvarchar](9) NULL,
	[zipCode] [nvarchar](10) NULL,
	[address1] [nvarchar](100) NULL,
	[address2] [nvarchar](100) NULL,
	[contact_name] [nvarchar](5) NULL,
	[contact_phone1] [nvarchar](5) NULL,
	[contact_phone2] [nvarchar](9) NULL,
	[contact_email] [nvarchar](30) NULL,
	[business_category] [nvarchar](5) NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[company_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[emp_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_name] [nvarchar](5) NULL,
	[dep_code] [nvarchar](10) NULL,
	[title_code] [nvarchar](10) NULL,
	[gender] [bit] NULL,
	[phone1] [nvarchar](5) NULL,
	[phone2] [nvarchar](9) NULL,
	[email] [nvarchar](30) NULL,
	[zipCode] [nvarchar](10) NULL,
	[address1] [nvarchar](100) NULL,
	[address2] [nvarchar](100) NULL,
	[emp_deleted] [bit] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[material]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[material](
	[material_id] [int] IDENTITY(1,1) NOT NULL,
	[material_name] [nvarchar](20) NULL,
	[material_Qty] [int] NULL,
	[material_safety] [int] NULL,
	[material_QtyLimit] [int] NULL,
	[material_category] [nvarchar](10) NULL,
	[material_Img] [nvarchar](50) NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[material_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materialCompany]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materialCompany](
	[materialCompany_id] [int] IDENTITY(1,1) NOT NULL,
	[material_id] [int] NULL,
	[company_id] [int] NULL,
	[main] [bit] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[materialCompany_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[menu_id] [int] IDENTITY(1,1) NOT NULL,
	[menu_name] [nvarchar](30) NULL,
	[menu_level] [int] NULL,
	[pnt_menu_id] [int] NULL,
	[program_name] [nvarchar](30) NULL,
	[menu_Img] [nvarchar](50) NULL,
	[menu_sort] [int] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[menu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menuAuth]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menuAuth](
	[menu_auth_id] [int] IDENTITY(1,1) NOT NULL,
	[menu_id] [int] NULL,
	[dep_code] [nvarchar](10) NULL,
	[title_code] [nvarchar](10) NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[menu_auth_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderDetail]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderDetail](
	[orderDetail_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NULL,
	[product_id] [int] NULL,
	[orderDetail_Qty] [int] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderDetail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[order_date] [datetime] NULL,
	[due_date] [datetime] NULL,
	[company_id] [int] NULL,
	[order_state] [nvarchar](5) NULL,
	[emp_id] [int] NULL,
	[receive_date] [datetime] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
 CONSTRAINT [PK__orders__46596229409EF342] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produce]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produce](
	[produce_id] [int] IDENTITY(1,1) NOT NULL,
	[product_startDate] [datetime] NULL,
	[product_status] [bit] NULL,
	[product_dueDate] [datetime] NULL,
	[product_endDate] [datetime] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[produce_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produceDetail]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produceDetail](
	[produceDetail_id] [int] IDENTITY(1,1) NOT NULL,
	[produce_id] [int] NULL,
	[product_id] [int] NULL,
	[produceDetail_Amount] [int] NULL,
	[product_status] [bit] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[produceDetail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [nvarchar](20) NULL,
	[product_Qty] [int] NULL,
	[product_Safety] [int] NULL,
	[product_QtyLimit] [int] NULL,
	[product_category] [nvarchar](10) NULL,
	[product_Img] [nvarchar](50) NULL,
	[product_chargeEmp] [int] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productCompany]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productCompany](
	[productCompany_id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[company_id] [int] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[productCompany_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchase]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchase](
	[purchase_id] [int] IDENTITY(1,1) NOT NULL,
	[purchase_date] [datetime] NULL,
	[purchase_inDate] [datetime] NULL,
	[purchase_dueDate] [datetime] NULL,
	[company_id] [nvarchar](10) NULL,
	[purchase_state] [nvarchar](5) NULL,
	[emp_id] [int] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[purchase_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchaseDetail]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchaseDetail](
	[purchaseDetail_id] [int] IDENTITY(1,1) NOT NULL,
	[purchase_id] [int] NULL,
	[material_id] [int] NULL,
	[purchaseDetail_Qty] [int] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[purchaseDetail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[work]    Script Date: 2022-12-19 오후 5:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[work](
	[work_id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[emp_id] [int] NULL,
	[work_name] [nvarchar](10) NULL,
	[work_deleted] [bit] NULL,
	[pre_work] [int] NULL,
	[work_time] [int] NULL,
	[first_writeEmp] [int] NULL,
	[first_writeDate] [datetime] NULL,
	[latest_writeEmp] [int] NULL,
	[latest_writeDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[work_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[work] ADD  DEFAULT ((0)) FOR [work_deleted]
GO
ALTER TABLE [dbo].[bom]  WITH CHECK ADD  CONSTRAINT [FK_bom_material] FOREIGN KEY([material_id])
REFERENCES [dbo].[material] ([material_id])
GO
ALTER TABLE [dbo].[bom] CHECK CONSTRAINT [FK_bom_material]
GO
ALTER TABLE [dbo].[bom]  WITH CHECK ADD  CONSTRAINT [FK_bom_product] FOREIGN KEY([porduct_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[bom] CHECK CONSTRAINT [FK_bom_product]
GO
ALTER TABLE [dbo].[materialCompany]  WITH CHECK ADD  CONSTRAINT [FK_materialCompany_company] FOREIGN KEY([company_id])
REFERENCES [dbo].[company] ([company_id])
GO
ALTER TABLE [dbo].[materialCompany] CHECK CONSTRAINT [FK_materialCompany_company]
GO
ALTER TABLE [dbo].[materialCompany]  WITH CHECK ADD  CONSTRAINT [FK_materialCompany_material] FOREIGN KEY([material_id])
REFERENCES [dbo].[material] ([material_id])
GO
ALTER TABLE [dbo].[materialCompany] CHECK CONSTRAINT [FK_materialCompany_material]
GO
ALTER TABLE [dbo].[menu]  WITH CHECK ADD  CONSTRAINT [FK_menu_menu] FOREIGN KEY([pnt_menu_id])
REFERENCES [dbo].[menu] ([menu_id])
GO
ALTER TABLE [dbo].[menu] CHECK CONSTRAINT [FK_menu_menu]
GO
ALTER TABLE [dbo].[menuAuth]  WITH CHECK ADD  CONSTRAINT [FK_menuAuth_menu] FOREIGN KEY([menu_id])
REFERENCES [dbo].[menu] ([menu_id])
GO
ALTER TABLE [dbo].[menuAuth] CHECK CONSTRAINT [FK_menuAuth_menu]
GO
ALTER TABLE [dbo].[orderDetail]  WITH CHECK ADD  CONSTRAINT [FK_orderDetail_orders] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([order_id])
GO
ALTER TABLE [dbo].[orderDetail] CHECK CONSTRAINT [FK_orderDetail_orders]
GO
ALTER TABLE [dbo].[orderDetail]  WITH CHECK ADD  CONSTRAINT [FK_orderDetail_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[orderDetail] CHECK CONSTRAINT [FK_orderDetail_product]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_company] FOREIGN KEY([company_id])
REFERENCES [dbo].[company] ([company_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_company]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_employee] FOREIGN KEY([emp_id])
REFERENCES [dbo].[employee] ([emp_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_employee]
GO
ALTER TABLE [dbo].[produceDetail]  WITH CHECK ADD  CONSTRAINT [FK_produceDetail_produce] FOREIGN KEY([produce_id])
REFERENCES [dbo].[produce] ([produce_id])
GO
ALTER TABLE [dbo].[produceDetail] CHECK CONSTRAINT [FK_produceDetail_produce]
GO
ALTER TABLE [dbo].[produceDetail]  WITH CHECK ADD  CONSTRAINT [FK_produceDetail_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[produceDetail] CHECK CONSTRAINT [FK_produceDetail_product]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_employee] FOREIGN KEY([product_chargeEmp])
REFERENCES [dbo].[employee] ([emp_id])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_employee]
GO
ALTER TABLE [dbo].[productCompany]  WITH CHECK ADD  CONSTRAINT [FK_productCompany_company] FOREIGN KEY([company_id])
REFERENCES [dbo].[company] ([company_id])
GO
ALTER TABLE [dbo].[productCompany] CHECK CONSTRAINT [FK_productCompany_company]
GO
ALTER TABLE [dbo].[productCompany]  WITH CHECK ADD  CONSTRAINT [FK_productCompany_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[productCompany] CHECK CONSTRAINT [FK_productCompany_product]
GO
ALTER TABLE [dbo].[purchase]  WITH CHECK ADD  CONSTRAINT [FK_purchase_employee] FOREIGN KEY([emp_id])
REFERENCES [dbo].[employee] ([emp_id])
GO
ALTER TABLE [dbo].[purchase] CHECK CONSTRAINT [FK_purchase_employee]
GO
ALTER TABLE [dbo].[purchaseDetail]  WITH CHECK ADD  CONSTRAINT [FK_purchaseDetail_material] FOREIGN KEY([material_id])
REFERENCES [dbo].[material] ([material_id])
GO
ALTER TABLE [dbo].[purchaseDetail] CHECK CONSTRAINT [FK_purchaseDetail_material]
GO
ALTER TABLE [dbo].[purchaseDetail]  WITH CHECK ADD  CONSTRAINT [FK_purchaseDetail_purchase] FOREIGN KEY([purchase_id])
REFERENCES [dbo].[purchase] ([purchase_id])
GO
ALTER TABLE [dbo].[purchaseDetail] CHECK CONSTRAINT [FK_purchaseDetail_purchase]
GO
ALTER TABLE [dbo].[work]  WITH CHECK ADD  CONSTRAINT [FK_work_employee] FOREIGN KEY([emp_id])
REFERENCES [dbo].[employee] ([emp_id])
GO
ALTER TABLE [dbo].[work] CHECK CONSTRAINT [FK_work_employee]
GO
ALTER TABLE [dbo].[work]  WITH CHECK ADD  CONSTRAINT [FK_work_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[work] CHECK CONSTRAINT [FK_work_product]
GO
ALTER TABLE [dbo].[work]  WITH CHECK ADD  CONSTRAINT [FK_work_work] FOREIGN KEY([pre_work])
REFERENCES [dbo].[work] ([work_id])
GO
ALTER TABLE [dbo].[work] CHECK CONSTRAINT [FK_work_work]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'BOM코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'bom', @level2type=N'COLUMN',@level2name=N'bom_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'bom', @level2type=N'COLUMN',@level2name=N'porduct_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'bom', @level2type=N'COLUMN',@level2name=N'material_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재소요량' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'bom', @level2type=N'COLUMN',@level2name=N'bom_materialRate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'공통코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'commoncode', @level2type=N'COLUMN',@level2name=N'code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'카테고리' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'commoncode', @level2type=N'COLUMN',@level2name=N'category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'코드명' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'commoncode', @level2type=N'COLUMN',@level2name=N'name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'세부코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'commoncode', @level2type=N'COLUMN',@level2name=N'pcode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'거래처코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'company_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'사업자번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'business_num'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'거래처이름' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'company_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'지역번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'region_code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'전화번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'우편번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'zipCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주소' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'address1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'상세주소' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'address2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'담당자이름' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'contact_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'담당자 전화번호1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'contact_phone1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'담당자 전화번호2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'contact_phone2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'담당자 이메일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'contact_email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'거래구분' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company', @level2type=N'COLUMN',@level2name=N'business_category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'직원번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'emp_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'직원이름' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'emp_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'부서코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'dep_code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'직책코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'title_code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'성별' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'gender'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'전화번호1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'phone1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'전화번호2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'phone2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'이메일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'우편번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'zipCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주소' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'address1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'상세주소' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'address2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'퇴사여부' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'employee', @level2type=N'COLUMN',@level2name=N'emp_deleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'material', @level2type=N'COLUMN',@level2name=N'material_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재명' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'material', @level2type=N'COLUMN',@level2name=N'material_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재수량' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'material', @level2type=N'COLUMN',@level2name=N'material_Qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'안전재고' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'material', @level2type=N'COLUMN',@level2name=N'material_safety'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'최소주문수량' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'material', @level2type=N'COLUMN',@level2name=N'material_QtyLimit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재카테고리' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'material', @level2type=N'COLUMN',@level2name=N'material_category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재이미지' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'material', @level2type=N'COLUMN',@level2name=N'material_Img'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재거래처코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'materialCompany', @level2type=N'COLUMN',@level2name=N'materialCompany_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'저재코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'materialCompany', @level2type=N'COLUMN',@level2name=N'material_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'거래처코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'materialCompany', @level2type=N'COLUMN',@level2name=N'company_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주거레처' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'materialCompany', @level2type=N'COLUMN',@level2name=N'main'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'메뉴번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menu', @level2type=N'COLUMN',@level2name=N'menu_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'메뉴명' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menu', @level2type=N'COLUMN',@level2name=N'menu_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'메뉴레벨' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menu', @level2type=N'COLUMN',@level2name=N'menu_level'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'부모메뉴번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menu', @level2type=N'COLUMN',@level2name=N'pnt_menu_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'프로그램명' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menu', @level2type=N'COLUMN',@level2name=N'program_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'메뉴(버튼)이미지' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menu', @level2type=N'COLUMN',@level2name=N'menu_Img'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'메뉴정렬순서' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menu', @level2type=N'COLUMN',@level2name=N'menu_sort'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'일련번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menuAuth', @level2type=N'COLUMN',@level2name=N'menu_auth_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'메뉴번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menuAuth', @level2type=N'COLUMN',@level2name=N'menu_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'부서코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menuAuth', @level2type=N'COLUMN',@level2name=N'dep_code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'직책코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'menuAuth', @level2type=N'COLUMN',@level2name=N'title_code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문상세번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orderDetail', @level2type=N'COLUMN',@level2name=N'orderDetail_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orderDetail', @level2type=N'COLUMN',@level2name=N'order_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orderDetail', @level2type=N'COLUMN',@level2name=N'product_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문수량' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orderDetail', @level2type=N'COLUMN',@level2name=N'orderDetail_Qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orders', @level2type=N'COLUMN',@level2name=N'order_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'납기일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orders', @level2type=N'COLUMN',@level2name=N'order_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'납기일자' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orders', @level2type=N'COLUMN',@level2name=N'due_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'거래처코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orders', @level2type=N'COLUMN',@level2name=N'company_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문상태' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orders', @level2type=N'COLUMN',@level2name=N'order_state'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문자' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orders', @level2type=N'COLUMN',@level2name=N'emp_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'입고일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'orders', @level2type=N'COLUMN',@level2name=N'receive_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'생산지시번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produce', @level2type=N'COLUMN',@level2name=N'produce_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'생산시작일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produce', @level2type=N'COLUMN',@level2name=N'product_startDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'생산상태' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produce', @level2type=N'COLUMN',@level2name=N'product_status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'생산납기' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produce', @level2type=N'COLUMN',@level2name=N'product_dueDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'생산완료일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produce', @level2type=N'COLUMN',@level2name=N'product_endDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'생산지시상세번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produceDetail', @level2type=N'COLUMN',@level2name=N'produceDetail_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'생산지시번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produceDetail', @level2type=N'COLUMN',@level2name=N'produce_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produceDetail', @level2type=N'COLUMN',@level2name=N'product_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'생산량' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produceDetail', @level2type=N'COLUMN',@level2name=N'produceDetail_Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'생산상태' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produceDetail', @level2type=N'COLUMN',@level2name=N'product_status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'product', @level2type=N'COLUMN',@level2name=N'product_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품명' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'product', @level2type=N'COLUMN',@level2name=N'product_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품수량' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'product', @level2type=N'COLUMN',@level2name=N'product_Qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'안전재고' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'product', @level2type=N'COLUMN',@level2name=N'product_Safety'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'최소주문수량' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'product', @level2type=N'COLUMN',@level2name=N'product_QtyLimit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품카테고리' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'product', @level2type=N'COLUMN',@level2name=N'product_category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품이미지' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'product', @level2type=N'COLUMN',@level2name=N'product_Img'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'담당직원' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'product', @level2type=N'COLUMN',@level2name=N'product_chargeEmp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품거래처코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'productCompany', @level2type=N'COLUMN',@level2name=N'productCompany_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'productCompany', @level2type=N'COLUMN',@level2name=N'product_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'거래처코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'productCompany', @level2type=N'COLUMN',@level2name=N'company_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'발주번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchase', @level2type=N'COLUMN',@level2name=N'purchase_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'발주일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchase', @level2type=N'COLUMN',@level2name=N'purchase_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'입고일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchase', @level2type=N'COLUMN',@level2name=N'purchase_inDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'입고예정일' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchase', @level2type=N'COLUMN',@level2name=N'purchase_dueDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'거래처코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchase', @level2type=N'COLUMN',@level2name=N'company_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'발주상태' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchase', @level2type=N'COLUMN',@level2name=N'purchase_state'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'발주자' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchase', @level2type=N'COLUMN',@level2name=N'emp_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'발주상세번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchaseDetail', @level2type=N'COLUMN',@level2name=N'purchaseDetail_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'발주번호' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchaseDetail', @level2type=N'COLUMN',@level2name=N'purchase_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'자재코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchaseDetail', @level2type=N'COLUMN',@level2name=N'material_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'주문수량' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'purchaseDetail', @level2type=N'COLUMN',@level2name=N'purchaseDetail_Qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'공정코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'work', @level2type=N'COLUMN',@level2name=N'work_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'제품코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'work', @level2type=N'COLUMN',@level2name=N'product_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'담당직원코드' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'work', @level2type=N'COLUMN',@level2name=N'emp_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'공정명' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'work', @level2type=N'COLUMN',@level2name=N'work_name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'공정삭제여부' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'work', @level2type=N'COLUMN',@level2name=N'work_deleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'선행공정' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'work', @level2type=N'COLUMN',@level2name=N'pre_work'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'공정시간' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'work', @level2type=N'COLUMN',@level2name=N'work_time'
GO
USE [master]
GO
ALTER DATABASE [TEAM2] SET  READ_WRITE 
GO
