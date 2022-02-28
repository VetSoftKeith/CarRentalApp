USE [CarRental]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 2/28/2022 12:28:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CarMake] [varchar](50) NOT NULL,
	[CarModel] [varchar](50) NOT NULL,
	[CarYear] [int] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Purchased] [datetime] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_AllCarsByMake]    Script Date: 2/28/2022 12:28:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_AllCarsByMake]
AS
SELECT        TOP (100) PERCENT CarMake, CarModel, CarYear, Status
FROM            dbo.Inventory
ORDER BY CarMake, CarModel, CarYear
GO
/****** Object:  View [dbo].[View_AllCarsByModel]    Script Date: 2/28/2022 12:28:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_AllCarsByModel]
AS
SELECT        TOP (100) PERCENT CarMake, CarModel, CarYear, Status
FROM            dbo.Inventory
ORDER BY CarModel, CarMake, CarYear
GO
/****** Object:  View [dbo].[View_AllCarsByYear]    Script Date: 2/28/2022 12:28:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_AllCarsByYear]
AS
SELECT        TOP (100) PERCENT CarMake, CarModel, CarYear, Status
FROM            dbo.Inventory
ORDER BY CarYear, CarMake, CarModel
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/28/2022 12:28:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[StreetAddress] [varchar](250) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [char](2) NOT NULL,
	[ZipCode] [int] NOT NULL,
	[InsuranceVerified] [tinyint] NOT NULL,
	[InsuranceCompanyId] [int] NOT NULL,
	[InsuranceExpirationDate] [datetime] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InsuranceCompany]    Script Date: 2/28/2022 12:28:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InsuranceCompany](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[State] [char](2) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_InsuranceComany] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[States]    Script Date: 2/28/2022 12:28:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[Code] [char](2) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_AllCustomers]    Script Date: 2/28/2022 12:28:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_AllCustomers]
AS
SELECT        dbo.Customer.FirstName, dbo.Customer.LastName, dbo.Customer.StreetAddress, dbo.Customer.City, dbo.Customer.State, dbo.Customer.ZipCode, dbo.Customer.InsuranceVerified, dbo.Customer.InsuranceExpirationDate, 
                         dbo.States.Code, dbo.InsuranceCompany.Name, dbo.InsuranceCompany.PhoneNumber, dbo.InsuranceCompany.State AS Expr1
FROM            dbo.Customer INNER JOIN
                         dbo.InsuranceCompany ON dbo.Customer.InsuranceCompanyId = dbo.InsuranceCompany.id INNER JOIN
                         dbo.States ON dbo.Customer.State = dbo.States.Code
GO
/****** Object:  Table [dbo].[CarRentalRecord]    Script Date: 2/28/2022 12:28:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarRentalRecord](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[DateRented] [datetime] NOT NULL,
	[DateReturned] [datetime] NOT NULL,
	[Cost] [decimal](18, 0) NOT NULL,
	[CarTypeId] [int] NULL,
 CONSTRAINT [PK_CarRentalRecord] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (5, N'Keith', N'Russo', N'123 Main St', N'Cleveland', N'OH', 44109, 1, 1, CAST(N'2022-12-25T00:00:00.000' AS DateTime), CAST(N'2022-12-25T00:00:00.000' AS DateTime), CAST(N'2022-12-25T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (7, N'Elon', N'Musk', N'123 Tesla Ct', N'CEO Ville', N'CA', 12345, 1, 1, CAST(N'2022-02-24T04:52:43.607' AS DateTime), CAST(N'2022-02-24T04:52:43.607' AS DateTime), CAST(N'2022-02-24T04:52:43.607' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (8, N'Jeff', N'Bezos', N'123 Amazon Rd', N'Seattle', N'WA', 12345, 1, 1, CAST(N'2022-02-24T04:59:33.500' AS DateTime), CAST(N'2022-02-24T04:59:33.500' AS DateTime), CAST(N'2022-02-24T04:59:33.500' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (9, N'Bernard', N'Arnault', N'321 LVMH Strasse', N'Berlin', N'AE', 42456, 1, 1, CAST(N'2022-02-24T05:00:27.510' AS DateTime), CAST(N'2022-02-24T05:00:27.510' AS DateTime), CAST(N'2022-02-24T05:00:27.510' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (10, N'Bill', N'Gates', N'654 Microsoft Ave', N'Seattle', N'WA', 45648, 1, 1, CAST(N'2022-02-24T05:01:15.110' AS DateTime), CAST(N'2022-02-24T05:01:15.110' AS DateTime), CAST(N'2022-02-24T05:01:15.110' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (11, N'Larry', N'Page', N'555 Alphabet Way', N'San Diego', N'CA', 78974, 1, 1, CAST(N'2022-02-24T05:02:00.987' AS DateTime), CAST(N'2022-02-24T05:02:00.987' AS DateTime), CAST(N'2022-02-24T05:02:00.987' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (12, N'Warren', N'Buffet', N'6546 Berkshire Way', N'Lincoln', N'NE', 12156, 1, 1, CAST(N'2022-02-24T05:02:38.863' AS DateTime), CAST(N'2022-02-24T05:02:38.863' AS DateTime), CAST(N'2022-02-24T05:02:38.863' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (13, N'Segrey', N'Brin', N'578 Alphabet Way', N'San Diego', N'CA', 45648, 1, 1, CAST(N'2022-02-24T05:03:15.203' AS DateTime), CAST(N'2022-02-24T05:03:15.203' AS DateTime), CAST(N'2022-02-24T05:03:15.203' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (14, N'Steve', N'Ballmer', N'345 Clippers Ct', N'Los Angeles', N'CA', 15648, 1, 1, CAST(N'2022-02-24T05:03:46.647' AS DateTime), CAST(N'2022-02-24T05:03:46.647' AS DateTime), CAST(N'2022-02-24T05:03:46.647' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (15, N'Larry', N'Ellison', N'829 Oracle Ln', N'Honolulu', N'HI', 78978, 1, 1, CAST(N'2022-02-24T05:04:24.167' AS DateTime), CAST(N'2022-02-24T05:04:24.167' AS DateTime), CAST(N'2022-02-24T05:04:24.167' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (16, N'Mukesh', N'Ambani', N'65456 Reliance St', N'Mumbai', N'AE', 1869, 1, 1, CAST(N'2022-02-24T05:05:15.523' AS DateTime), CAST(N'2022-02-24T05:05:15.523' AS DateTime), CAST(N'2022-02-24T05:05:15.523' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (42, N'fdsafdsa', N'vdsavdsav', N'fsdafsd', N'avdsavasd', N'AA', 67543, 1, 1, CAST(N'2022-02-24T09:16:59.137' AS DateTime), CAST(N'2022-02-24T09:16:59.137' AS DateTime), CAST(N'2022-02-24T09:16:59.137' AS DateTime))
GO
INSERT [dbo].[Customer] ([id], [FirstName], [LastName], [StreetAddress], [City], [State], [ZipCode], [InsuranceVerified], [InsuranceCompanyId], [InsuranceExpirationDate], [CreatedAt], [UpdatedAt]) VALUES (44, N'dsdsgsgds', N'gdsgadsg', N'dsagfasdgs', N'gdsagdsagdsa', N'TN', 76547, 1, 1, CAST(N'2022-02-25T06:39:36.037' AS DateTime), CAST(N'2022-02-25T06:39:36.037' AS DateTime), CAST(N'2022-02-25T06:39:36.037' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[InsuranceCompany] ON 
GO
INSERT [dbo].[InsuranceCompany] ([id], [Name], [PhoneNumber], [State], [CreatedAt], [UpdatedAt]) VALUES (1, N'USAA', 5551234, N'TX', CAST(N'2022-12-15T00:00:00.000' AS DateTime), CAST(N'2022-12-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[InsuranceCompany] ([id], [Name], [PhoneNumber], [State], [CreatedAt], [UpdatedAt]) VALUES (2, N'USAA', 5551234, N'TX', CAST(N'2022-12-15T00:00:00.000' AS DateTime), CAST(N'2022-02-28T12:17:26.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[InsuranceCompany] OFF
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'AA', N'ARMED FORCES - AMERICAS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'AB', N'ALBERTA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'AE', N'ARMED FORCES - EUROPE')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'AK', N'ALASKA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'AL', N'ALABAMA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'AP', N'ARMED FORCES - PACIFIC')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'AR', N'ARKANSAS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'AS', N'AMERICAN SAMOA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'AZ', N'ARIZONA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'BC', N'BRITISH COLUMBIA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'CA', N'CALIFORNIA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'CO', N'COLORADO')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'CT', N'CONNETICUT')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'DC', N'DISTRICT OF COLUMBIA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'DE', N'DELAWARE')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'FL', N'FLORIDA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'GA', N'GEORGIA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'GU', N'GUAM')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'HI', N'HAWAII')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'IA', N'IOWA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'ID', N'IDAHO')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'IL', N'ILLINOIS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'IN', N'INDIANA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'KS', N'KANSAS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'KY', N'KENTUCKY')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'LA', N'LOUSIANA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MA', N'MASSACHUSETTS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MB', N'MANITOBA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MD', N'MARYLAND')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'ME', N'MAINE')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MH', N'MARSHALL ISLANDS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MI', N'MICHIGAN')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MN', N'MINNESOTA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MO', N'MISSOURI')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MP', N'MARIANA ISLANDS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MS', N'MISSISSIPPI')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'MT', N'MONTANA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NB', N'NEW BRUNSWICK')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NC', N'NORTH CAROLINA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'ND', N'NORTH DAKOTA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NE', N'NEBRASKA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NF', N'NEWFOUNDLAND')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NH', N'NEW HAMPSHIRE')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NJ', N'NEW JERSEY')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NM', N'NEW MEXICO')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NS', N'NOVA SCOTIA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NT', N'NORTHWEST TERRITORIES')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NU', N'NUNAVUT')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NV', N'NEVADA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'NY', N'NEW YORK')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'OH', N'OHIO')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'OK', N'OKLAHOMA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'ON', N'ONTARIO')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'OR', N'OREGON')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'PA', N'PENNSYLVANIA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'PE', N'PRINCE EDWARD ISLAND')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'PQ', N'QUEBEC')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'PR', N'PUERTO RICO')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'PW', N'CAROLINE ISLANDS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'RI', N'RHODE ISLAND')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'SC', N'SOUTH CAROLINA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'SD', N'SOUTH DAKOTA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'SK', N'SASKATCHEWAN')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'TN', N'TENNESSEE')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'TX', N'TEXAS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'UT', N'UTAH')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'VA', N'VIRGINIA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'VI', N'VIRGIN ISLANDS')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'VT', N'VERMONT')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'WA', N'WASHINGTON')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'WI', N'WISCONSIN')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'WV', N'WEST VIRGINIA')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'WY', N'WYOMING')
GO
INSERT [dbo].[States] ([Code], [Name]) VALUES (N'YT', N'YUKON TERRITORY')
GO
ALTER TABLE [dbo].[CarRentalRecord]  WITH CHECK ADD  CONSTRAINT [FK_CarRentalRecord_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[CarRentalRecord] CHECK CONSTRAINT [FK_CarRentalRecord_Customer]
GO
ALTER TABLE [dbo].[CarRentalRecord]  WITH CHECK ADD  CONSTRAINT [FK_CarRentalRecord_Inventory] FOREIGN KEY([CarTypeId])
REFERENCES [dbo].[Inventory] ([id])
GO
ALTER TABLE [dbo].[CarRentalRecord] CHECK CONSTRAINT [FK_CarRentalRecord_Inventory]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_InsuranceCompany] FOREIGN KEY([InsuranceCompanyId])
REFERENCES [dbo].[InsuranceCompany] ([id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_InsuranceCompany]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_States] FOREIGN KEY([State])
REFERENCES [dbo].[States] ([Code])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_States]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -1630
      End
      Begin Tables = 
         Begin Table = "Inventory"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 242
               Right = 361
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AllCarsByMake'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AllCarsByMake'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Inventory"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AllCarsByModel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AllCarsByModel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Inventory"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AllCarsByYear'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AllCarsByYear'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Customer"
            Begin Extent = 
               Top = 13
               Left = 583
               Bottom = 312
               Right = 800
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "InsuranceCompany"
            Begin Extent = 
               Top = 6
               Left = 293
               Bottom = 204
               Right = 463
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "States"
            Begin Extent = 
               Top = 34
               Left = 993
               Bottom = 130
               Right = 1163
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 3045
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AllCustomers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AllCustomers'
GO
