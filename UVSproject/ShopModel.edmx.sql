
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/06/2020 00:27:08
-- Generated from EDMX file: E:\c#_projects\UVSproject\UVSproject\UVSproject\ShopModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UVS_TestDatabase1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CardProduct_Card]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CardProduct] DROP CONSTRAINT [FK_CardProduct_Card];
GO
IF OBJECT_ID(N'[dbo].[FK_CardProduct_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CardProduct] DROP CONSTRAINT [FK_CardProduct_Product];
GO
IF OBJECT_ID(N'[dbo].[FK_Discount_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Discount] DROP CONSTRAINT [FK_Discount_Product];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Card]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Card];
GO
IF OBJECT_ID(N'[dbo].[CardProduct]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CardProduct];
GO
IF OBJECT_ID(N'[dbo].[Discount]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Discount];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Card'
CREATE TABLE [dbo].[Card] (
    [Id] int  NOT NULL,
    [CardId] nchar(50)  NULL
);
GO

-- Creating table 'CardProduct'
CREATE TABLE [dbo].[CardProduct] (
    [Id] int  NOT NULL,
    [ProductId] bigint  NOT NULL,
    [CardId] int  NOT NULL,
    [Amount] int  NOT NULL,
    [Cost] float  NOT NULL
);
GO

-- Creating table 'Discount'
CREATE TABLE [dbo].[Discount] (
    [Id] bigint  NOT NULL,
    [DiscountCode] nchar(8)  NOT NULL,
    [ProductId] bigint  NOT NULL,
    [IsUsed] bit  NOT NULL
);
GO

-- Creating table 'Product'
CREATE TABLE [dbo].[Product] (
    [Id] bigint  NOT NULL,
    [ProductName] nchar(100)  NULL,
    [Amount] int  NULL,
    [Cost] float  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Card'
ALTER TABLE [dbo].[Card]
ADD CONSTRAINT [PK_Card]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CardProduct'
ALTER TABLE [dbo].[CardProduct]
ADD CONSTRAINT [PK_CardProduct]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Discount'
ALTER TABLE [dbo].[Discount]
ADD CONSTRAINT [PK_Discount]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Product'
ALTER TABLE [dbo].[Product]
ADD CONSTRAINT [PK_Product]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CardId] in table 'CardProduct'
ALTER TABLE [dbo].[CardProduct]
ADD CONSTRAINT [FK_CardProduct_Card]
    FOREIGN KEY ([CardId])
    REFERENCES [dbo].[Card]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CardProduct_Card'
CREATE INDEX [IX_FK_CardProduct_Card]
ON [dbo].[CardProduct]
    ([CardId]);
GO

-- Creating foreign key on [ProductId] in table 'CardProduct'
ALTER TABLE [dbo].[CardProduct]
ADD CONSTRAINT [FK_CardProduct_Product]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CardProduct_Product'
CREATE INDEX [IX_FK_CardProduct_Product]
ON [dbo].[CardProduct]
    ([ProductId]);
GO

-- Creating foreign key on [ProductId] in table 'Discount'
ALTER TABLE [dbo].[Discount]
ADD CONSTRAINT [FK_Discount_Product]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Discount_Product'
CREATE INDEX [IX_FK_Discount_Product]
ON [dbo].[Discount]
    ([ProductId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------