USE [InventoryForHome]
GO

/****** Object:  Table [dbo].[Item]    Script Date: 12/03/2024 10:40:02 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Item](
	[IdItem] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](max) NOT NULL,
	[Stock] [int] NOT NULL,
	[IdTypePrioritary] [int] NOT NULL,
	[IdTypeStock] [int] NOT NULL,
	[PurchesDate] [datetime] NOT NULL,
	[ExpirationDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[IdItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

