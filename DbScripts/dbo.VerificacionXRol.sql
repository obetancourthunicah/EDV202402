CREATE TABLE [dbo].[VerificacionesXRol]
(
	[rol] VARCHAR(50) NOT NULL , 
    [verificacion] VARCHAR(250) NOT NULL, 
    [fechaExp] DATETIME NOT NULL, 
    [status] CHAR(3) NOT NULL, 
    PRIMARY KEY ([rol], [verificacion]), 
    CONSTRAINT [FK_VerificacionesXRol_Roles] FOREIGN KEY ([rol]) REFERENCES [Roles](rol), 
    CONSTRAINT [FK_VerificacionesXRol_Verificaciones] FOREIGN KEY ([verificacion]) REFERENCES [Verificaciones]([verificacion])
)
