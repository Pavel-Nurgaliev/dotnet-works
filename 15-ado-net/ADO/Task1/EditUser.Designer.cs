
namespace Task1
{
    partial class EditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFirstNameUserEdit = new System.Windows.Forms.Label();
            this.lbLastNameUserEdit = new System.Windows.Forms.Label();
            this.lbBithdaydateUserEdit = new System.Windows.Forms.Label();
            this.tbFirstNameUserEdit = new System.Windows.Forms.TextBox();
            this.tbLastNameUserEdit = new System.Windows.Forms.TextBox();
            this.dtpBithdayUserEdit = new System.Windows.Forms.DateTimePicker();
            this.btnOkUserEdit = new System.Windows.Forms.Button();
            this.btnCancelUserEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFirstNameUserEdit
            // 
            this.lbFirstNameUserEdit.AutoSize = true;
            this.lbFirstNameUserEdit.Location = new System.Drawing.Point(24, 28);
            this.lbFirstNameUserEdit.Name = "lbFirstNameUserEdit";
            this.lbFirstNameUserEdit.Size = new System.Drawing.Size(76, 20);
            this.lbFirstNameUserEdit.TabIndex = 0;
            this.lbFirstNameUserEdit.Text = "FirstName";
            // 
            // lbLastNameUserEdit
            // 
            this.lbLastNameUserEdit.AutoSize = true;
            this.lbLastNameUserEdit.Location = new System.Drawing.Point(24, 78);
            this.lbLastNameUserEdit.Name = "lbLastNameUserEdit";
            this.lbLastNameUserEdit.Size = new System.Drawing.Size(75, 20);
            this.lbLastNameUserEdit.TabIndex = 1;
            this.lbLastNameUserEdit.Text = "LastName";
            // 
            // lbBithdaydateUserEdit
            // 
            this.lbBithdaydateUserEdit.AutoSize = true;
            this.lbBithdaydateUserEdit.Location = new System.Drawing.Point(24, 131);
            this.lbBithdaydateUserEdit.Name = "lbBithdaydateUserEdit";
            this.lbBithdaydateUserEdit.Size = new System.Drawing.Size(89, 20);
            this.lbBithdaydateUserEdit.TabIndex = 3;
            this.lbBithdaydateUserEdit.Text = "Bithdaydate";
            // 
            // tbFirstNameUserEdit
            // 
            this.tbFirstNameUserEdit.Location = new System.Drawing.Point(141, 25);
            this.tbFirstNameUserEdit.Name = "tbFirstNameUserEdit";
            this.tbFirstNameUserEdit.Size = new System.Drawing.Size(250, 27);
            this.tbFirstNameUserEdit.TabIndex = 6;
            this.tbFirstNameUserEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstNameUserEdit_Validating);
            // 
            // tbLastNameUserEdit
            // 
            this.tbLastNameUserEdit.Location = new System.Drawing.Point(141, 75);
            this.tbLastNameUserEdit.Name = "tbLastNameUserEdit";
            this.tbLastNameUserEdit.Size = new System.Drawing.Size(250, 27);
            this.tbLastNameUserEdit.TabIndex = 7;
            this.tbLastNameUserEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastNameUserEdit_Validating);
            // 
            // dtpBithdayUserEdit
            // 
            this.dtpBithdayUserEdit.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpBithdayUserEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBithdayUserEdit.Location = new System.Drawing.Point(141, 126);
            this.dtpBithdayUserEdit.Name = "dtpBithdayUserEdit";
            this.dtpBithdayUserEdit.Size = new System.Drawing.Size(250, 27);
            this.dtpBithdayUserEdit.TabIndex = 9;
            this.dtpBithdayUserEdit.Validating += new System.ComponentModel.CancelEventHandler(this.dtpBithdayUserEdit_Validating);
            // 
            // btnOkUserEdit
            // 
            this.btnOkUserEdit.Location = new System.Drawing.Point(183, 177);
            this.btnOkUserEdit.Name = "btnOkUserEdit";
            this.btnOkUserEdit.Size = new System.Drawing.Size(94, 29);
            this.btnOkUserEdit.TabIndex = 10;
            this.btnOkUserEdit.Text = "OK";
            this.btnOkUserEdit.UseVisualStyleBackColor = true;
            this.btnOkUserEdit.Click += new System.EventHandler(this.btnOkUserEdit_Click);
            // 
            // btnCancelUserEdit
            // 
            this.btnCancelUserEdit.CausesValidation = false;
            this.btnCancelUserEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelUserEdit.Location = new System.Drawing.Point(297, 177);
            this.btnCancelUserEdit.Name = "btnCancelUserEdit";
            this.btnCancelUserEdit.Size = new System.Drawing.Size(94, 29);
            this.btnCancelUserEdit.TabIndex = 11;
            this.btnCancelUserEdit.Text = "Cancel";
            this.btnCancelUserEdit.UseVisualStyleBackColor = true;
            this.btnCancelUserEdit.Click += new System.EventHandler(this.btnCancelUserEdit_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 225);
            this.Controls.Add(this.btnCancelUserEdit);
            this.Controls.Add(this.btnOkUserEdit);
            this.Controls.Add(this.dtpBithdayUserEdit);
            this.Controls.Add(this.tbLastNameUserEdit);
            this.Controls.Add(this.tbFirstNameUserEdit);
            this.Controls.Add(this.lbBithdaydateUserEdit);
            this.Controls.Add(this.lbLastNameUserEdit);
            this.Controls.Add(this.lbFirstNameUserEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstNameUserEdit;
        private System.Windows.Forms.Label lbLastNameUserEdit;
        private System.Windows.Forms.Label lbBithdaydateUserEdit;
        private System.Windows.Forms.TextBox tbFirstNameUserEdit;
        private System.Windows.Forms.TextBox tbLastNameUserEdit;
        private System.Windows.Forms.DateTimePicker dtpBithdayUserEdit;
        private System.Windows.Forms.Button btnOkUserEdit;
        private System.Windows.Forms.Button btnCancelUserEdit;
    }
}