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
using UsersAndRewardsSQL;

namespace Task1
{
    public partial class MainForm : Form
    {
        private readonly BindingList<User> _blUser;//создание биндов, как источника данных dgv
        private readonly BindingList<Reward> _blReward;
        private readonly BindingList<UsersRewards> _blUsersRewards;

        private int idUser = 0;//ID пользователя, используется для инициализации объектов класса
        private int idReward = 0;

        private int _cellUserId;//ID пользователя, который образуется в результате нажатия клавиши на определенное поле
        private int _cellRewardId;

        private readonly IUsersDataManager _usersDataManager;
        private readonly IRewardsDataManager _rewardsDataManager;

        private readonly string _connectionStringBuilder;
        private readonly DataBaseDAO _usersAndRewardsDAO;

        public MainForm(IUsersDataManager usersDataManager, IRewardsDataManager rewardsDataManager,
            string connectionStringBuilder)
        {
            InitializeComponent();

            _usersDataManager = usersDataManager;
            _rewardsDataManager = rewardsDataManager;

            _connectionStringBuilder = connectionStringBuilder;

            if (_rewardsDataManager == null || _usersDataManager == null)
            {
                _usersAndRewardsDAO = new DataBaseDAO(connectionStringBuilder);

                DisplayAllTables();
            }
            else
            {
                _blUser = new BindingList<User>(_usersDataManager.GetListUser);
                _blReward = new BindingList<Reward>(_rewardsDataManager.GetListReward);
                _blUsersRewards = new BindingList<UsersRewards>(_usersDataManager.GetRewardsOfUsersList);

                dgvUser.DataSource = _blUser;
                dgvRewards.DataSource = _blReward;
                dgvUsersRewards.DataSource = _blUsersRewards;
            }


        }
        private bool _sortUsers = false;
        private bool _sortRewards = false;
        private bool _sortUsersRewards = false;
        private void DisplayAllTables()
        {
            if (!_sortUsers)
            {
                dgvUser.DataSource = _usersAndRewardsDAO.GetAllUsers();
            }
            if (!_sortRewards)
            {
                dgvRewards.DataSource = _usersAndRewardsDAO.GetAllRewards();
            }
            if (!_sortUsersRewards)
            {
                dgvUsersRewards.DataSource = _usersAndRewardsDAO.GetAllUsersRewards();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)//добавление новых пользователей со стандартной инициализацией
        {
            if (_usersDataManager == null)
            {
                _usersAndRewardsDAO.AddNewUser(new User
                {
                    ID = idUser,
                    FirstName = "-",
                    LastName = "-",
                    Bithdaydate = DateTime.Today
                });
                idUser++;

                DisplayAllTables();
            }
            else
            {
                _usersDataManager.AddNewUser(new User
                {
                    ID = idUser,
                    FirstName = "-",
                    LastName = "-",
                    Bithdaydate = DateTime.Today
                });
                idUser++;

                _blUser.ResetBindings();
            }

        }

        private void btnAddReward_Click(object sender, EventArgs e)//добавление новых наград со стандартной инициализацией
        {
            if (_rewardsDataManager == null)
            {
                _usersAndRewardsDAO.AddNewReward(new Reward
                {
                    ID = idReward,
                    Description = "-",
                    Title = "-"
                });
                idReward++;

                DisplayAllTables();
            }
            else
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
        }

        private void btnEditUser_Click(object sender, EventArgs e)//изменение объекта пользователя
        {

            if (_usersDataManager == null)
            {
                var editUserForm = new EditUser(_usersAndRewardsDAO.GetThisUser(_cellUserId));
                if (editUserForm.ResultCompareOfNull == 1) return;

                editUserForm.ShowDialog();

                _usersAndRewardsDAO.EditUser(_cellUserId, editUserForm._user);

                DisplayAllTables();
            }
            else
            {
                var editUserForm = new EditUser(_usersDataManager.GetThisUser(_cellUserId));
                if (editUserForm.ResultCompareOfNull == 1) return;

                editUserForm.ShowDialog();

                _usersDataManager.EditUser(_cellUserId, editUserForm._user);

                _blUser.ResetBindings();
            }
        }

        private void btnEditReward_Click(object sender, EventArgs e)//метод для изменение объекта наград
        {
            if (_rewardsDataManager == null)
            {
                var editRewardForm = new EditReward(_usersAndRewardsDAO.GetThisReward(_cellRewardId));
                if (editRewardForm.ResultCompareOfNull == 1) return;
                editRewardForm.ShowDialog();

                _usersAndRewardsDAO.EditReward(_cellRewardId, editRewardForm._reward);

                DisplayAllTables();
            }
            else
            {
                var editRewardForm = new EditReward(_rewardsDataManager.GetThisReward(_cellRewardId));
                if (editRewardForm.ResultCompareOfNull == 1) return;
                editRewardForm.ShowDialog();

                if (_rewardsDataManager.CheckOnContainsTitle(editRewardForm._reward))
                {
                    MessageBox.Show("Reward with this title already exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _rewardsDataManager.EditReward(_cellRewardId, editRewardForm._reward);

                _blReward.ResetBindings();
            }
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
            if (_usersDataManager == null)
            {
                if (MessageBox.Show("Delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _usersAndRewardsDAO.DeleteUser(_cellUserId);
                }

                DisplayAllTables();
            }
            else
            {
                if (MessageBox.Show("Delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _usersDataManager.DeleteUser(_cellUserId);
                }

                _blUser.ResetBindings();
                _blUsersRewards.ResetBindings();
            }
        }

        private void btnRewardDelete_Click(object sender, EventArgs e)//удаление награды из dgv
        {
            if (_rewardsDataManager == null)
            {
                if (MessageBox.Show("Delete this reward?", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _usersAndRewardsDAO.DeleteReward(_cellRewardId);
                }

                DisplayAllTables();
            }
            else
            {
                if (MessageBox.Show("Delete this reward?", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _rewardsDataManager.DeleteReward(_cellRewardId);
                }
                _blReward.ResetBindings();
                _blUser.ResetBindings();
                _blUsersRewards.ResetBindings();
            }


        }


        private void dgvUser_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//сортировка по нажатию на заголовок dgv
        {
            if (_usersDataManager == null)
            {
                _sortUsers = true;

                _sortRewards = false;
                _sortUsersRewards = false;

                dgvUser.DataSource = _usersAndRewardsDAO.SortOfUsers(e.ColumnIndex);

                DisplayAllTables();
            }
            else
            {
                _usersDataManager.SortOfUsers(e.ColumnIndex);

                _blUser.ResetBindings();
            }
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//метод для награждения пользователя
        {
            if (e.ColumnIndex >= 0)
            {
                if (_rewardsDataManager == null || _usersDataManager == null)
                {
                    var addRewardForm = new
                        fAddReward(_usersAndRewardsDAO.GetThisUser(_cellUserId), _usersAndRewardsDAO.GetAllRewards().ToList<Reward>());
                    addRewardForm.ShowDialog();

                    if (addRewardForm._userRewards == null) return;
                    if (addRewardForm.isDelete == true)
                        _usersAndRewardsDAO.TakeReward(addRewardForm._userRewards);

                    else _usersAndRewardsDAO.SetListUsersRewards(addRewardForm._userRewards);

                    DisplayAllTables();
                }
                else
                {
                    var addRewardForm = new
                        fAddReward(_usersDataManager.GetThisUser(_cellUserId), _rewardsDataManager.GetListReward);
                    addRewardForm.ShowDialog();
                    if (addRewardForm.isDelete == true)
                        _usersDataManager.TakeReward(addRewardForm._userRewards);

                    else _usersDataManager.SetListUsersRewards(addRewardForm._userRewards);

                    _blUser.ResetBindings();
                    _blUsersRewards.ResetBindings();
                }
            }
        }

        private void dgvRewards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//сортировка наград
        {
            if (_rewardsDataManager == null)
            {
                _sortRewards = true;

                _sortUsers = false;
                _sortUsersRewards = false;

                dgvRewards.DataSource = _usersAndRewardsDAO.SortOfRewards(e.ColumnIndex);

                DisplayAllTables();
            }
            else
            {
                _rewardsDataManager.SortOfRewards(e.ColumnIndex);

                _blReward.ResetBindings();
            }
        }

        private void dgvUsersRewards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_rewardsDataManager == null || _usersDataManager == null)
            {
                _sortUsersRewards = true;

                _sortRewards = false;
                _sortUsers = false;

                dgvUsersRewards.DataSource = _usersAndRewardsDAO.SortOfUsersRewards(e.ColumnIndex);

                DisplayAllTables();
            }
            else
            {
                _usersDataManager.SortOfUsersRewards(e.ColumnIndex);

                _blUsersRewards.ResetBindings();
            }
        }
    }
}
