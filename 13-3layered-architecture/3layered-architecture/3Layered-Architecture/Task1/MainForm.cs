using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Entities;
using UsersAndRewardsBL;

namespace Task1
{
    public partial class MainForm : Form
    {
        private readonly BindingList<User> _blUser;//создание биндов, как источника данных dgv
        private readonly BindingList<Reward> _blReward;

        private int idUser = 0;//ID пользователя, используется для инициализации объектов класса
        private int idReward = 0;

        private int _cellUserId;//ID пользователя, который образуется в результате нажатия клавиши на определенное поле
        private int _cellRewardId;

        private readonly IUsersDataManager _usersDataManager;
        private readonly IRewardsDataManager _rewardsDataManager;
        public MainForm(IUsersDataManager usersDataManager, IRewardsDataManager rewardsDataManager)
        {
            InitializeComponent();

            _usersDataManager = usersDataManager;
            _rewardsDataManager = rewardsDataManager;

            _blUser = new BindingList<User>(_usersDataManager.GetListUser);
            _blReward = new BindingList<Reward>(_rewardsDataManager.GetListReward);

            dgvUser.DataSource = _blUser;
            dgvRewards.DataSource = _blReward;
        }

        private void btnAddUser_Click(object sender, EventArgs e)//добавление новых пользователей со стандартной инициализацией
        {
            _usersDataManager.AddNewUser(new User
            {
                ID = idUser,
                FirstName = "-",
                LastName = "-",
                Bithdaydate = DateTime.Today,
                UserRewards = "-"
            });
            idUser++;

            _blUser.ResetBindings();
        }

        private void btnAddReward_Click(object sender, EventArgs e)//добавление новых наград со стандартной инициализацией
        {
            _rewardsDataManager.AddNewReward(new Reward
            {
                ID = idReward,
                Description = "-",
                Title = "-"
            });
            idReward++;

            _blReward.ResetBindings();
        }

        private void btnEditUser_Click(object sender, EventArgs e)//изменение объекта пользователя
        {

            var editUserForm = new EditUser(_usersDataManager.GetThisUser(_cellUserId), _rewardsDataManager.GetListReward);
            if (editUserForm.ResultCompareOfNull == 1) return;

            editUserForm.ShowDialog();

            _usersDataManager.EditUser(_cellUserId, editUserForm._user);

            _blUser.ResetBindings();
        }



        private void btnEditReward_Click(object sender, EventArgs e)//метод для изменение объекта наград
        {


            var editRewardForm = new EditReward(_rewardsDataManager.GetThisReward(_cellRewardId));
            if (editRewardForm.ResultCompareOfNull == 1) return;
            editRewardForm.ShowDialog();

            _rewardsDataManager.EditReward(_cellRewardId, editRewardForm._reward);

            _blReward.ResetBindings();
        }

        private void btnClose_Click(object sender, EventArgs e)//закрытие основого окна
        {
            Close();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)//нажатие на определенное поле в dgv пользователя
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    _cellUserId = e.RowIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRewards_CellClick(object sender, DataGridViewCellEventArgs e)//нажатие на определенное поле в dgv наград
        {
            try
            {
                if (e.ColumnIndex >= 0)
                {
                    _cellRewardId = e.RowIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)//удаление пользователя из dgv
        {
            if (MessageBox.Show("Delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _usersDataManager.DeleteUser(_cellUserId);
            }

            _blUser.ResetBindings();
        }

        private void btnRewardDelete_Click(object sender, EventArgs e)//удаление награды из dgv
        {
            if (MessageBox.Show("Delete this reward?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _usersDataManager.DeleteRewardsForUsers(_cellRewardId);//удаление наград из таблицы пользователей

                _rewardsDataManager.DeleteReward(_cellRewardId);
            }

            _blReward.ResetBindings();
            _blUser.ResetBindings();
        }


        private void dgvUser_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//сортировка по нажатию на заголовок dgv
        {

            _usersDataManager.SortOfUsers(e.ColumnIndex);

            _blUser.ResetBindings();
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//метод для награждения пользователя
        {
            if (e.ColumnIndex == 5)
            {
                var addRewardForm = new
                    fAddReward(_usersDataManager.GetThisUser(_cellUserId), _rewardsDataManager.GetListReward);
                addRewardForm.ShowDialog();

                _blUser.ResetBindings();
            }
        }

        private void dgvRewards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//сортировка наград
        {
            _rewardsDataManager.SortOfRewards(e.ColumnIndex);

            _blReward.ResetBindings();
        }
    }
}
