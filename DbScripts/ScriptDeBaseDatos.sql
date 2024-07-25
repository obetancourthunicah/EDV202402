CREATE TABLE [dbo].[Clinicas] (
    [Id]        INT           NOT NULL,
    [Nombre]    VARCHAR (128) NOT NULL,
    [Direccion] VARCHAR (255) NULL,
    [Telefono]  VARCHAR (30)  NULL,
    [Estado]    CHAR (3)      DEFAULT ('ACT') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
CREATE TABLE [dbo].[Personas] (
    [Identidad]   INT           NOT NULL,
    [Nombre]      VARCHAR (255) NULL,
    [Telefono]    VARCHAR (30)  NULL,
    [Correo]      VARCHAR (128) NULL,
    [FchCreacion] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Identidad] ASC)
);
GO
CREATE TABLE [dbo].[Medicos] (
    [Identidad]    INT           NOT NULL,
    [Especialidad] VARCHAR (255) NULL,
    [Estado]       CHAR (3)      DEFAULT ('ACT') NULL,
    PRIMARY KEY CLUSTERED ([Identidad] ASC),
    CONSTRAINT [FK_Medicos_Personas] FOREIGN KEY ([Identidad]) REFERENCES [dbo].[Personas] ([Identidad])
);
GO
CREATE TABLE [dbo].[Productos] (
    [Id]       INT             NOT NULL,
    [Nombre]   VARCHAR (150)   NOT NULL,
    [Precio]   DECIMAL (13, 2) NOT NULL,
    [Cantidad] INT             NOT NULL,
    [Estado]   CHAR (3)        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
CREATE TABLE [dbo].[Roles] (
    [rol]    VARCHAR (50)  NOT NULL,
    [name]   VARCHAR (250) NOT NULL,
    [status] CHAR (3)      NOT NULL,
    PRIMARY KEY CLUSTERED ([rol] ASC)
);
GO
CREATE TABLE [dbo].[Usuarios] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [user]           VARCHAR (50)  NOT NULL,
    [password]       VARCHAR (256) NOT NULL,
    [passwordFchExp] DATETIME      NOT NULL,
    [name]           VARCHAR (255) NOT NULL,
    [status]         CHAR (3)      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
CREATE TABLE [dbo].[RolesXUsuario] (
    [userId]   INT          NOT NULL,
    [rol]      VARCHAR (50) NOT NULL,
    [fechaExp] DATETIME     NOT NULL,
    [status]   CHAR (3)     NOT NULL,
    PRIMARY KEY CLUSTERED ([userId] ASC, [rol] ASC),
    CONSTRAINT [FK_RolesXUsuario_ToUsuarios] FOREIGN KEY ([userId]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_RolesXUsuario_ToRoles] FOREIGN KEY ([rol]) REFERENCES [dbo].[Roles] ([rol])
);
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Usuarios_User]
    ON [dbo].[Usuarios]([user] ASC);
GO
CREATE TABLE [dbo].[Verificaciones] (
    [verificacion] VARCHAR (250) NOT NULL,
    [name]         VARCHAR (250) NOT NULL,
    [status]       CHAR (3)      NOT NULL,
    PRIMARY KEY CLUSTERED ([verificacion] ASC)
);
CREATE TABLE [dbo].[VerificacionesXRol] (
    [rol]          VARCHAR (50)  NOT NULL,
    [verificacion] VARCHAR (250) NOT NULL,
    [fechaExp]     DATETIME      NOT NULL,
    [status]       CHAR (3)      NOT NULL,
    PRIMARY KEY CLUSTERED ([rol] ASC, [verificacion] ASC),
    CONSTRAINT [FK_VerificacionesXRol_Roles] FOREIGN KEY ([rol]) REFERENCES [dbo].[Roles] ([rol]),
    CONSTRAINT [FK_VerificacionesXRol_Verificaciones] FOREIGN KEY ([verificacion]) REFERENCES [dbo].[Verificaciones] ([verificacion])
);
