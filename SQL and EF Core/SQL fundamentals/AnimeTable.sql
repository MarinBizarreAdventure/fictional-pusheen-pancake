USE OtakuTracker;

CREATE TABLE Anime(
	anime_id INT PRIMARY KEY,
	title VARCHAR(255) NOT NULL,
	synopsis TEXT,
	start_date DATE,
	end_date DATE,
	status VARCHAR(50),
	type VARCHAR(50),
	episodes INT,
	duration INT,
	age_rating VARCHAR(255),
	poster_image_url VARCHAR(255),
	trailer_url VARCHAR(255),
	average_rating DECIMAL(3, 1),
    total_ratings INT,
    rating_0_10 INT DEFAULT 0, 
    rating_1 INT DEFAULT 0,     
    rating_2 INT DEFAULT 0,     
    rating_3 INT DEFAULT 0,    
    rating_4 INT DEFAULT 0,     
    rating_5 INT DEFAULT 0,     
    rating_6 INT DEFAULT 0,     
    rating_7 INT DEFAULT 0,   
    rating_8 INT DEFAULT 0,     
    rating_9 INT DEFAULT 0,     
    rating_10 INT DEFAULT 0   

)

INSERT INTO Anime (anime_id, title, synopsis, start_date, end_date, status, type, episodes, duration, age_rating, poster_image_url, trailer_url, average_rating, total_ratings)
VALUES 
(1, 'Anime 1', 'Synopsis for Anime 1', '2024-01-01', NULL, 'ongoing', 'TV', 12, 24, 'PG-13', 'poster1.jpg', 'trailer1.mp4', 4.5, 100),
(2, 'Anime 2', 'Synopsis for Anime 2', '2024-02-01', '2024-03-15', 'completed', 'Movie', 1, 120, 'PG', 'poster2.jpg', 'trailer2.mp4', 4.0, 50),
(3, 'Anime 3', 'Synopsis for Anime 3', '2024-03-01', NULL, 'ongoing', 'OVA', 6, 30, 'R', 'poster3.jpg', 'trailer3.mp4', 4.2, 80);
