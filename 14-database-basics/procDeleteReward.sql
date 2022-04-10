CREATE PROC deleteReward(@RewardId INT) AS
	SELECT ID FROM Rewards

	DELETE FROM Rewards Where ID=@RewardId