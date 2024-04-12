USE OtakuTracker;

CREATE TABLE Anime_Genres (
    anime_id INT,
    genre_id INT,
    FOREIGN KEY (anime_id) REFERENCES Anime(anime_id),
    FOREIGN KEY (genre_id) REFERENCES Genres(genre_id)
);

INSERT INTO Anime_Genres (anime_id, genre_id)
VALUES 
(1, 1),
(1, 3),
(2, 2),
(3, 4);