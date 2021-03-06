USE [Control_Financiero]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 9/12/2020 8:57:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom_cli] [varchar](50) NULL,
	[Ape_cli] [varchar](max) NULL,
	[Sex_cli] [varchar](50) NULL,
	[Ced_cli] [varchar](50) NULL,
	[Dir_cli] [varchar](max) NULL,
	[Tel_cli] [varchar](50) NULL,
	[Fec_cli] [varchar](50) NULL,
	[Ema_cli] [varchar](50) NULL,
	[Num_cue] [int] NULL,
	[Tip_cue] [varchar](50) NULL,
	[Val_cue] [varchar](10) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deposito]    Script Date: 9/12/2020 8:57:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deposito](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Num_cue] [varchar](max) NULL,
	[Nom_ben] [varchar](max) NULL,
	[Ced_cli] [varchar](max) NULL,
	[Tip_cue] [varchar](max) NULL,
	[Mon_dep] [varchar](max) NULL,
	[Mone] [varchar](max) NULL,
	[Val_dep] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 9/12/2020 8:57:48 p. m. ******/
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
/****** Object:  Table [dbo].[Retiro]    Script Date: 9/12/2020 8:57:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Retiro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Num_cue] [varchar](max) NULL,
	[Nom_ben] [varchar](max) NULL,
	[Ced_cli] [varchar](max) NULL,
	[Tip_cue] [varchar](max) NULL,
	[Mon_ret] [varchar](max) NULL,
	[Mone] [varchar](max) NULL,
	[Val_dep] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 9/12/2020 8:57:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Ide_usu] [int] IDENTITY(1,1) NOT NULL,
	[Cla_usu] [varchar](16) NULL,
	[Nom_udu] [varchar](max) NULL,
	[Ape_usu] [varchar](max) NULL,
	[Tip_usu] [varchar](20) NULL,
	[Ema_usu] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
