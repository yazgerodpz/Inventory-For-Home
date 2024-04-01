USE [InventoryForHome]
GO

/****** Object:  Table [dbo].[CatTypePrioritary]    Script Date: 18/03/2024 12:17:46 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatTypePrioritary](
	[IdTypePrioritary] [int] IDENTITY(1,1) NOT NULL,
	[TypePrioritaryName] [nvarchar](max) NOT NULL,
	[_Description] [nvarchar](max) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_CatTypePrioritary] PRIMARY KEY CLUSTERED 
(
	[IdTypePrioritary] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

