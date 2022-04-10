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

namespace Task1
{
    public partial class MainForm : Form
    {
        private readonly BindingList<User> _blUser;//создание биндов, как источника данных dgv
        private readonly BindingList<Reward> _blReward;

        private readonly List<User> _users = new List<User>();//создание списка данных пользователя и наград
        private readonly List<Reward> _rewards = new List<Reward>();

        private int idUser = 0;//ID пользователя, используется для инициализации объектов класса
        private int idReward = 0;

        private int _cellUserId;//ID пользователя, который образуется в результате нажатия клавиши на определенное поле
        private int _cellRewardId;
        public MainForm()
        {
            InitializeComponent();

            _blUser = new BindingList<User>(_users);
            _blReward = new BindingList<Reward>(_rewards);

            dgvUser.DataSource = _blUser;
            dgvRewards.DataSource = _blReward;
        }

        private void btnAddUser_Click(object sender, EventArgs e)//добавление новых пользователей со стандартной инициализацией
        {
            _users.Add(new User
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
            _rewards.Add(new Reward
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
            User user = null;
            user = GetThisUser(user);

            var editUserForm = new EditUser(user, _rewards);
            if (editUserForm.ResultCompareOfNull == 1) return;

            editUserForm.ShowDialog();

            _users[_cellUserId] = editUserForm._user;
            _blUser.ResetBindings();
        }

        private User GetThisUser(User user)//метод, позволяющий получить объект пользователя, при нажатии на определенное поле
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_cellUserId == _users[i].ID)
                {
                    user = _users[i];
                }
            }
            return user;
        }

        private void btnEditReward_Click(object sender, EventArgs e)//метод для изменение объекта наград
        {
            Reward reward = null;

            reward = GetThisReward(reward);

            var editRewardForm = new EditReward(reward);
            if (editRewardForm.ResultCompareOfNull == 1) return;
            editRewardForm.ShowDialog();

            _rewards[_cellRewardId] = editRewardForm._reward;
            _blReward.ResetBindings();
        }

        private Reward GetThisReward(Reward reward)//метод, позволяющий получить объект наград при нажатии на определенное поле dgv
        {
            for (int i = 0; i < _rewards.Count; i++)
            {
                if (_cellRewardId == _rewards[i].ID)
                {
                    reward = _rewards[i];
                }
            }

            return reward;
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
                _users.Remove(_users[_cellUserId]);
            }

            _blUser.ResetBindings();
        }

        private void btnRewardDelete_Click(object sender, EventArgs e)//удаление награды из dgv
        {
            DeleteRewardsForUsers();//удаление наград из таблицы пользователей

            _blReward.ResetBindings();
            _blUser.ResetBindings();
        }

        private void DeleteRewardsForUsers()
        {
            if (MessageBox.Show("Delete this reward?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int count = 0; count < _users.Count; count++)
                {
                    if (_users[count].UserRewards == null) continue;
                    if (_users[count].UserRewards.Contains(_rewards[_cellRewardId].Title))
                    {
                        _users[count].UserRewards =
                            _users[count].UserRewards.Replace(_rewards[_cellRewardId].Title, "");
                    }
                }

                _rewards.Remove(_rewards[_cellRewardId]);
            }
        }

        private void dgvUser_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//сортировка по нажатию на заголовок dgv
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    _users.Sort((x, y) => x.ID.CompareTo(y.ID));
                    break;
                case 1:
                    _users.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
                    break;
                case 2:
                    _users.Sort((x, y) => x.LastName.CompareTo(y.LastName));
                    break;
                case 3:
                    _users.Sort((x, y) => x.Bithdaydate.CompareTo(y.Bithdaydate));
                    break;
                case 4:
                    _users.Sort((x, y) => x.Age.CompareTo(y.Age));
                    break;
                case 5:
                    _users.Sort((x, y) => x.UserRewards.CompareTo(y.UserRewards));
                    break;
            }


            _blUser.ResetBindings();
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//метод для награждения пользователя
        {
            if (e.ColumnIndex == 5)
            {
                User user = null;
                user = GetThisUser(user);

                var addRewardForm = new fAddReward(user, _rewards);
                addRewardForm.ShowDialog();

                _blUser.ResetBindings();
            }
        }

        private void dgvRewards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//сортировка наград
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    _rewards.Sort((x, y) => x.ID.CompareTo(y.ID));
                    break;
                case 1:
                    _rewards.Sort((x, y) => x.Title.CompareTo(y.Title));
                    break;
                case 2:
                    _rewards.Sort((x, y) => x.Description.CompareTo(y.Description));
                    break;
            }

            _blReward.ResetBindings();
        }
    }
}
