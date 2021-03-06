USE [Empresa]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[cliente]') AND type in (N'U'))
ALTER TABLE [dbo].[cliente] DROP CONSTRAINT IF EXISTS [DF_cliente_Activo]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 19/04/2021 3:34:36 ******/
DROP TABLE IF EXISTS [dbo].[cliente]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 19/04/2021 3:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](250) NOT NULL,
	[Apellidos] [varchar](250) NOT NULL,
	[Correo] [varchar](320) NOT NULL,
	[FechaNacimiento] [datetime] NULL,
	[Direccion] [varchar](800) NULL,
	[Activo] [bit] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cliente] ADD  CONSTRAINT [DF_cliente_Activo]  DEFAULT ((1)) FOR [Activo]
GO
