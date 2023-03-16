USE [MwearDb]
GO

/****** Object: Table [dbo].[Products] Script Date: 10.12.2022 12:59:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Price]       NVARCHAR (MAX) NULL,
    [Stock]       INT            NOT NULL,
    [IsHome]      BIT            NOT NULL,
    [IsApproved]  BIT            NOT NULL,
    [CategoryId]  INT            NOT NULL,
	[Image]       NVARCHAR (MAX) NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_CategoryId]
    ON [dbo].[Products]([CategoryId] ASC);


GO
ALTER TABLE [dbo].[Products]
    ADD CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[Products]
    ADD CONSTRAINT [FK_dbo.Products_dbo.Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id]) ON DELETE CASCADE;


