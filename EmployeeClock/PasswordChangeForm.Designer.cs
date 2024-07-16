namespace EmployeeClock
{
    partial class PasswordChangeForm
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
            components = new System.ComponentModel.Container();
            button_confirm_new_password = new Button();
            labelID = new Label();
            textBoxId = new TextBox();
            label_old_password = new Label();
            label_new_password = new Label();
            label_confirm_password = new Label();
            textBox_new_password = new TextBox();
            textBox_old_password = new TextBox();
            textBox_confirm_new_password = new TextBox();
            linkLabel_cancel = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // button_confirm_new_password
            // 
            button_confirm_new_password.BackColor = Color.FromArgb(255, 255, 128);
            button_confirm_new_password.Location = new Point(444, 366);
            button_confirm_new_password.Name = "button_confirm_new_password";
            button_confirm_new_password.Size = new Size(94, 29);
            button_confirm_new_password.TabIndex = 0;
            button_confirm_new_password.Text = "confirm";
            button_confirm_new_password.UseVisualStyleBackColor = false;
            button_confirm_new_password.Click += button_confirm_new_password_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(647, 116);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 20);
            labelID.TabIndex = 1;
            labelID.Text = "ID";
            labelID.Click += label1_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(453, 116);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 2;
            // 
            // label_old_password
            // 
            label_old_password.AutoSize = true;
            label_old_password.Location = new Point(620, 173);
            label_old_password.Name = "label_old_password";
            label_old_password.Size = new Size(95, 20);
            label_old_password.TabIndex = 3;
            label_old_password.Text = "old passeord";
            label_old_password.Click += label2_Click;
            // 
            // label_new_password
            // 
            label_new_password.AutoSize = true;
            label_new_password.Location = new Point(620, 242);
            label_new_password.Name = "label_new_password";
            label_new_password.Size = new Size(103, 20);
            label_new_password.TabIndex = 4;
            label_new_password.Text = "new password";
            label_new_password.Click += label3_Click;
            // 
            // label_confirm_password
            // 
            label_confirm_password.AutoSize = true;
            label_confirm_password.Location = new Point(620, 300);
            label_confirm_password.Name = "label_confirm_password";
            label_confirm_password.Size = new Size(127, 20);
            label_confirm_password.TabIndex = 5;
            label_confirm_password.Text = "confirm password";
            // 
            // textBox_new_password
            // 
            textBox_new_password.BackColor = Color.FromArgb(255, 255, 192);
            textBox_new_password.Location = new Point(453, 221);
            textBox_new_password.Name = "textBox_new_password";
            textBox_new_password.Size = new Size(125, 27);
            textBox_new_password.TabIndex = 6;
            // 
            // textBox_old_password
            // 
            textBox_old_password.Location = new Point(444, 170);
            textBox_old_password.Name = "textBox_old_password";
            textBox_old_password.Size = new Size(125, 27);
            textBox_old_password.TabIndex = 7;
            textBox_old_password.TextChanged += textBox3_TextChanged;
            // 
            // textBox_confirm_new_password
            // 
            textBox_confirm_new_password.BackColor = Color.FromArgb(255, 255, 192);
            textBox_confirm_new_password.Location = new Point(453, 293);
            textBox_confirm_new_password.Name = "textBox_confirm_new_password";
            textBox_confirm_new_password.Size = new Size(125, 27);
            textBox_confirm_new_password.TabIndex = 8;
            textBox_confirm_new_password.TextChanged += textBox_confirm_new_password_TextChanged;
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Location = new Point(620, 376);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(51, 20);
            linkLabel_cancel.TabIndex = 9;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "cancel";
            linkLabel_cancel.LinkClicked += linkLabel_cancel_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel_cancel);
            Controls.Add(textBox_confirm_new_password);
            Controls.Add(textBox_old_password);
            Controls.Add(textBox_new_password);
            Controls.Add(label_confirm_password);
            Controls.Add(label_new_password);
            Controls.Add(label_old_password);
            Controls.Add(textBoxId);
            Controls.Add(labelID);
            Controls.Add(button_confirm_new_password);
            Name = "PasswordChangeForm";
            Text = "PasswordChangeForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_confirm_new_password;
        private Label labelID;
        private TextBox textBoxId;
        private Label label_old_password;
        private Label label_new_password;
        private Label label_confirm_password;
        private TextBox textBox_new_password;
        private TextBox textBox_old_password;
        private TextBox textBox_confirm_new_password;
        private LinkLabel linkLabel_cancel;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}