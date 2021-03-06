USE [Avtorizacia/Registracia]
GO
/****** Object:  Table [dbo].[Dolznost]    Script Date: 28.04.2021 14:15:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dolznost](
	[KodeDolznosty] [int] IDENTITY(0,1) NOT NULL,
	[Dolznosty] [varchar](80) NULL,
 CONSTRAINT [PK_Dolznost] PRIMARY KEY CLUSTERED 
(
	[KodeDolznosty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 28.04.2021 14:15:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[KodPerson] [int] IDENTITY(0,1) NOT NULL,
	[KodPolzovately] [int] NULL,
	[LoginPolzovately] [varchar](80) NOT NULL,
	[Dolznost] [varchar](80) NOT NULL,
	[FIO] [varchar](80) NOT NULL,
	[DataRozdeniy] [date] NOT NULL,
	[NomerTelephona] [varchar](80) NOT NULL,
	[Email] [varchar](80) NULL,
	[Pol] [varchar](80) NOT NULL,
	[Photo] [varbinary](max) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[KodPerson] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Polzovatel]    Script Date: 28.04.2021 14:15:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Polzovatel](
	[CodePolzovately] [int] IDENTITY(0,1) NOT NULL,
	[Login] [varchar](80) NULL,
	[Parol] [varchar](80) NULL,
	[KodeDolznosty] [int] NULL,
 CONSTRAINT [PK_Polzovatel] PRIMARY KEY CLUSTERED 
(
	[CodePolzovately] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Dolznost] ON 

INSERT [dbo].[Dolznost] ([KodeDolznosty], [Dolznosty]) VALUES (1, N'Администратор')
INSERT [dbo].[Dolznost] ([KodeDolznosty], [Dolznosty]) VALUES (2, N'Тестировщие')
INSERT [dbo].[Dolznost] ([KodeDolznosty], [Dolznosty]) VALUES (3, N'Тестировщик')
INSERT [dbo].[Dolznost] ([KodeDolznosty], [Dolznosty]) VALUES (4, N'Тестироващик')
INSERT [dbo].[Dolznost] ([KodeDolznosty], [Dolznosty]) VALUES (5, N'Рабочий')
INSERT [dbo].[Dolznost] ([KodeDolznosty], [Dolznosty]) VALUES (6, N'Пользователь')
INSERT [dbo].[Dolznost] ([KodeDolznosty], [Dolznosty]) VALUES (7, N'Оператор')
INSERT [dbo].[Dolznost] ([KodeDolznosty], [Dolznosty]) VALUES (8, N'Менеджер')
SET IDENTITY_INSERT [dbo].[Dolznost] OFF
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([KodPerson], [KodPolzovately], [LoginPolzovately], [Dolznost], [FIO], [DataRozdeniy], [NomerTelephona], [Email], [Pol], [Photo]) VALUES (6, 2, N'EvgexaSugrob', N'Администратор', N'Пушкарев Е.А', CAST(N'1999-12-04' AS Date), N'+79824567898', N'zenj.bakal@mail.ru', N'Мужской', NULL)
INSERT [dbo].[Persona] ([KodPerson], [KodPolzovately], [LoginPolzovately], [Dolznost], [FIO], [DataRozdeniy], [NomerTelephona], [Email], [Pol], [Photo]) VALUES (7, 3, N'TestNomer2', N'Тестировщие', N'Иванов. И.И', CAST(N'1999-01-01' AS Date), N'+79191919191', N'Test@mail.ru', N'Мужской', NULL)
INSERT [dbo].[Persona] ([KodPerson], [KodPolzovately], [LoginPolzovately], [Dolznost], [FIO], [DataRozdeniy], [NomerTelephona], [Email], [Pol], [Photo]) VALUES (8, NULL, N'Test#4', N'Тестировщик', N'Иванов И.И', CAST(N'1987-12-04' AS Date), N'+79854561245', N'Test#4@mail.ru', N'Мужской', NULL)
INSERT [dbo].[Persona] ([KodPerson], [KodPolzovately], [LoginPolzovately], [Dolznost], [FIO], [DataRozdeniy], [NomerTelephona], [Email], [Pol], [Photo]) VALUES (9, NULL, N'TEst#3QwErt', N'Тестироващик', N'Петров П.П', CAST(N'1998-04-05' AS Date), N'+79511599515', N'Petr@mail.ru', N'Мужской', NULL)
INSERT [dbo].[Persona] ([KodPerson], [KodPolzovately], [LoginPolzovately], [Dolznost], [FIO], [DataRozdeniy], [NomerTelephona], [Email], [Pol], [Photo]) VALUES (10, 6, N'RaBotNik', N'Рабочий', N'Зубенко М.П', CAST(N'1974-01-18' AS Date), N'+79544567510', N'miSha@mail.ru', N'Мужской', NULL)
INSERT [dbo].[Persona] ([KodPerson], [KodPolzovately], [LoginPolzovately], [Dolznost], [FIO], [DataRozdeniy], [NomerTelephona], [Email], [Pol], [Photo]) VALUES (11, 7, N'Xapacyc', N'Пользователь', N'Алабушкин И.Д.', CAST(N'1999-06-17' AS Date), N'+79128089989', N'Xapacyc@gmail.com', N'Мужской', NULL)
INSERT [dbo].[Persona] ([KodPerson], [KodPolzovately], [LoginPolzovately], [Dolznost], [FIO], [DataRozdeniy], [NomerTelephona], [Email], [Pol], [Photo]) VALUES (12, 8, N'ValeraOperator', N'Оператор', N'Шумков В.В', CAST(N'1999-01-12' AS Date), N'+79851546578', N'Valera300$@gmail.ru', N'Мужской', NULL)
INSERT [dbo].[Persona] ([KodPerson], [KodPolzovately], [LoginPolzovately], [Dolznost], [FIO], [DataRozdeniy], [NomerTelephona], [Email], [Pol], [Photo]) VALUES (13, 9, N'OlgaMeneger', N'Менеджер', N'Фиалкова О.А.', CAST(N'1997-05-04' AS Date), N'+79124563214', N'olga1997@mail.ru', N'Женский', NULL)
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
SET IDENTITY_INSERT [dbo].[Polzovatel] ON 

INSERT [dbo].[Polzovatel] ([CodePolzovately], [Login], [Parol], [KodeDolznosty]) VALUES (2, N'EvgexaSugrob', N'QwerT1234', 1)
INSERT [dbo].[Polzovatel] ([CodePolzovately], [Login], [Parol], [KodeDolznosty]) VALUES (3, N'TestNomer2', N'ЕуыеЙЦУКен1', NULL)
INSERT [dbo].[Polzovatel] ([CodePolzovately], [Login], [Parol], [KodeDolznosty]) VALUES (4, N'Test#4', N'Еуые№4йцуке', NULL)
INSERT [dbo].[Polzovatel] ([CodePolzovately], [Login], [Parol], [KodeDolznosty]) VALUES (5, N'TEst#3QwErt', N'TEst#3QwErt', NULL)
INSERT [dbo].[Polzovatel] ([CodePolzovately], [Login], [Parol], [KodeDolznosty]) VALUES (6, N'RaBotNik', N'rabotnikGoda', 5)
INSERT [dbo].[Polzovatel] ([CodePolzovately], [Login], [Parol], [KodeDolznosty]) VALUES (7, N'Xapacyc', N'qwerty123456', 6)
INSERT [dbo].[Polzovatel] ([CodePolzovately], [Login], [Parol], [KodeDolznosty]) VALUES (8, N'ValeraOperator', N'ValeraOper123456', 7)
INSERT [dbo].[Polzovatel] ([CodePolzovately], [Login], [Parol], [KodeDolznosty]) VALUES (9, N'OlgaMeneger', N'CoolMeneger1298', 8)
SET IDENTITY_INSERT [dbo].[Polzovatel] OFF
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_Polzovatel] FOREIGN KEY([KodPolzovately])
REFERENCES [dbo].[Polzovatel] ([CodePolzovately])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_Polzovatel]
GO
ALTER TABLE [dbo].[Polzovatel]  WITH CHECK ADD  CONSTRAINT [FK_Polzovatel_Dolznost] FOREIGN KEY([KodeDolznosty])
REFERENCES [dbo].[Dolznost] ([KodeDolznosty])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Polzovatel] CHECK CONSTRAINT [FK_Polzovatel_Dolznost]
GO
