DROP TABLE [dbo].[Books]

CREATE TABLE [dbo].[Books] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (100) NOT NULL,
    [Author]      NVARCHAR (100) NOT NULL,
    [CoverArt]    NVARCHAR (255) NOT NULL,
    [Description] NVARCHAR (255) NOT NULL,
    [Rating]      INT            NOT NULL,
    [BookSeries]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_dbo.Books] PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
INSERT INTO [dbo].[Books] VALUES
	('The Fellowship of the Ring', 'J.R.R. Tolkien', 
		'https://images.gr-assets.com/books/1298411339l/34.jpg', 
		'Generic Description Here!', 
		4, 'The Lord of the Rings'
	),
	('The Two Towers', 'J.R.R. Tolkien', 
		'https://images.gr-assets.com/books/1298415523l/15241.jpg', 
		'Generic Description Here!', 
		4, 'The Lord of the Rings'
	),
	('The Return of the King', 'J.R.R. Tolkien', 
		'https://images.gr-assets.com/books/1389977161l/18512.jpg', 
		'Generic Description Here!', 
		5, 'The Lord of the Rings'
	),
	('The Hunger Games', 'Suzanne Collins', 
		'https://images.gr-assets.com/books/1447303603l/2767052.jpg', 
		'Generic Description Here!', 
		5, 'The Hunger Games'
	),
	('Catching Fire', 'Suzanne Collins', 
		'https://images.gr-assets.com/books/1358273780l/6148028.jpg', 
		'Generic Description Here!', 
		4, 'The Hunger Games'
	),
	('Mockingjay', 'Suzanne Collins', 
		'https://images.gr-assets.com/books/1358275419l/7260188.jpg', 
		'Generic Description Here!', 
		4, 'The Hunger Games'
	),
	('Harry Potter and the Sorcerer''s Stone', 'J.K Rowling', 
		'https://images.gr-assets.com/books/1474154022l/3.jpg', 
		'Generic Description Here!', 
		5, 'Harry Potter'
	),
	('Harry Potter and the Chamber of Secrets', 'J.K Rowling', 
		'https://images.gr-assets.com/books/1474169725l/15881.jpg', 
		'Generic Description Here!', 
		4, 'Harry Potter'
	),
	('Harry Potter and the Prisoner of Azkaban', 'J.K Rowling', 
		'https://images.gr-assets.com/books/1499277281l/5.jpg', 
		'Generic Description Here!', 
		5, 'Harry Potter'
	),
	('Harry Potter and the Goblet of Fire', 'J.K Rowling', 
		'https://images.gr-assets.com/books/1361482611l/6.jpg', 
		'Generic Description Here!', 
		5, 'Harry Potter'
	),
	('Harry Potter and the Order of the Phoenix', 'J.K Rowling', 
		'https://images.gr-assets.com/books/1507396732l/2.jpg', 
		'Generic Description Here!', 
		4, 'Harry Potter'
	),
	('Harry Potter and the Half-Blood Prince', 'J.K Rowling', 
		'https://images.gr-assets.com/books/1361039191l/1.jpg', 
		'Generic Description Here!', 
		5, 'Harry Potter'
	),
	('Harry Potter and the Deathly Hallows', 'J.K Rowling', 
		'https://images.gr-assets.com/books/1474171184l/136251.jpg', 
		'Generic Description Here!', 
		5, 'Harry Potter'
	),
	('To Kill a Mockingbird', 'Harper Lee', 
		'https://images.gr-assets.com/books/1361975680l/2657.jpg', 
		'Generic Description Here!', 
		4, ''
	),
	('Pride and Prejudice', 'Jane Austen', 
		'https://images.gr-assets.com/books/1320399351l/1885.jpg', 
		'Generic Description Here!', 
		4, ''
	),
	('The Book Thief', 'Markus Zusak', 
		'https://images.gr-assets.com/books/1390053681l/19063.jpg', 
		'Generic Description Here!', 
		4, ''
	),
	('Animal Farm', 'George Orwell', 
		'https://images.gr-assets.com/books/1424037542l/7613.jpg', 
		'Generic Description Here!', 
		3, ''
	),
	('Gone with the Wind', 'Margaret Mitchell', 
		'https://images.gr-assets.com/books/1328025229l/18405.jpg', 
		'Generic Description Here!', 
		4, ''
	),
	('The Chronicles of Narnia', 'C.S. Lewis', 
		'https://images.gr-assets.com/books/1449868701l/11127.jpg', 
		'Generic Description Here!', 
		4, 'The Chronicles of Narnia'
	),
	('Prince Caspian', 'C.S. Lewis', 
		'https://images.gr-assets.com/books/1308814880l/121749.jpg', 
		'Generic Description Here!', 
		3, 'The Chronicles of Narnia'
	),
	('The Voyage of the Dawn Treader', 'C.S. Lewis', 
		'https://images.gr-assets.com/books/1343185059l/140225.jpg', 
		'Generic Description Here!', 
		4, 'The Chronicles of Narnia'
	),
	('The Silver Chair', 'C.S. Lewis', 
		'https://images.gr-assets.com/books/1336139237l/65641.jpg', 
		'Generic Description Here!', 
		3, 'The Chronicles of Narnia'
	),
	('The Horse and His Boy', 'C.S. Lewis', 
		'https://images.gr-assets.com/books/1388210968l/84119.jpg', 
		'Generic Description Here!', 
		3, 'The Chronicles of Narnia'
	),
	('The Magician''s Nephew', 'C.S. Lewis', 
		'https://images.gr-assets.com/books/1308814770l/65605.jpg', 
		'Generic Description Here!', 
		4, 'The Chronicles of Narnia'
	),
	('The Last Battle', 'C.S. Lewis', 
		'https://images.gr-assets.com/books/1308814830l/84369.jpg', 
		'Generic Description Here!', 
		4, 'The Chronicles of Narnia'
	)
GO