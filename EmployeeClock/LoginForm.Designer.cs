namespace EmployeeClock
{
    partial class LoginForm
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
            button_change_password = new Button();
            labelPassword = new Label();
            textBox_password = new TextBox();
            textBoxID = new TextBox();
            labelID = new Label();
            button_login = new Button();
            SuspendLayout();
            // 
            // button_change_password
            // 
            button_change_password.Location = new Point(366, 338);
            button_change_password.Name = "button_change_password";
            button_change_password.Size = new Size(94, 29);
            button_change_password.TabIndex = 0;
            button_change_password.Text = "change_password";
            button_change_password.UseVisualStyleBackColor = true;
            button_change_password.Click += button1_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(383, 188);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(72, 20);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "password";
            labelPassword.Click += label1_Click;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(350, 224);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(125, 27);
            textBox_password.TabIndex = 2;
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(350, 158);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 3;
            textBoxID.TextChanged += textBox2_TextChanged;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(408, 122);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 20);
            labelID.TabIndex = 4;
            labelID.Text = "ID";
            // 
            // button_login
            // 
            button_login.Location = new Point(366, 271);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login);
            Controls.Add(labelID);
            Controls.Add(textBox_password);
            Controls.Add(labelPassword);
            Controls.Add(button_change_password);
            Controls.Add(textBoxID);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_change_password;
        private Label labelPassword;
        private TextBox textBox_password;
        private TextBox textBoxID;
        private Label labelID;
        private Button button_login;
    }
}