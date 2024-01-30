CREATE TABLE [dbo].[tbllog] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (50) NULL,
    [Password] VARCHAR (50) NULL,
    [Role]     VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

