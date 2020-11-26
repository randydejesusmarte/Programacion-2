CREATE DATABASE [Control_Financiero]
GO
USE [Control_Financiero]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 25/11/2020 10:25:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom_cli] [nchar](10) NULL,
	[Num_cue] [nchar](10) NULL,
	[Tip_cue] [nchar](10) NULL,
	[Ced_cli] [nchar](10) NULL,
	[Val_cue] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deposito]    Script Date: 25/11/2020 10:25:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deposito](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Num_cue] [nchar](10) NULL,
	[Tip_cue] [nchar](10) NULL,
	[Val_dep] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 25/11/2020 10:25:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamos](
	[Num_cuo] [int] NULL,
	[Fecha] [date] NULL,
	[Mon_pre] [int] NULL,
	[Taz_int] [varchar](50) NULL,
	[Interes] [int] NULL,
	[Tot_pres] [int] NULL,
	[Concepto] [varchar](50) NULL,
	[Num_cue] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Retiro]    Script Date: 25/11/2020 10:25:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Retiro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Num_cue] [char](10) NULL,
	[Tip_cue] [nchar](10) NULL,
	[Val_ret] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25/11/2020 10:25:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Ide_usu] [int] IDENTITY(1,1) NOT NULL,
	[Cla_usu] [varchar](16) NULL,
	[Nom_udu] [varchar](max) NULL,
	[Ape_usu] [varchar](max) NULL,
	[Tip_usu] [varchar](10) NULL,
	[Ema_usu] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
