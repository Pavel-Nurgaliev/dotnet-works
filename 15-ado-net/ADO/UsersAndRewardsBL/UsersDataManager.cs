using Entities;
using System;
using System.Collections.Generic;
using UsersAndRewardsDAL;

namespace UsersAndRewardsBL
{
    public class UsersDataManager : IUsersDataManager
    {
        private readonly IStoreData _data;
        public UsersDataManager(IStoreData data)
        {
            _data = data;
        }

        public List<User> GetListUser
        {
            get => _data.ListOfUsers;
        }

        public List<UsersRewards> GetRewardsOfUsersList { get => _data.ListRewardsOfUsers; }

        public void AddNewUser(User user)
        {
            _data.ListOfUsers.Add(user);
        }



        public void DeleteUser(int cellUserId)
        {

            _data.ListRewardsOfUsers.RemoveAll(x => x.UserId == cellUserId);

            _data.ListOfUsers.Remove(_data.ListOfUsers[cellUserId]);
        }

        public void EditUser(int cellUserId, User user)
        {
            _data.ListOfUsers[cellUserId] = user;
        }

        public User GetThisUser(int cellUserId)
        {
            //метод, позволяющий получить объект пользователя, при нажатии на определенное поле

            return _data.ListOfUsers[cellUserId];
        }

        public void SetListUser(List<User> value)
        {
            _data.ListOfUsers = value;
        }

        public void SetListUsersRewards(UsersRewards userRewards)
        {
            foreach (var userWithRewards in _data.ListRewardsOfUsers)
            {
                if (userWithRewards.RewardId == userRewards.RewardId &&
                    userWithRewards.UserId == userRewards.UserId) return;
            }
            _data.ListRewardsOfUsers.Add(userRewards);
        }

        public void SortOfUsers(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    _data.ListOfUsers.Sort((x, y) => x.ID.CompareTo(y.ID));
                    break;
                case 1:
                    _data.ListOfUsers.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
                    break;
                case 2:
                    _data.ListOfUsers.Sort((x, y) => x.LastName.CompareTo(y.LastName));
                    break;
                case 3:
                    _data.ListOfUsers.Sort((x, y) => x.Bithdaydate.CompareTo(y.Bithdaydate));
                    break;
                case 4:
                    _data.ListOfUsers.Sort((x, y) => x.Age.CompareTo(y.Age));
                    break;

            }
        }

        public void SortOfUsersRewards(int columnIndex)
        {
            if (columnIndex == 0)
            {
                _data.ListRewardsOfUsers.Sort((x, y) => x.UserId.CompareTo(y.UserId));
            }
            if (columnIndex == 1)
            {
                _data.ListRewardsOfUsers.Sort((x, y) => x.RewardId.CompareTo(y.RewardId));
            }
        }

        public void TakeReward(UsersRewards userRewards)
        {
            _data.ListRewardsOfUsers.RemoveAll(x => x.UserId == userRewards.UserId
            && x.RewardId == userRewards.RewardId);
        }
    }
}
