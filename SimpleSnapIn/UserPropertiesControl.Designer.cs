namespace SimpleSnapIn
{
    partial class UserPropertiesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Birthday = new System.Windows.Forms.TextBox();
            this.BirthdayPrompt = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserNamePrompt = new System.Windows.Forms.Label();
            this.UserInfo = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(119, 75);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(136, 20);
            this.Birthday.TabIndex = 13;
            // 
            // BirthdayPrompt
            // 
            this.BirthdayPrompt.Location = new System.Drawing.Point(39, 75);
            this.BirthdayPrompt.Name = "BirthdayPrompt";
            this.BirthdayPrompt.Size = new System.Drawing.Size(72, 23);
            this.BirthdayPrompt.TabIndex = 12;
            this.BirthdayPrompt.Text = "Birthday";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(119, 43);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(136, 20);
            this.UserName.TabIndex = 11;
            // 
            // UserNamePrompt
            // 
            this.UserNamePrompt.Location = new System.Drawing.Point(39, 43);
            this.UserNamePrompt.Name = "UserNamePrompt";
            this.UserNamePrompt.Size = new System.Drawing.Size(72, 23);
            this.UserNamePrompt.TabIndex = 10;
            this.UserNamePrompt.Text = "Name";
            // 
            // UserInfo
            // 
            this.UserInfo.Location = new System.Drawing.Point(15, 19);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(264, 100);
            this.UserInfo.TabIndex = 14;
            this.UserInfo.TabStop = false;
            this.UserInfo.Text = "User";
            // 
            // UserPropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.BirthdayPrompt);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserNamePrompt);
            this.Controls.Add(this.UserInfo);
            this.Name = "UserPropertiesControl";
            this.Size = new System.Drawing.Size(293, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Birthday;
        private System.Windows.Forms.Label BirthdayPrompt;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label UserNamePrompt;
        private System.Windows.Forms.GroupBox UserInfo;
    }
}
