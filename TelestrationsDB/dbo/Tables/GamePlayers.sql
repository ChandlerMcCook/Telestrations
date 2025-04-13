CREATE TABLE [dbo].[GamePlayers]
(
	GameId INT NOT NULL,
	PlayerId INT NOT NULL,
	PRIMARY KEY (GameId, PlayerId),
	CONSTRAINT [FK_GamePlayers_Game] 
        FOREIGN KEY (GameId) 
        REFERENCES [dbo].[Game](Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

    CONSTRAINT [FK_GamePlayers_User] 
        FOREIGN KEY (PlayerId) 
        REFERENCES [dbo].[User](Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
)
