using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsersAndRewardsBL
{
    public interface IRewardsDataManager
    {
        public List<Reward> GetListReward { get; }
        public void SetListReward(List<Reward> value);
        void AddNewReward(Reward reward);
        Reward GetThisReward(int cellRewardId);
        void EditReward(int cellRewardId, Reward reward);
        void DeleteReward(int cellRewardId);
        void SortOfRewards(int columnIndex);
        bool CheckOnContainsTitle(Reward reward);
    }
}
