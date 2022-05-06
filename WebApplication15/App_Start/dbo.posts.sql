CREATE TABLE [dbo].[posts] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [writtenPost] NVARCHAR (MAX) NULL,
    [imgPath]     NVARCHAR (MAX) NULL,
    [comment]     NVARCHAR (MAX) NULL,
    [likes]       INT            NULL,
    CONSTRAINT [PK_dbo.posts] PRIMARY KEY CLUSTERED ([id] ASC)
);

