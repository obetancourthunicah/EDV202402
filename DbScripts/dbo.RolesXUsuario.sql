CREATE TABLE [dbo].[RolesXUsuario]
(
	[userId] INT NOT NULL , 
    [rol] VARCHAR(50) NOT NULL, 
    [fechaExp] DATETIME NOT NULL, 
    [status] CHAR(3) NOT NULL, 
    PRIMARY KEY ([userId], [rol]), 
    CONSTRAINT [FK_RolesXUsuario_ToUsuarios] FOREIGN KEY ([userId]) REFERENCES [Usuarios]([Id]), 
    CONSTRAINT [FK_RolesXUsuario_ToRoles] FOREIGN KEY ([rol]) REFERENCES [Roles]([rol])
)
