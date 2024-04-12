USE OtakuTracker;

CREATE TABLE Users(
	user_id INT PRIMARY KEY,
	username VARCHAR(255) NOT NULL,
	email VARCHAR(255) NOT NULL,
	password_hash VARCHAR(255) NOT NULL,
	join_date DATE NOT NULL,
	last_login DATETIME
)

INSERT INTO Users (user_id, username, email, password_hash, join_date, last_login)
VALUES
(1,'user1','user1@gmail.com', 'hashed_pass_1', '2024-01-01', NULL),
(2,'user2','user2@gmail.com', 'hashed_pass_2', '2024-01-02', NULL),
(3,'user3','user3@gmail.com', 'hashed_pass_3', '2024-01-03', NULL);