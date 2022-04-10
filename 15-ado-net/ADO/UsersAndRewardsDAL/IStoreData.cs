using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsersAndRewardsDAL
{
    public interface IStoreData
    {
        public List<User> ListOfUsers { get; set; }
        public List<Reward> ListOfRewards { get; set; }
        public List<UsersRewards> ListRewardsOfUsers { get; set; }
    }
}
