using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeClock
{
    public partial class PasswordChangeForm : ReaLTaiizor.Forms.MaterialForm
    {
        DBContext dbContext;
        public PasswordChangeForm(DBContext DB)
        {
            InitializeComponent();
            dbContext = DB;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.CloseAllForms();
            FormHandler.ShowForms<string>("LoginForm", dbContext);
        }

        private void button_confirm_new_password_Click(object sender, EventArgs e)
        {
            string EmployeeNat = textBoxId.Text;
            string oldPassword = textBox_old_password.Text.Trim();
            string newPassword = textBox_new_password.Text.Trim();
            string confirmNewPassword = textBox_confirm_new_password.Text.Trim();
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword)
                || string.IsNullOrEmpty(EmployeeNat) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("you not fill all fields");
            }
            else if (!oldPassword.All(char.IsDigit) || !EmployeeNat.All(char.IsDigit) ||
                !newPassword.All(char.IsDigit) || !confirmNewPassword.All(char.IsDigit))
            {
                MessageBox.Show("your input not valid");
            }
            else if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("your input not valid");
            }
            else
            {
                string query = "select e.ID from Passwords p join Employees e on P.EmployeeID = e.ID where e.EmployeeNat = @EmployeeNat AND p.EmployeePassword = @oldPassword";
                SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@oldPassword", SqlDbType.Int) { Value = oldPassword },
                        new SqlParameter("@EmployeeNat", SqlDbType.VarChar) { Value = EmployeeNat }
                    };
                var ID = dbContext.MakeQuery(query, parameters);

                if (ID.Rows.Count > 0)
                {
                    string query1 = $"UPDATE Passwords SET EmployeePassword = @NewPassword WHERE EmployeeID = @ID2";
                    string ID2 = ID.Rows[0]["ID"].ToString();
                    SqlParameter[] parameters1 = new SqlParameter[]
                    {
                        new SqlParameter("@ID2", SqlDbType.Int) { Value = ID2 },
                        new SqlParameter("@NewPassword", SqlDbType.VarChar) { Value = newPassword }
                    };
                    dbContext.ExecuteNonQuery(query1, parameters1);
                    MessageBox.Show("your password changed successfully");

                }
                else
                {
                    MessageBox.Show("your old password or ID not correct");
                }

            }


        }

        private void textBox_confirm_new_password_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
