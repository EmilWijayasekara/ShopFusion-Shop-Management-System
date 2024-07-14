namespace ShopFusion___Shop_Management_System
{
    partial class FormLogin
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
            this.label_welcomeText = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcomeText
            // 
            this.label_welcomeText.AutoSize = true;
            this.label_welcomeText.Location = new System.Drawing.Point(57, 41);
            this.label_welcomeText.Name = "label_welcomeText";
            this.label_welcomeText.Size = new System.Drawing.Size(154, 16);
            this.label_welcomeText.TabIndex = 0;
            this.label_welcomeText.Text = "Welcome to ShopFusion";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(57, 89);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(70, 16);
            this.label_userName.TabIndex = 1;
            this.label_userName.Text = "Username";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(60, 121);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(100, 22);
            this.textBox_userName.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(60, 198);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 22);
            this.textBox_password.TabIndex = 4;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(57, 166);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(67, 16);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(60, 239);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.label_welcomeText);
            this.Name = "FormLogin";
            this.Text = "ShopFusion Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcomeText;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
    }
}