CREATE TABLE [dbo].[Guardado_contrasenas] (
    [codigo]                INT          IDENTITY (1, 1) NOT NULL,
    [Nombre_contrasena] VARCHAR (50) NULL,
    [Contrasena]        VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([codigo] ASC)
);

