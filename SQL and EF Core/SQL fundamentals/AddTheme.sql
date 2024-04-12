ALTER TABLE Anime
ADD FOREIGN KEY (theme_id) REFERENCES Themes(theme_id);

-- Update sample Anime entries with theme_id
UPDATE Anime SET theme_id = 1 WHERE anime_id = 1;
UPDATE Anime SET theme_id = 2 WHERE anime_id = 2;
UPDATE Anime SET theme_id = 3 WHERE anime_id = 3;