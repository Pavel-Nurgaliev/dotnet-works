using Entities;
using System;
using System.Collections.Generic;

namespace UsersAndRewardsDAL
{
    public class StoreData : IStoreData
    {
        private List<User> _users = new List<User>();//создание списка данных пользователя и наград
        private List<Reward> _rewards = new List<Reward>();
        private List<UsersRewards> _usersRewards = new List<UsersRewards>();

        public List<User> ListOfUsers
        {
            get => _users;
            set => _users = value;
        }
        public List<Reward> ListOfRewards
        {
            get => _rewards;
            set => _rewards = value;
        }
        public List<UsersRewards> ListRewardsOfUsers
        {
            get => _usersRewards;
            set => _usersRewards = value;
        }
    }
}
