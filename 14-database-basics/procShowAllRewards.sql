CREATE PROC showAllRewards(@UserId INT) AS

SELECT UserId, RewardId
FROM UsersAndRewards WHERE UserId = @UserId