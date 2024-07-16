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

namespace EmployeeClock
{
    public partial class LoginForm : ReaLTaiizor.Forms.MaterialForm
    {

        DBContext dbContext;
        public LoginForm(DBContext DB)
        {
            InitializeComponent();
            dbContext = DB;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHandler.CloseAllForms();
            FormHandler.ShowForms<string>("PasswordChangeForm", dbContext);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string ID = textBoxID.Text;
            string password = textBox_password.Text;
            if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("your input not valid");
            }
            else if (!ID.All(char.IsDigit))
            {
                MessageBox.Show("your input not valid");
            }
            else
            {
                try
                {
                    string query = @$"select e.ID,e.EmployeeNat from Passwords p 
                                                            join Employees e 
                                                            on P.EmployeeID = e.ID 
                                                            where e.EmployeeNat = @ID
                                                            AND p.EmployeePassword = @Password";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ID", SqlDbType.Int) { Value = ID },
                        new SqlParameter("@Password", SqlDbType.VarChar) { Value = password }
                    };
                    var result = dbContext.MakeQuery(query, parameters);
                    if (result.Rows.Count > 0)
                    {
                        FormHandler.CloseAllForms();
                        FormHandler.ShowForms<string>("ClockForm", dbContext, result.Rows[0]["ID"].ToString());
                    }
                    else
                    {
                        throw new Exception("the id or password not exsist");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
