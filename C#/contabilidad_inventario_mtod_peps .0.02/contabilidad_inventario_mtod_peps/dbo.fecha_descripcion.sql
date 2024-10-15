CREATE TABLE [dbo].[fecha_descripcion] (
    [No]                   INT NOT NULL IDENTITY,
    [fecha]                DATE            NULL,
    [descripcion]          VARCHAR (50)    NULL,
    [Entrada cantidad]     NUMERIC (18, 2) NULL,
    [Entrada C/u]          NUMERIC (18, 2) NULL,
    [Entrada total]        NUMERIC (18, 2) NULL,
    [Salida cantidad]      NUMERIC (18, 2) NULL,
    [Salida C/u]           NUMERIC (18, 2) NULL,
    [Salida total]         NUMERIC (18, 2) NULL,
    [Existencias cantidad] NUMERIC (18, 2) NULL,
    [Existencias C/u]      NUMERIC (18, 2) NULL,
    [Existencias total]    NUMERIC (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([No] ASC)
);

