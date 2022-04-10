CREATE PROC refreshReward(@RewardId INT,@RewardTitile NVARCHAR(50),
@RewardDescription NVARCHAR(250))AS
	SELECT * FROM Rewards
	
	UPDATE Rewards SET Title = @RewardTitile, RewardDescription = @RewardDescription
	WHERE ID=@RewardId