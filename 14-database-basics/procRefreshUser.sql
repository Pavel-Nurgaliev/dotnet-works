

CREATE PROC refreshUser(@UserId INT,@UserFirstName NVARCHAR(50),
@UserLastName NVARCHAR(50),@UserBithdaydate DATE) AS
	SELECT * FROM Users

	UPDATE Users SET FirstName=@UserFirstName, LastName=@UserLastName,
	Bithdaydate = @UserBithdaydate WHERE ID=@UserId

