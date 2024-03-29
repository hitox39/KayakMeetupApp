IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [User] (
    [Id] uniqueidentifier NOT NULL,
    [GivenName] nvarchar(50) NOT NULL,
    [FamilyName] nvarchar(50) NOT NULL,
    [Email] nvarchar(128) NOT NULL,
    [DateOfBirth] datetime2 NOT NULL,
    [Address] nvarchar(95) NOT NULL,
    [State] nvarchar(15) NOT NULL,
    [ZipCode] nvarchar(12) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220123190159_AddUserTable', N'6.0.1');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [User] ADD [BoatId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';
GO

ALTER TABLE [User] ADD [CityName] nvarchar(max) NULL;
GO

CREATE TABLE [Boat] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Make] nvarchar(max) NOT NULL,
    [Model] nvarchar(max) NOT NULL,
    [YearMade] int NOT NULL,
    CONSTRAINT [PK_Boat] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [CasualMeetUpEvent] (
    [Id] uniqueidentifier NOT NULL,
    [Address] nvarchar(50) NOT NULL,
    [CityName] nvarchar(max) NOT NULL,
    [State] int NOT NULL,
    [ZipCode] int NOT NULL,
    [Country] nvarchar(50) NOT NULL,
    [EventName] nvarchar(100),
    CONSTRAINT [PK_CasualMeetUpEvent] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [FishingTournamentEvent] (
    [Id] uniqueidentifier NOT NULL,
    [CityName] nvarchar(95) NOT NULL,
    [Address] nvarchar(max) NOT NULL,
    [State] int NOT NULL,
    [ZipCode] int NOT NULL,
    [Country] nvarchar(50) NOT NULL,
    [EventName] nvarchar(100),
    CONSTRAINT [PK_FishingTournamentEvent] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [RaceEvent] (
    [Id] uniqueidentifier NOT NULL,
    [CityName] nvarchar(95) NOT NULL,
    [Address] nvarchar(max) NOT NULL,
    [State] int NOT NULL,
    [ZipCode] int NOT NULL,
    [Country] nvarchar(50) NOT NULL,
    [EventName] nvarchar(100),
    CONSTRAINT [PK_RaceEvent] PRIMARY KEY ([Id])
);
GO

CREATE INDEX [IX_User_BoatId] ON [User] ([BoatId]);
GO

ALTER TABLE [User] ADD CONSTRAINT [FK_User_Boat_BoatId] FOREIGN KEY ([BoatId]) REFERENCES [Boat] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230210021052_InitialCreate', N'6.0.1');
GO

COMMIT;
GO


