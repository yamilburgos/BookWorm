DROP TABLE [dbo].[Books]

CREATE TABLE [dbo].[Books] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (MAX) NOT NULL,
    [Author]      NVARCHAR (MAX) NOT NULL,
    [CoverArt]    NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [Rating]      INT            NOT NULL,
    [BookSeries]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Books] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
INSERT INTO [dbo].[Books] VALUES
	('Pride and Prejudice', 'Jane Austen', 'http', 'Generic Description Here', 3, 'NA'),
	('Pride and Prejudice 2', 'Jane Austen', 'http', 'Generic Description Here', 5, 'New Series');
GO