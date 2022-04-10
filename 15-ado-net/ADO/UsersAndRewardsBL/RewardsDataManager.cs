﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using UsersAndRewardsDAL;

namespace UsersAndRewardsBL
{
    public class RewardsDataManager : IRewardsDataManager
    {
        private readonly IStoreData _data;
        public RewardsDataManager(IStoreData data)
        {
            _data = data;
        }

        public List<Reward> GetListReward
        {
            get => _data.ListOfRewards;
        }

        public void AddNewReward(Reward reward)
        {
            _data.ListOfRewards.Add(reward);
        }

        public bool CheckOnContainsTitle(Reward reward)
        {
            foreach (var selectReward in _data.ListOfRewards)
            {
                if (reward.Title.Contains(selectReward.Title)) return true;
            }
            return false;
        }

        public void DeleteReward(int cellRewardId)
        {
            _data.ListRewardsOfUsers.RemoveAll(x => x.RewardId == cellRewardId);

            _data.ListOfRewards.Remove(_data.ListOfRewards[cellRewardId]);
        }

        public void EditReward(int cellRewardId, Reward reward)
        {
            _data.ListOfRewards[cellRewardId] = reward;
        }

        public Reward GetThisReward(int cellRewardId)
        {
            return _data.ListOfRewards[cellRewardId];
        }

        public void SetListReward(List<Reward> value)
        {
            _data.ListOfRewards = value;
        }

        public void SortOfRewards(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    _data.ListOfRewards.Sort((x, y) => x.ID.CompareTo(y.ID));
                    break;
                case 1:
                    _data.ListOfRewards.Sort((x, y) => x.Title.CompareTo(y.Title));
                    break;
                case 2:
                    _data.ListOfRewards.Sort((x, y) => x.Description.CompareTo(y.Description));
                    break;
            }
        }
    }
}
