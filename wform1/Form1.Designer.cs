namespace wform1
{
    partial class Home_Screen
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
            this.login_label = new System.Windows.Forms.Label();
            this.User_Name_TextBox = new System.Windows.Forms.RichTextBox();
            this.Password_TextBox = new System.Windows.Forms.RichTextBox();
            this.User_Name_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(400, 22);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(106, 37);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Log In";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_Name_TextBox
            // 
            this.User_Name_TextBox.Location = new System.Drawing.Point(391, 120);
            this.User_Name_TextBox.Name = "User_Name_TextBox";
            this.User_Name_TextBox.Size = new System.Drawing.Size(188, 24);
            this.User_Name_TextBox.TabIndex = 2;
            this.User_Name_TextBox.Text = "";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(391, 182);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(189, 24);
            this.Password_TextBox.TabIndex = 3;
            this.Password_TextBox.Text = "";
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            // 
            // User_Name_Label
            // 
            this.User_Name_Label.AutoSize = true;
            this.User_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_Label.Location = new System.Drawing.Point(249, 120);
            this.User_Name_Label.Name = "User_Name_Label";
            this.User_Name_Label.Size = new System.Drawing.Size(100, 24);
            this.User_Name_Label.TabIndex = 4;
            this.User_Name_Label.Text = "UserName";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.Location = new System.Drawing.Point(249, 182);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(92, 24);
            this.Password_Label.TabIndex = 5;
            this.Password_Label.Text = "Password";
            // 
            // login_Button
            // 
            this.login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button.Location = new System.Drawing.Point(374, 241);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(62, 29);
            this.login_Button.TabIndex = 9;
            this.login_Button.Text = "login";
            this.login_Button.UseVisualStyleBackColor = true;
            // 
            // Home_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 484);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.User_Name_Label);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.User_Name_TextBox);
            this.Controls.Add(this.login_label);
            this.Name = "Home_Screen";
            this.Text = "Home Screen";
            this.Click += new System.EventHandler(this.Home_Screen_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.RichTextBox User_Name_TextBox;
        private System.Windows.Forms.RichTextBox Password_TextBox;
        private System.Windows.Forms.Label User_Name_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button login_Button;
    }
}

