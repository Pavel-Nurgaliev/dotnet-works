
namespace Task1
{
    partial class EditReward
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
            this.btnOKRewardEdit = new System.Windows.Forms.Button();
            this.btnCancelRewardEdit = new System.Windows.Forms.Button();
            this.lbTitleRewardEdit = new System.Windows.Forms.Label();
            this.lbDescriptionRewardEdit = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitleRewardEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOKRewardEdit
            // 
            this.btnOKRewardEdit.Location = new System.Drawing.Point(220, 130);
            this.btnOKRewardEdit.Name = "btnOKRewardEdit";
            this.btnOKRewardEdit.Size = new System.Drawing.Size(94, 29);
            this.btnOKRewardEdit.TabIndex = 0;
            this.btnOKRewardEdit.Text = "OK";
            this.btnOKRewardEdit.UseVisualStyleBackColor = true;
            this.btnOKRewardEdit.Click += new System.EventHandler(this.btnOKRewardEdit_Click);
            // 
            // btnCancelRewardEdit
            // 
            this.btnCancelRewardEdit.CausesValidation = false;
            this.btnCancelRewardEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelRewardEdit.Location = new System.Drawing.Point(335, 130);
            this.btnCancelRewardEdit.Name = "btnCancelRewardEdit";
            this.btnCancelRewardEdit.Size = new System.Drawing.Size(94, 29);
            this.btnCancelRewardEdit.TabIndex = 1;
            this.btnCancelRewardEdit.Text = "Cancel";
            this.btnCancelRewardEdit.UseVisualStyleBackColor = true;
            this.btnCancelRewardEdit.Click += new System.EventHandler(this.btnCancelRewardEdit_Click);
            // 
            // lbTitleRewardEdit
            // 
            this.lbTitleRewardEdit.AutoSize = true;
            this.lbTitleRewardEdit.Location = new System.Drawing.Point(18, 26);
            this.lbTitleRewardEdit.Name = "lbTitleRewardEdit";
            this.lbTitleRewardEdit.Size = new System.Drawing.Size(38, 20);
            this.lbTitleRewardEdit.TabIndex = 2;
            this.lbTitleRewardEdit.Text = "Title";
            // 
            // lbDescriptionRewardEdit
            // 
            this.lbDescriptionRewardEdit.AutoSize = true;
            this.lbDescriptionRewardEdit.Location = new System.Drawing.Point(18, 73);
            this.lbDescriptionRewardEdit.Name = "lbDescriptionRewardEdit";
            this.lbDescriptionRewardEdit.Size = new System.Drawing.Size(85, 20);
            this.lbDescriptionRewardEdit.TabIndex = 3;
            this.lbDescriptionRewardEdit.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(124, 70);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(305, 27);
            this.tbDescription.TabIndex = 5;
            this.tbDescription.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescription_Validating);
            // 
            // tbTitleRewardEdit
            // 
            this.tbTitleRewardEdit.Location = new System.Drawing.Point(124, 23);
            this.tbTitleRewardEdit.Name = "tbTitleRewardEdit";
            this.tbTitleRewardEdit.Size = new System.Drawing.Size(305, 27);
            this.tbTitleRewardEdit.TabIndex = 4;
            this.tbTitleRewardEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitleRewardEdit_Validating);
            // 
            // EditReward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 187);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitleRewardEdit);
            this.Controls.Add(this.lbDescriptionRewardEdit);
            this.Controls.Add(this.lbTitleRewardEdit);
            this.Controls.Add(this.btnCancelRewardEdit);
            this.Controls.Add(this.btnOKRewardEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditReward";
            this.Text = "EditReward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOKRewardEdit;
        private System.Windows.Forms.Button btnCancelRewardEdit;
        private System.Windows.Forms.Label lbTitleRewardEdit;
        private System.Windows.Forms.Label lbDescriptionRewardEdit;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbTitleRewardEdit;
    }
}