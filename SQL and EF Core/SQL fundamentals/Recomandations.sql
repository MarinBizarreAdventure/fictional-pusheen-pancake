USE OtakuTracker; 

CREATE TABLE Recommendations (
    recommendation_id INT PRIMARY KEY,
    user_id INT,
    anime_id INT,
    recommendation_text TEXT,
    recommendation_date DATETIME,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (anime_id) REFERENCES Anime(anime_id)
);


INSERT INTO Recommendations (recommendation_id, user_id, anime_id, recommendation_text, recommendation_date)
VALUES 
(1, 2, 3, 'I highly recommend this anime!', '2024-04-10 11:45:00'),
(2, 3, 1, 'Check out this awesome anime!', '2024-04-11 09:30:00');