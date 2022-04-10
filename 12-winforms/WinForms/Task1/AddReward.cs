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
        private User _storeUser;
        public fAddReward(User user, List<Reward> rewardList)
        {
            InitializeComponent();
            _storeUser = user;

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
            if (_storeUser.UserRewards.Contains(cbAddReward.Text))
            {
                MessageBox.Show("Title of reward cannot be the same", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_storeUser.UserRewards == "-") _storeUser.UserRewards = "";
            _storeUser.UserRewards += $" {cbAddReward.Text}";

            _user = _storeUser;

            Close();
        }

        private void btnCancelAddReward_Click(object sender, EventArgs e)
        {
            _user = _storeUser;

            Close();
        }

        private void btnAddRewardDelete_Click(object sender, EventArgs e)
        {
            if (_storeUser.UserRewards.Contains(cbAddReward.Text))
            {
                _storeUser.UserRewards = _storeUser.UserRewards.Replace(cbAddReward.Text, "");
            }

            _user = _storeUser;

            Close();
        }
    }
}
