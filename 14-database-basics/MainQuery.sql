SELECT *
FROM Users

SELECT *
FROM Rewards

DROP TABLE UsersAndRewards
CREATE TABLE UsersAndRewards(
UserId INT,
RewardId INT,
PRIMARY KEY(UserId,RewardId),
FOREIGN KEY (UserId) REFERENCES Users(ID),
FOREIGN KEY (RewardId) REFERENCES Rewards(ID))

--SELECT * FROM UsersAndRewards
--EXEC addUser 'Pavel','Nurgaliev','19980505'
--EXEC addUser 'Artyom','Zinukov','19981111'

--EXEC deleteUser 1

--EXEC refreshUser 2,'Ivan','Ivanov','20200101'



--EXEC addReward 'Nobel','This reward1'
--EXEC addReward 'Darwin', 'This reward2'

--EXEC deleteReward 1

--EXEC refreshReward 2,'Nobel','This reward was changed'

--EXEC showAllRewards 1

--TRUNCATE TABLE Users
--TRUNCATE TABLE Rewards
--TRUNCATE TABLE UsersRewards
