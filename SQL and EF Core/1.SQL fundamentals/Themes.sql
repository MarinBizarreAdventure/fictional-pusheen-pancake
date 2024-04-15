USE OtakuTracker;

CREATE TABLE Themes (
    theme_id INT PRIMARY KEY,
    theme_name VARCHAR(100) NOT NULL
);

INSERT INTO Themes (theme_id, theme_name)
VALUES 
(1, 'Magic'),
(2, 'Sci-Fi'),
(3, 'Fantasy'),
(4, 'Slice of Life');

ALTER TABLE Anime
ADD theme_id INT

