using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace UsersAndRewardsSQL
{
    public class DataBaseDAO
    {
        private readonly string _connectionStringBuilder;
        public DataBaseDAO(string connectigStringBuilder)
        {
            _connectionStringBuilder = connectigStringBuilder;
        }

        public IList<User> GetAllUsers()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = "Select * from dbo.Users";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var user = new User();
                    user.ID = reader.GetInt32(0);
                    user.FirstName = reader.GetString(1);
                    user.LastName = reader.GetString(2);
                    user.Bithdaydate = reader.GetDateTime(3);

                    users.Add(user);
                }
            }
            return users;
        }
        public IList<Reward> GetAllRewards()
        {
            var rewards = new List<Reward>();
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = "Select * from dbo.Rewards";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var reward = new Reward();
                    reward.ID = reader.GetInt32(0);
                    reward.Title = reader.GetString(1);
                    reward.Description = reader.GetString(2);

                    rewards.Add(reward);
                }

            }
            return rewards;

        }

        public void AddNewUser()
        {
            var user = new User { FirstName = "-", LastName = "-", Bithdaydate = DateTime.Now };
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"Insert dbo.Users(FirstName,LastName,Bithdaydate) " +
                    $"Values ('{user.FirstName}','{user.LastName}','{user.Bithdaydate}')";

                connection.Open();

                command.ExecuteNonQuery();
            }

        }

        public IList<UsersRewards> GetAllUsersRewards()
        {
            var usersRewards = new List<UsersRewards>();
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"Select * from dbo.UsersAndRewards";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var userReward = new UsersRewards();
                    userReward.UserId = reader.GetInt32(0);
                    userReward.RewardId = reader.GetInt32(1);

                    usersRewards.Add(userReward);
                }
            }
            return usersRewards;
        }

        public void AddNewReward()
        {
            Reward reward = new Reward { Title = "-", Description = "-" };

            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"Insert dbo.Rewards(Title,Description) " +
                    $"Values ('{reward.Title}','{reward.Description}')";

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public User GetThisUser(int cellUserId)
        {
            var user = new User();
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"Select * From dbo.Users Where ID={cellUserId}";

                connection.Open();

                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    user.ID = reader.GetInt32(0);
                    user.FirstName = reader.GetString(1);
                    user.LastName = reader.GetString(2);
                    user.Bithdaydate = reader.GetDateTime(3);
                }
            }
            return user;
        }

        public void EditUser(int cellUserId, User user)
        {
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"refreshUser";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add($"UserId", SqlDbType.Int).Value =
                    user.ID;
                command.Parameters.Add($"UserFirstName", SqlDbType.NVarChar).Value =
                    user.FirstName;
                command.Parameters.Add($"UserLastName", SqlDbType.NVarChar).Value =
                    user.LastName;
                command.Parameters.Add($"UserBithdaydate", SqlDbType.Date).Value =
                    user.Bithdaydate;

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public Reward GetThisReward(int cellRewardId)
        {
            var reward = new Reward();
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"Select * from dbo.Rewards Where ID={cellRewardId}";

                connection.Open();

                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    reward.ID = reader.GetInt32(0);
                    reward.Title = reader.GetString(1);
                    reward.Description = reader.GetString(2);
                }
            }
            return reward;
        }

        public void EditReward(int cellRewardId, Reward reward)
        {
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"refreshReward";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add($"RewardId", SqlDbType.Int).Value =
                    reward.ID;
                command.Parameters.Add($"RewardTitle", SqlDbType.NVarChar).Value =
                    reward.Title;
                command.Parameters.Add($"RewardDescription", SqlDbType.NVarChar).Value =
                    reward.Description;

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int cellUserId)
        {
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"deleteUser";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add($"UserID", SqlDbType.Int).Value =
                    GetThisUser(cellUserId).ID;

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteReward(int cellRewardId)
        {
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"deleteReward";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add($"RewardId", SqlDbType.Int).Value =
                    GetThisReward(cellRewardId).ID;

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void TakeReward(UsersRewards userRewards)
        {
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"DELETE FROM UsersAndRewards Where RewardId" +
                    $" = {userRewards.RewardId}";

                connection.Open();

                var reader = command.ExecuteNonQuery();
            }

        }

        public void SetListUsersRewards(UsersRewards userRewards)
        {
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"INSERT UsersAndRewards(UserId, RewardId) VALUES" +
                    $"('{userRewards.UserId}','{userRewards.RewardId}')";

                connection.Open();

                var reader = command.ExecuteNonQuery();
            }
        }

        public IList<Reward> SortOfRewards(int columnIndex)
        {
            List<Reward> rewards = new List<Reward>();
            string columnHeader = "";
            switch (columnIndex)
            {
                case 0:
                    columnHeader = "ID";
                    break;
                case 1:
                    columnHeader = "Title";
                    break;
                case 2:
                    columnHeader = "Description";
                    break;
                default:
                    return rewards;

            }
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM Rewards ORDER BY {columnHeader}";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var reward = new Reward();
                    reward.ID = reader.GetInt32(0);
                    reward.Title = reader.GetString(1);
                    reward.Description = reader.GetString(2);

                    rewards.Add(reward);
                }
            }
            return rewards;

        }

        public IList<User> SortOfUsers(int columnIndex)
        {
            List<User> users = new List<User>();
            string columnHeader = "";
            switch (columnIndex)
            {
                case 0:
                    columnHeader = "ID";
                    break;
                case 1:
                    columnHeader = "FirstName";
                    break;
                case 2:
                    columnHeader = "LastName";
                    break;
                case 3:
                    columnHeader = "Bithdaydate";
                    break;
                default:
                    return users;

            }
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM Users" +
                    $" ORDER BY {columnHeader}";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var user = new User();
                    user.ID = reader.GetInt32(0);
                    user.FirstName = reader.GetString(1);
                    user.LastName = reader.GetString(2);
                    user.Bithdaydate = reader.GetDateTime(3);

                    users.Add(user);
                }
            }
            return users;
        }



        public IList<UsersRewards> SortOfUsersRewards(int columnIndex)
        {
            List<UsersRewards> usersRewards = new List<UsersRewards>();
            string columnHeader = "";
            switch (columnIndex)
            {
                case 0:
                    columnHeader = "UserId";
                    break;
                case 1:
                    columnHeader = "RewardId";
                    break;
                default:
                    return usersRewards;

            }
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM UsersAndRewards" +
                    $" ORDER BY {columnHeader}";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var userRewards = new UsersRewards();
                    userRewards.UserId = reader.GetInt32(0);
                    userRewards.RewardId = reader.GetInt32(1);

                    usersRewards.Add(userRewards);
                }
            }
            return usersRewards;
        }
        public void refreshDataBase()
        {
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"refreshDataBase";
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public IList<UsersRewards> ShowAllRewardsOfUser(int userID)
        {
            List<UsersRewards> usersRewards = new List<UsersRewards>();
            using (var connection = new SqlConnection(_connectionStringBuilder))
            {
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM UsersAndRewards Where UserId = {userID}";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var userRewards = new UsersRewards();
                    userRewards.UserId = reader.GetInt32(0);
                    userRewards.RewardId = reader.GetInt32(1);

                    usersRewards.Add(userRewards);
                }
            }
            return usersRewards;
        }
    }
}

