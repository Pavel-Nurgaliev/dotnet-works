CREATE PROC addUser (@UserFirstName NVARCHAR(50), @UserLastName NVARCHAR(50),
@UserBithdaydate DATE) AS
	SELECT FirstName, LastName, Bithdaydate FROM Users

	INSERT Users (FirstName,LastName,Bithdaydate) VALUES 
	(@UserFirstName, @UserLastName,@UserBithdaydate)
