
namespace Task1
{
    partial class fAddReward
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
            this.btnOkAddReward = new System.Windows.Forms.Button();
            this.btnCancelAddReward = new System.Windows.Forms.Button();
            this.cbAddReward = new System.Windows.Forms.ComboBox();
            this.lbTitleAddReward = new System.Windows.Forms.Label();
            this.btnAddRewardDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOkAddReward
            // 
            this.btnOkAddReward.Location = new System.Drawing.Point(78, 127);
            this.btnOkAddReward.Name = "btnOkAddReward";
            this.btnOkAddReward.Size = new System.Drawing.Size(94, 29);
            this.btnOkAddReward.TabIndex = 0;
            this.btnOkAddReward.Text = "OK";
            this.btnOkAddReward.UseVisualStyleBackColor = true;
            this.btnOkAddReward.Click += new System.EventHandler(this.btnOkAddReward_Click);
            // 
            // btnCancelAddReward
            // 
            this.btnCancelAddReward.Location = new System.Drawing.Point(200, 127);
            this.btnCancelAddReward.Name = "btnCancelAddReward";
            this.btnCancelAddReward.Size = new System.Drawing.Size(94, 29);
            this.btnCancelAddReward.TabIndex = 1;
            this.btnCancelAddReward.Text = "Cancel";
            this.btnCancelAddReward.UseVisualStyleBackColor = true;
            this.btnCancelAddReward.Click += new System.EventHandler(this.btnCancelAddReward_Click);
            // 
            // cbAddReward
            // 
            this.cbAddReward.FormattingEnabled = true;
            this.cbAddReward.Location = new System.Drawing.Point(78, 42);
            this.cbAddReward.Name = "cbAddReward";
            this.cbAddReward.Size = new System.Drawing.Size(216, 28);
            this.cbAddReward.TabIndex = 2;
            // 
            // lbTitleAddReward
            // 
            this.lbTitleAddReward.AutoSize = true;
            this.lbTitleAddReward.Location = new System.Drawing.Point(13, 44);
            this.lbTitleAddReward.Name = "lbTitleAddReward";
            this.lbTitleAddReward.Size = new System.Drawing.Size(38, 20);
            this.lbTitleAddReward.TabIndex = 3;
            this.lbTitleAddReward.Text = "Title";
            // 
            // btnAddRewardDelete
            // 
            this.btnAddRewardDelete.Location = new System.Drawing.Point(322, 127);
            this.btnAddRewardDelete.Name = "btnAddRewardDelete";
            this.btnAddRewardDelete.Size = new System.Drawing.Size(94, 29);
            this.btnAddRewardDelete.TabIndex = 4;
            this.btnAddRewardDelete.Text = "Delete";
            this.btnAddRewardDelete.UseVisualStyleBackColor = true;
            this.btnAddRewardDelete.Click += new System.EventHandler(this.btnAddRewardDelete_Click);
            // 
            // fAddReward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 185);
            this.Controls.Add(this.btnAddRewardDelete);
            this.Controls.Add(this.lbTitleAddReward);
            this.Controls.Add(this.cbAddReward);
            this.Controls.Add(this.btnCancelAddReward);
            this.Controls.Add(this.btnOkAddReward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fAddReward";
            this.Text = "AddReward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkAddReward;
        private System.Windows.Forms.Button btnCancelAddReward;
        private System.Windows.Forms.ComboBox cbAddReward;
        private System.Windows.Forms.Label lbTitleAddReward;
        private System.Windows.Forms.Button btnAddRewardDelete;
    }
}