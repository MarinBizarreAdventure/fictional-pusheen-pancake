USE OtakuTracker;

CREATE TABLE User_Anime_List (
    user_id INT,
    anime_id INT,
    status VARCHAR(50),
    score DECIMAL(2, 1),
    last_updated DATETIME,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (anime_id) REFERENCES Anime(anime_id)
);

INSERT INTO User_Anime_List(user_id, anime_id, status, score, last_updated)
VALUES 
(1, 1, 'watching', 4.0, '2024-04-10 08:30:00'),
(1, 2, 'completed', 4.5, '2024-04-09 10:15:00'),
(2, 1, 'completed', 3.5, '2024-04-11 14:20:00');