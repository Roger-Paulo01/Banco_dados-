BEGIN TRANSACTION;
DECLARE @var sysname;
SELECT @var = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_USUARIOS]') AND [c].[name] = N'Perfil');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [TB_USUARIOS] DROP CONSTRAINT [' + @var + '];');
ALTER TABLE [TB_USUARIOS] ADD DEFAULT 'Jogador' FOR [Perfil];

ALTER TABLE [TB_PERSONAGENS] ADD [Derrota] int NOT NULL DEFAULT 0;

ALTER TABLE [TB_PERSONAGENS] ADD [Disputas] int NOT NULL DEFAULT 0;

ALTER TABLE [TB_PERSONAGENS] ADD [Vitorias] int NOT NULL DEFAULT 0;

ALTER TABLE [TB_ARMA] ADD [PersonagemId] int NOT NULL DEFAULT 0;

UPDATE [TB_ARMA] SET [PersonagemId] = 1
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMA] SET [PersonagemId] = 2
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMA] SET [PersonagemId] = 3
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMA] SET [PersonagemId] = 4
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMA] SET [PersonagemId] = 5
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMA] SET [PersonagemId] = 6
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMA] SET [PersonagemId] = 7
WHERE [Id] = 7;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMA] SET [PersonagemId] = 8
WHERE [Id] = 8;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [Derrota] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [Derrota] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [Derrota] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [Derrota] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [Derrota] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [Derrota] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [Derrota] = 0, [Disputas] = 0, [Vitorias] = 0
WHERE [Id] = 7;
SELECT @@ROWCOUNT;


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Defesa', N'Derrota', N'Disputas', N'Forca', N'FotoPersonagem', N'Inteligencia', N'Nome', N'PontosVida', N'UsuarioId', N'Vitorias') AND [object_id] = OBJECT_ID(N'[TB_PERSONAGENS]'))
    SET IDENTITY_INSERT [TB_PERSONAGENS] ON;
INSERT INTO [TB_PERSONAGENS] ([Id], [Classe], [Defesa], [Derrota], [Disputas], [Forca], [FotoPersonagem], [Inteligencia], [Nome], [PontosVida], [UsuarioId], [Vitorias])
VALUES (8, 2, 12, 0, 0, 30, NULL, 30, 'Mario', 80, 1, 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Defesa', N'Derrota', N'Disputas', N'Forca', N'FotoPersonagem', N'Inteligencia', N'Nome', N'PontosVida', N'UsuarioId', N'Vitorias') AND [object_id] = OBJECT_ID(N'[TB_PERSONAGENS]'))
    SET IDENTITY_INSERT [TB_PERSONAGENS] OFF;

UPDATE [TB_USUARIOS] SET [PasswordHash] = 0x6CE8B3649BD1C6FAED11A349D3C87292941B954ECB900D68B7E2BA416A04F5DEEF0DE3BA5D43AB11FCBC2BA326189923F786DF46F9FD63E95738151C74A881DF, [PasswordSalt] = 0x92F11B6056E953E6CAC77F43A029BE25491FBECA328CE20BF786E997F0C61EE5C00E06CE2B8D9C9547C047F52461DFE1046C0F729FFD85A1178A86B3CD07324EA5D8EC620850BEC209E208A6D95F2F5BBEF147453ABFD9428C0E9AEB9E0E836E18901ADA7B68B356523329BD46AA1FDE1F06A4C237F4BAB7553838C1CEFF2B1E
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


CREATE UNIQUE INDEX [IX_TB_ARMA_PersonagemId] ON [TB_ARMA] ([PersonagemId]);

ALTER TABLE [TB_ARMA] ADD CONSTRAINT [FK_TB_ARMA_TB_PERSONAGENS_PersonagemId] FOREIGN KEY ([PersonagemId]) REFERENCES [TB_PERSONAGENS] ([Id]) ON DELETE CASCADE;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251010174758_MigracaoUmParaUm', N'9.0.9');

COMMIT;
GO

