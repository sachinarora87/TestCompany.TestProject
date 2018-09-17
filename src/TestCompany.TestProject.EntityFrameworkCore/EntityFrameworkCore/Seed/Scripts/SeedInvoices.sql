USE [TestProjectDb]

DELETE FROM [dbo].[InvoiceLines]
DELETE FROM [dbo].Invoices


USE [TestProjectDb]

SET IDENTITY_INSERT [dbo].[Invoices] ON 

INSERT [dbo].[Invoices] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [OrderDate], [OrderNumber], [InvoiceNumber], [PalletId], [TenantId]) VALUES (652, CAST(N'2018-09-14T05:23:57.4799258' AS DateTime2), 2, NULL, NULL, CAST(N'2018-08-09T00:00:00.0000000' AS DateTime2), 704209, 4639475, 19, 1)

INSERT [dbo].[Invoices] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [OrderDate], [OrderNumber], [InvoiceNumber], [PalletId], [TenantId]) VALUES (653, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, CAST(N'2018-08-09T00:00:00.0000000' AS DateTime2), 704209, 4694723, 22, 1)

INSERT [dbo].[Invoices] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [OrderDate], [OrderNumber], [InvoiceNumber], [PalletId], [TenantId]) VALUES (654, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, CAST(N'2018-08-09T00:00:00.0000000' AS DateTime2), 704209, 4695267, 22, 1)

INSERT [dbo].[Invoices] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [OrderDate], [OrderNumber], [InvoiceNumber], [PalletId], [TenantId]) VALUES (655, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, CAST(N'2018-08-09T00:00:00.0000000' AS DateTime2), 704209, 4695564, 22, 1)

INSERT [dbo].[Invoices] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [OrderDate], [OrderNumber], [InvoiceNumber], [PalletId], [TenantId]) VALUES (656, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, CAST(N'2018-08-09T00:00:00.0000000' AS DateTime2), 704209, 4695888, 22, 1)

INSERT [dbo].[Invoices] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [OrderDate], [OrderNumber], [InvoiceNumber], [PalletId], [TenantId]) VALUES (657, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, CAST(N'2018-08-09T00:00:00.0000000' AS DateTime2), 704209, 4696571, 22, 1)

INSERT [dbo].[Invoices] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [OrderDate], [OrderNumber], [InvoiceNumber], [PalletId], [TenantId]) VALUES (658, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, CAST(N'2018-08-09T00:00:00.0000000' AS DateTime2), 704209, 4696585, 22, 1)

INSERT [dbo].[Invoices] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [OrderDate], [OrderNumber], [InvoiceNumber], [PalletId], [TenantId]) VALUES (659, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, CAST(N'2018-08-09T00:00:00.0000000' AS DateTime2), 704209, 4696783, 22, 1)

INSERT [dbo].[Invoices] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [OrderDate], [OrderNumber], [InvoiceNumber], [PalletId], [TenantId]) VALUES (660, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, CAST(N'2018-08-09T00:00:00.0000000' AS DateTime2), 704209, 4696827, 22, 1)

SET IDENTITY_INSERT [dbo].[Invoices] OFF

SET IDENTITY_INSERT [dbo].[InvoiceLines] ON 

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1891, CAST(N'2018-09-14T05:23:57.4809332' AS DateTime2), 2, NULL, NULL, N'351204', NULL, 1, 6, 2315672, CAST(9.76 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 652, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1892, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'659489', NULL, 1, 6, 2316016, CAST(7.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 658, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1893, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'895797', NULL, 1, 6, 2315975, CAST(9.74 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 658, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1894, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'176595', NULL, 1, 6, 2315968, CAST(7.48 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 659, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1895, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'755728', NULL, 1, 12, 2315971, CAST(9.38 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 659, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1896, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'778835', NULL, 1, 6, 2315937, CAST(8.30 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 659, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1897, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'419437', NULL, 1, 6, 2315946, CAST(10.14 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1898, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'454651', NULL, 1, 6, 2316003, CAST(4.78 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1899, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'577653', NULL, 1, 6, 2315988, CAST(10.06 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1900, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'659489', NULL, 1, 6, 2316015, CAST(7.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1901, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'672325', NULL, 1, 6, 2315954, CAST(8.20 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1902, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'673432', NULL, 1, 6, 2315994, CAST(9.14 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1903, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'697326', NULL, 1, 6, 2315957, CAST(9.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1904, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'699715', NULL, 1, 6, 2315948, CAST(7.70 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1905, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'700018', NULL, 1, 6, 2315940, CAST(7.16 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1906, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'755728', NULL, 1, 12, 2315969, CAST(9.38 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 660, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1907, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'577653', NULL, 1, 6, 2315990, CAST(10.06 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 658, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1908, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'454651', NULL, 1, 6, 2316004, CAST(4.78 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 658, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1909, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'841200', NULL, 1, 12, 2316025, CAST(1.96 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 657, 1)

INSERT [dbo].[InvoiceLines] ([Id], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [ArticleNumber], [ArticleDescription], [Quantity], [PackSize], [CartonNumber], [CartonWeight], [ChargeWeight], [Status], [InvoiceId], [TenantId]) VALUES (1910, CAST(N'2018-09-14T05:23:57.4829340' AS DateTime2), 2, NULL, NULL, N'778835', NULL, 1, 6, 2315936, CAST(8.30 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Created', 657, 1)


SET IDENTITY_INSERT [dbo].[InvoiceLines] OFF

