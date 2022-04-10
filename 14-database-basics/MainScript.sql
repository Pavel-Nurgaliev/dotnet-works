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

-----------------------------------------------------------------------------------
--ADD New User script

--INSERT Users(FirstName,LastName,Bithdaydate) VALUES ('This Name', 'This PastName',
--'20211129')
------------------------------------------------------------------------------------

------------------------------------------------------------------------------------
--Delete essential user script

--DELETE FROM Users WHERE ID = Id
--DELETE FROM UsersAndRewards WHERE UserId = Id
------------------------------------------------------------------------------------

------------------------------------------------------------------------------------
--Refresh essential user script

--UPDATE Users SET FirstName = 'Change Firstname', 
--Lastname = 'Change LastName', 'Bithdatdate = 'ChangeBithdaydate' WHERE ID = Id
----------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------
--Add new reward script

--INSERT Rewards (Title, RewardDescription) VALUES ('Nobel','RewardX')
----------------------------------------------------------------------------------------


----------------------------------------------------------------------------------------
--delete essential reward

--DELETE FROM Rewards WHERE ID = id
--DELETE FROM UsersAndRewards WHERE ID = id
----------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------
--refresh essential reward

--UPDATE Rewards SET Title='This Title', RewardDescription = 'This description'
---------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
--Give user reward

--SELECT * FROM UsersAndRewards
--INSERT UsersAndRewards(UserId,RewardId) VALUES (1,1) 
---------------------------------------------------------------------------------------
--ShowAllRewardsUser

--SELECT* FROM UsersAndRewards WHERE UserId = 1
----------------------------------------------------------------------------------------
--TRUNCATE TABLE Users
--TRUNCATE TABLE Rewards
--TRUNCATE TABLE UsersAndRewards