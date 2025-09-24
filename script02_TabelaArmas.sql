BEGIN TRANSACTION;
CREATE TABLE [TB_ARMA] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Dano] int NOT NULL,
    CONSTRAINT [PK_TB_ARMA] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMA]'))
    SET IDENTITY_INSERT [TB_ARMA] ON;
INSERT INTO [TB_ARMA] ([Id], [Dano], [Nome])
VALUES (1, 7, 'Anel de Sauron'),
(2, 2, 'Chicotinho'),
(3, 4, 'Cajado do Inferno'),
(4, 3, 'Poção de Veneno de serpente'),
(5, 6, 'Machado de Thor'),
(6, 1, 'Escudo de Escama de Dragão'),
(7, 4, 'Espada Forphal'),
(8, 7, 'Excalibur');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMA]'))
    SET IDENTITY_INSERT [TB_ARMA] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250924194738_MigracaoArma', N'9.0.9');

COMMIT;
GO

