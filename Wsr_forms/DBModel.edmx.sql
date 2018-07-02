
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/02/2018 12:17:03
-- Generated from EDMX file: C:\Users\Misha\Source\Repos\Wsr_forms\Wsr_forms\DBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [wsr_forms];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PhotoUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_PhotoUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ZodiakUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_ZodiakUser];
GO
IF OBJECT_ID(N'[dbo].[FK_TemperamentUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_TemperamentUser];
GO
IF OBJECT_ID(N'[dbo].[FK_SportsSportsUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SportsUsers] DROP CONSTRAINT [FK_SportsSportsUser];
GO
IF OBJECT_ID(N'[dbo].[FK_UserSportsUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SportsUsers] DROP CONSTRAINT [FK_UserSportsUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Temperaments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Temperaments];
GO
IF OBJECT_ID(N'[dbo].[Zodiaks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zodiaks];
GO
IF OBJECT_ID(N'[dbo].[Sports]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sports];
GO
IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[SportsUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SportsUsers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Temperaments'
CREATE TABLE [dbo].[Temperaments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Img] varbinary(max)  NOT NULL
);
GO

-- Creating table 'Zodiaks'
CREATE TABLE [dbo].[Zodiaks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Img] varbinary(max)  NOT NULL
);
GO

-- Creating table 'Sports'
CREATE TABLE [dbo].[Sports] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Img] varbinary(max)  NOT NULL
);
GO

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Img] varbinary(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(100)  NOT NULL,
    [LastName] nvarchar(100)  NOT NULL,
    [MiddleName] nvarchar(100)  NOT NULL,
    [PhotoId] int  NOT NULL,
    [ZodiakId] int  NOT NULL,
    [TemperamentId] int  NOT NULL,
    [CharacterId] int  NOT NULL
);
GO

-- Creating table 'SportsUsers'
CREATE TABLE [dbo].[SportsUsers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SportsId] int  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Characters'
CREATE TABLE [dbo].[Characters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Img] varbinary(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Temperaments'
ALTER TABLE [dbo].[Temperaments]
ADD CONSTRAINT [PK_Temperaments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Zodiaks'
ALTER TABLE [dbo].[Zodiaks]
ADD CONSTRAINT [PK_Zodiaks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sports'
ALTER TABLE [dbo].[Sports]
ADD CONSTRAINT [PK_Sports]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SportsUsers'
ALTER TABLE [dbo].[SportsUsers]
ADD CONSTRAINT [PK_SportsUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Characters'
ALTER TABLE [dbo].[Characters]
ADD CONSTRAINT [PK_Characters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PhotoId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_PhotoUser]
    FOREIGN KEY ([PhotoId])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoUser'
CREATE INDEX [IX_FK_PhotoUser]
ON [dbo].[Users]
    ([PhotoId]);
GO

-- Creating foreign key on [ZodiakId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_ZodiakUser]
    FOREIGN KEY ([ZodiakId])
    REFERENCES [dbo].[Zodiaks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZodiakUser'
CREATE INDEX [IX_FK_ZodiakUser]
ON [dbo].[Users]
    ([ZodiakId]);
GO

-- Creating foreign key on [TemperamentId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_TemperamentUser]
    FOREIGN KEY ([TemperamentId])
    REFERENCES [dbo].[Temperaments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TemperamentUser'
CREATE INDEX [IX_FK_TemperamentUser]
ON [dbo].[Users]
    ([TemperamentId]);
GO

-- Creating foreign key on [SportsId] in table 'SportsUsers'
ALTER TABLE [dbo].[SportsUsers]
ADD CONSTRAINT [FK_SportsSportsUser]
    FOREIGN KEY ([SportsId])
    REFERENCES [dbo].[Sports]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SportsSportsUser'
CREATE INDEX [IX_FK_SportsSportsUser]
ON [dbo].[SportsUsers]
    ([SportsId]);
GO

-- Creating foreign key on [UserId] in table 'SportsUsers'
ALTER TABLE [dbo].[SportsUsers]
ADD CONSTRAINT [FK_UserSportsUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserSportsUser'
CREATE INDEX [IX_FK_UserSportsUser]
ON [dbo].[SportsUsers]
    ([UserId]);
GO

-- Creating foreign key on [CharacterId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_CharacterUser]
    FOREIGN KEY ([CharacterId])
    REFERENCES [dbo].[Characters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CharacterUser'
CREATE INDEX [IX_FK_CharacterUser]
ON [dbo].[Users]
    ([CharacterId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------