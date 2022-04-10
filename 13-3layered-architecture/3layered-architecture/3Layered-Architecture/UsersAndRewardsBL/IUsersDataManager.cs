using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsersAndRewardsBL
{
    public interface IUsersDataManager
    {
        public List<User> GetListUser { get; }
        public void SetListUser(List<User> value);
        void AddNewUser(User user);
        User GetThisUser(int cellUserId);
        void EditUser(int cellUserId, User user);
        void DeleteUser(int cellUserId);
        void DeleteRewardsForUsers(int cellRewardId);
        void SortOfUsers(int columnIndex);
    }
}
