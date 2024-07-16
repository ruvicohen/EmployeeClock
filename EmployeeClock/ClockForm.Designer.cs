namespace EmployeeClock
{
    partial class ClockForm
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
            label_workerID = new Label();
            button_exit = new Button();
            linkLabel_cancel = new LinkLabel();
            button_Enterance = new Button();
            label_last_exit = new Label();
            label_last_entrance = new Label();
            label1 = new Label();
            label_entrance_last = new Label();
            label_time_exit = new Label();
            SuspendLayout();
            // 
            // label_workerID
            // 
            label_workerID.AutoSize = true;
            label_workerID.Location = new Point(162, 145);
            label_workerID.Name = "label_workerID";
            label_workerID.Size = new Size(76, 20);
            label_workerID.TabIndex = 0;
            label_workerID.Text = "worker ID:";
            label_workerID.Click += label_workerID_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Red;
            button_exit.Location = new Point(162, 346);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 1;
            button_exit.Text = "Exit shift";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Location = new Point(346, 290);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(51, 20);
            linkLabel_cancel.TabIndex = 2;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "cancel";
            linkLabel_cancel.LinkClicked += linkLabel_cancel_LinkClicked;
            // 
            // button_Enterance
            // 
            button_Enterance.BackColor = Color.Lime;
            button_Enterance.Location = new Point(500, 346);
            button_Enterance.Name = "button_Enterance";
            button_Enterance.Size = new Size(94, 29);
            button_Enterance.TabIndex = 3;
            button_Enterance.Text = "Entering the shift";
            button_Enterance.UseVisualStyleBackColor = false;
            button_Enterance.Click += button_login_Click;
            // 
            // label_last_exit
            // 
            label_last_exit.AutoSize = true;
            label_last_exit.Location = new Point(162, 225);
            label_last_exit.Name = "label_last_exit";
            label_last_exit.Size = new Size(63, 20);
            label_last_exit.TabIndex = 4;
            label_last_exit.Text = "last exit:";
            label_last_exit.Click += label_last_exit_Click;
            // 
            // label_last_entrance
            // 
            label_last_entrance.AutoSize = true;
            label_last_entrance.Location = new Point(149, 182);
            label_last_entrance.Name = "label_last_entrance";
            label_last_entrance.Size = new Size(96, 20);
            label_last_entrance.TabIndex = 5;
            label_last_entrance.Text = "last entrance:";
            label_last_entrance.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 145);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label_entrance_last
            // 
            label_entrance_last.AutoSize = true;
            label_entrance_last.Location = new Point(272, 182);
            label_entrance_last.Name = "label_entrance_last";
            label_entrance_last.Size = new Size(141, 20);
            label_entrance_last.TabIndex = 7;
            label_entrance_last.Text = "label_time_entrance";
            label_entrance_last.Click += label2_Click;
            // 
            // label_time_exit
            // 
            label_time_exit.AutoSize = true;
            label_time_exit.Location = new Point(272, 225);
            label_time_exit.Name = "label_time_exit";
            label_time_exit.Size = new Size(99, 20);
            label_time_exit.TabIndex = 8;
            label_time_exit.Text = "labelTimeExit";
            label_time_exit.Click += label_time_exit_Click;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_time_exit);
            Controls.Add(label_entrance_last);
            Controls.Add(label1);
            Controls.Add(label_last_entrance);
            Controls.Add(label_last_exit);
            Controls.Add(button_Enterance);
            Controls.Add(linkLabel_cancel);
            Controls.Add(button_exit);
            Controls.Add(label_workerID);
            Name = "ClockForm";
            Text = "ClockForm";
            Load += ClockForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_workerID;
        private Button button_exit;
        private LinkLabel linkLabel_cancel;
        private Button button_Enterance;
        private Label label_last_exit;
        private Label label_last_entrance;
        private Label label1;
        private Label label_entrance_last;
        private Label label_time_exit;
    }
}