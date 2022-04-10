using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task1
{
    public partial class EditReward : Form
    {
        public Reward _reward = new Reward();
        private Reward _storeReward;
        private int _resultCompareOfNull = 0;

        public int ResultCompareOfNull
        {
            get
            {
                return _resultCompareOfNull;
            }
        }

        public EditReward(Reward reward)
        {
            InitializeComponent();

            if (ChekOnSelNullRaw(reward) == 1) return;

            _storeReward = reward;
            tbTitleRewardEdit.Text = reward.Title;
            tbDescription.Text = reward.Description;

        }

        private int ChekOnSelNullRaw(Reward reward)
        {
            if (reward == null)
            {
                MessageBox.Show("Raw was null", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _resultCompareOfNull = 1;

                Close();
            }
            return _resultCompareOfNull;
        }

        private void btnOKRewardEdit_Click(object sender, EventArgs e)//принятие изменений
        {

            _reward.Title = tbTitleRewardEdit.Text;
            _reward.Description = tbDescription.Text;
            _reward.ID = _storeReward.ID;

            Close();
        }

        private void btnCancelRewardEdit_Click(object sender, EventArgs e)//отмена изменений
        {
            _reward.Title = _storeReward.Title;
            _reward.Description = _storeReward.Description;
            _reward.ID = _storeReward.ID;

            Close();
        }

        private void tbTitleRewardEdit_Validating(object sender, CancelEventArgs e)//валидация
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if (string.IsNullOrEmpty(tbTitleRewardEdit.Text))
            {
                errorProvider.SetError(tbTitleRewardEdit, value: "Shuld be no empty.");

                e.Cancel = true;
            }
            else if (tbTitleRewardEdit.Text.Length > 50)
            {
                errorProvider.SetError(tbTitleRewardEdit,
                    value: $"Shuld be less on {tbTitleRewardEdit.Text.Length - 50} symbols");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbTitleRewardEdit, value: null);
            }
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if (tbDescription.Text.Length > 250)
            {
                errorProvider.SetError(tbTitleRewardEdit,
                    value: $"Shuld be less on {tbTitleRewardEdit.Text.Length - 250} symbols");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbTitleRewardEdit, value: null);
            }
        }
    }
}
