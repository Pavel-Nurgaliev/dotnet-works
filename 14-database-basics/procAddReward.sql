

CREATE PROC addReward(@RewardTitle NVARCHAR(50), @RewardDescription NVARCHAR(250)) AS
	SELECT Title, RewardDescription FROM Rewards

	INSERT Rewards (Title,RewardDescription) VALUES (@RewardTitle,@RewardDescription)
