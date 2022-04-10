
namespace Task1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcUsersAndRewards = new System.Windows.Forms.TabControl();
            this.tbUsers = new System.Windows.Forms.TabPage();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tbRewards = new System.Windows.Forms.TabPage();
            this.btnRewardDelete = new System.Windows.Forms.Button();
            this.btnAddRewards = new System.Windows.Forms.Button();
            this.btnEditRewards = new System.Windows.Forms.Button();
            this.dgvRewards = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcUsersAndRewards.SuspendLayout();
            this.tbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tbRewards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUsersAndRewards
            // 
            this.tcUsersAndRewards.Controls.Add(this.tbUsers);
            this.tcUsersAndRewards.Controls.Add(this.tbRewards);
            this.tcUsersAndRewards.Location = new System.Drawing.Point(22, 12);
            this.tcUsersAndRewards.Name = "tcUsersAndRewards";
            this.tcUsersAndRewards.SelectedIndex = 0;
            this.tcUsersAndRewards.Size = new System.Drawing.Size(986, 488);
            this.tcUsersAndRewards.TabIndex = 0;
            // 
            // tbUsers
            // 
            this.tbUsers.Controls.Add(this.btnUserDelete);
            this.tbUsers.Controls.Add(this.btnAddUser);
            this.tbUsers.Controls.Add(this.btnEditUser);
            this.tbUsers.Controls.Add(this.dgvUser);
            this.tbUsers.Location = new System.Drawing.Point(4, 29);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsers.Size = new System.Drawing.Size(978, 455);
            this.tbUsers.TabIndex = 0;
            this.tbUsers.Text = "Users";
            this.tbUsers.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(614, 409);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(94, 29);
            this.btnUserDelete.TabIndex = 3;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(733, 409);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(94, 29);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(851, 409);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(94, 29);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(18, 22);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 29;
            this.dgvUser.Size = new System.Drawing.Size(941, 381);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
            this.dgvUser.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUser_ColumnHeaderMouseClick);
            // 
            // tbRewards
            // 
            this.tbRewards.Controls.Add(this.btnRewardDelete);
            this.tbRewards.Controls.Add(this.btnAddRewards);
            this.tbRewards.Controls.Add(this.btnEditRewards);
            this.tbRewards.Controls.Add(this.dgvRewards);
            this.tbRewards.Location = new System.Drawing.Point(4, 29);
            this.tbRewards.Name = "tbRewards";
            this.tbRewards.Padding = new System.Windows.Forms.Padding(3);
            this.tbRewards.Size = new System.Drawing.Size(978, 455);
            this.tbRewards.TabIndex = 1;
            this.tbRewards.Text = "Rewards";
            this.tbRewards.UseVisualStyleBackColor = true;
            // 
            // btnRewardDelete
            // 
            this.btnRewardDelete.Location = new System.Drawing.Point(593, 406);
            this.btnRewardDelete.Name = "btnRewardDelete";
            this.btnRewardDelete.Size = new System.Drawing.Size(94, 29);
            this.btnRewardDelete.TabIndex = 3;
            this.btnRewardDelete.Text = "Delete";
            this.btnRewardDelete.UseVisualStyleBackColor = true;
            this.btnRewardDelete.Click += new System.EventHandler(this.btnRewardDelete_Click);
            // 
            // btnAddRewards
            // 
            this.btnAddRewards.Location = new System.Drawing.Point(719, 406);
            this.btnAddRewards.Name = "btnAddRewards";
            this.btnAddRewards.Size = new System.Drawing.Size(94, 29);
            this.btnAddRewards.TabIndex = 2;
            this.btnAddRewards.Text = "Add";
            this.btnAddRewards.UseVisualStyleBackColor = true;
            this.btnAddRewards.Click += new System.EventHandler(this.btnAddReward_Click);
            // 
            // btnEditRewards
            // 
            this.btnEditRewards.Location = new System.Drawing.Point(844, 406);
            this.btnEditRewards.Name = "btnEditRewards";
            this.btnEditRewards.Size = new System.Drawing.Size(94, 29);
            this.btnEditRewards.TabIndex = 1;
            this.btnEditRewards.Text = "Edit";
            this.btnEditRewards.UseVisualStyleBackColor = true;
            this.btnEditRewards.Click += new System.EventHandler(this.btnEditReward_Click);
            // 
            // dgvRewards
            // 
            this.dgvRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRewards.Location = new System.Drawing.Point(17, 27);
            this.dgvRewards.Name = "dgvRewards";
            this.dgvRewards.RowHeadersWidth = 51;
            this.dgvRewards.RowTemplate.Height = 29;
            this.dgvRewards.Size = new System.Drawing.Size(935, 363);
            this.dgvRewards.TabIndex = 0;
            this.dgvRewards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRewards_CellClick);
            this.dgvRewards.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRewards_ColumnHeaderMouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(870, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 562);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcUsersAndRewards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "UsersAndRewards";
            this.tcUsersAndRewards.ResumeLayout(false);
            this.tbUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tbRewards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRewards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUsersAndRewards;
        private System.Windows.Forms.TabPage tbUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TabPage tbRewards;
        private System.Windows.Forms.Button btnAddRewards;
        private System.Windows.Forms.Button btnEditRewards;
        private System.Windows.Forms.DataGridView dgvRewards;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnRewardDelete;
    }
}

