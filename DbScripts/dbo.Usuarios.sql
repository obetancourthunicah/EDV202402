CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [user] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(255) NOT NULL,
	[passwordFchExp] DATETIME NOT NULL,
    [name] VARCHAR(255) NOT NULL, 
    [status] CHAR(3) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Usuarios_User] ON [dbo].[Usuarios] ([user])
