using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsersAndRewardsBL
{
    public interface IUsersDataManager
    {
        public List<User> GetListUser { get; }
        public List<UsersRewards> GetRewardsOfUsersList { get; }


        public void SetListUser(List<User> value);
        public void SetListUsersRewards(UsersRewards userRewards);
        void AddNewUser(User user);
        User GetThisUser(int cellUserId);
        void EditUser(int cellUserId, User user);
        void DeleteUser(int cellUserId);
        void SortOfUsers(int columnIndex);
        void SortOfUsersRewards(int columnIndex);
        void TakeReward(UsersRewards userRewards);
    }
}
