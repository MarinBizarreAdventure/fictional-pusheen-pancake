USE OtakuTracker;

CREATE TABLE Genres (
    genre_id INT PRIMARY KEY,
    genre_name VARCHAR(100) NOT NULL
);

INSERT INTO Genres (genre_id, genre_name)
VALUES 
(1, 'Action'),
(2, 'Adventure'),
(3, 'Comedy'),
(4, 'Drama');

