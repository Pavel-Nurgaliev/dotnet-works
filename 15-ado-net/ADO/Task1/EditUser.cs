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
    public partial class EditUser : Form
    {
        public User _user = new User();//поле, для вывода информации
        private User _storeUser;
        private int _resultCompareOfNull = 0;

        public int ResultCompareOfNull
        {
            get
            {
                return _resultCompareOfNull;
            }
        }

        public EditUser(User user)
        {
            InitializeComponent();
            if (CheckOnSelNullRaw(user) == 1) return;

            _storeUser = user;
            tbFirstNameUserEdit.Text = user.FirstName;//вывод информации о пользователе, подлежащей изменению
            tbLastNameUserEdit.Text = user.LastName;
            dtpBithdayUserEdit.Text = user.Bithdaydate.ToString();

        }

        private int CheckOnSelNullRaw(User user)
        {
            if (user == null)
            {
                MessageBox.Show("Raw was null", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _resultCompareOfNull = 1;

                Close();
            }
            return _resultCompareOfNull;
        }

        private void btnOkUserEdit_Click(object sender, EventArgs e)//принятие измененией
        {
            var result = ValidateChildren();

            if (!result)
            {
                return;
            }

            _user.FirstName = tbFirstNameUserEdit.Text;
            _user.LastName = tbLastNameUserEdit.Text;
            _user.Bithdaydate = DateTime.Parse(dtpBithdayUserEdit.Text);
            _user.ID = _storeUser.ID;

            Close();
        }

        private void btnCancelUserEdit_Click(object sender, EventArgs e)//отмена изменений
        {
            _user.FirstName = _storeUser.FirstName;
            _user.LastName = _storeUser.LastName;
            _user.Bithdaydate = _storeUser.Bithdaydate;
            _user.ID = _storeUser.ID;

            AutoValidate = AutoValidate.Disable;

            Close();
        }


        private void tbFirstNameUserEdit_Validating(object sender, CancelEventArgs e)//валидация
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if (string.IsNullOrEmpty(tbFirstNameUserEdit.Text))
            {
                errorProvider.SetError(tbFirstNameUserEdit, value: "Should be no empty.");

                e.Cancel = true;
            }
            else if (tbLastNameUserEdit.Text.Length > 50)
            {
                errorProvider.SetError(tbFirstNameUserEdit, value: $"Should be less by " +
                    $"{tbLastNameUserEdit.Text.Length - 50} symbols");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbFirstNameUserEdit, value: null);
            }
        }

        private void tbLastNameUserEdit_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if (string.IsNullOrEmpty(tbLastNameUserEdit.Text))
            {

                errorProvider.SetError(tbLastNameUserEdit, value: "Shuld be no empty.");

                e.Cancel = true;
            }
            else if (tbLastNameUserEdit.Text.Length > 50)
            {
                errorProvider.SetError(tbLastNameUserEdit, value: $"Shuld be less by {tbLastNameUserEdit.Text.Length - 50}");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbLastNameUserEdit, value: null);
            }
        }

        private void dtpBithdayUserEdit_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if (string.IsNullOrEmpty(dtpBithdayUserEdit.Text))
            {

                errorProvider.SetError(dtpBithdayUserEdit, value: "Shuld be no empty.");

                e.Cancel = true;
            }
            else if (DateTime.Parse(dtpBithdayUserEdit.Text).Year < (DateTime.Now.Year - 150))
            {
                errorProvider.SetError(dtpBithdayUserEdit,
                    value: $"Shuld be less more on {(DateTime.Now.Year - 150) - DateTime.Parse(dtpBithdayUserEdit.Text).Year}");

                e.Cancel = true;
            }
            else if (DateTime.Parse(dtpBithdayUserEdit.Text) > DateTime.Now)
            {
                errorProvider.SetError(dtpBithdayUserEdit,
                    value: $"Shuld be less more " +
                    $"{DateTime.Parse(dtpBithdayUserEdit.Text).Year - DateTime.Now.Year}");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbLastNameUserEdit, value: null);
            }
        }
    }
}
