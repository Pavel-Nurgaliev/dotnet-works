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


        public void AddNewUser(User user)
        {
            _data.ListOfUsers.Add(user);
        }

        public void DeleteRewardsForUsers(int cellRewardId)
        {
            for (int count = 0; count < _data.ListOfUsers.Count; count++)
            {
                if (_data.ListOfUsers[count].UserRewards == null) continue;
                if (_data.ListOfUsers[count].UserRewards.Contains(_data.ListOfRewards[cellRewardId].Title))
                {
                    _data.ListOfUsers[count].UserRewards =
                        _data.ListOfUsers[count].UserRewards.Replace(_data.ListOfRewards[cellRewardId].Title, "");
                }
            }
        }

        public void DeleteUser(int cellUserId)
        {
            _data.ListOfUsers.Remove(_data.ListOfUsers[cellUserId]);
        }

        public void EditUser(int cellUserId, User user)
        {
            _data.ListOfUsers[cellUserId] = user;
        }

        public User GetThisUser(int cellUserId)
        {
            //метод, позволяющий получить объект пользователя, при нажатии на определенное поле
            User user = null;
            for (int i = 0; i < _data.ListOfUsers.Count; i++)
            {
                if (cellUserId == _data.ListOfUsers[i].ID)
                {
                    user = _data.ListOfUsers[i];
                }
            }
            return user;
        }

        public void SetListUser(List<User> value)
        {
            _data.ListOfUsers = value;
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
                case 5:
                    _data.ListOfUsers.Sort((x, y) => x.UserRewards.CompareTo(y.UserRewards));
                    break;
            }
        }
    }
}
