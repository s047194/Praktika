CREATE TABLE [dbo].[tblstudent] (
    [Id]      INT          NOT NULL,
    [Vardas]  VARCHAR (50) NULL,
    [Pavardė] VARCHAR (50) NULL,
    [Grade]   INT          NULL,
    [Subject] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id]),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[tbllog] ([Id])
);

