using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task1
{
    public partial class fAddReward : Form
    {
        public User _user = new User();
        public UsersRewards _userRewards;
        private List<Reward> _rewardList;
        public fAddReward(User user, List<Reward> rewardList)
        {
            InitializeComponent();
            _user = user;
            _rewardList = rewardList;

            ComboBoxInitByRewardList(rewardList);
        }

        private void ComboBoxInitByRewardList(List<Reward> rewardList)
        {
            for (int i = 0; i < rewardList.Count; i++)
            {
                cbAddReward.Items.Add(rewardList[i].Title);
            }
        }

        private void btnOkAddReward_Click(object sender, EventArgs e)
        {
            foreach (var reward in _rewardList)
            {
                if (reward.Title.Contains(cbAddReward.Text))
                {
                    _userRewards = new UsersRewards
                    {
                        UserId = _user.ID,
                        RewardId = reward.ID
                    };
                }

            }
            isDelete = false;

            Close();
        }

        private void btnCancelAddReward_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool isDelete { get; private set; }
        private void btnAddRewardDelete_Click(object sender, EventArgs e)
        {
            foreach (var reward in _rewardList)
            {
                if (reward.Title.Contains(cbAddReward.Text))
                {
                    _userRewards = new UsersRewards
                    {
                        UserId = _user.ID,
                        RewardId = reward.ID
                    };
                }

            }
            isDelete = true;

            Close();
        }
    }
}
