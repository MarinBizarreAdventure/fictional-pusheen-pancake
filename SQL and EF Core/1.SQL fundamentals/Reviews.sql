USE OtakuTracker;

CREATE TABLE Reviews (
    review_id INT PRIMARY KEY,
    user_id INT,
    anime_id INT,
    rating DECIMAL(2, 1),
    review_text TEXT,
    review_date DATETIME,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (anime_id) REFERENCES Anime(anime_id)
);

