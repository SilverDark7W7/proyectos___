CREATE TABLE [dbo].[resultados] (
    [NO]            INT          NOT NULL IDENTITY,
    [Primera_cifra] VARCHAR (50) NOT NULL,
    [Operacion]     VARCHAR (50) NOT NULL,
    [Segunda_cifra] VARCHAR (50) NOT NULL,
    [Resultado]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([NO] ASC)
);

