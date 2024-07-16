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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EmployeeClock
{
    public partial class ClockForm : ReaLTaiizor.Forms.MaterialForm
    {
        LoginForm loginForm;
        PasswordChangeForm passwordClock;
        DBContext dBContext;
        string EmployeeID;
        public ClockForm(DBContext DB, string ID)
        {
            InitializeComponent();
            dBContext = DB;
            EmployeeID = ID;
            EntryTime(EmployeeID);
            ExitTime(EmployeeID);
            label1.Text = EmployeeID;

            //DataTable entryTime = dBContext.GetEmployeeEntryTime(int.Parse(EmployeeID));
            //label_last_entrance.Text = entryTime.Rows[0]["EntryTime"].ToString();


        }

        private void EntryTime(string EmployeeID)
        {
            if (EmployeeID != DBNull.Value.ToString())
            {
                string query = $"SELECT top(1) * FROM EmployeeAttendance WHERE EmployeeCode = @EmployeeID order by EntryTime desc";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = EmployeeID }
                };
                DataTable entryTime = dBContext.MakeQuery(query, parameters);
                label_entrance_last.Text = entryTime.Rows[0]["EntryTime"].ToString();
                ExitTime(EmployeeID);
            }
        }

        private void ExitTime(string EmployeeID)
        {
            if (EmployeeID != DBNull.Value.ToString())
            {
                string query = "SELECT top(1) * FROM EmployeeAttendance WHERE EmployeeCode = @EmployeeID order by EntryTime desc";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = EmployeeID }
                };
                DataTable entryTime = dBContext.MakeQuery(query, parameters);
                if (entryTime.Rows[0]["ExitTime"].ToString() != "")
                {
                    label_time_exit.Text = entryTime.Rows[0]["ExitTime"].ToString();
                }
                else
                {
                    label_time_exit.Text = "You are at work";
                }
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string query1 = $"SELECT top(1) * FROM EmployeeAttendance WHERE EmployeeCode = {EmployeeID} order by EntryTime desc";
            SqlParameter[] parameters1 = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = EmployeeID }
                };
            DataTable entryTime = dBContext.MakeQuery(query1, parameters1);
            if (entryTime.Rows[0]["ExitTime"].ToString() != "")
            {
                string query = "INSERT INTO EmployeeAttendance (EmployeeCode, EntryTime) VALUES (@EmployeeID, @EntryTime)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = EmployeeID },
                    new SqlParameter("@EntryTime", SqlDbType.DateTime) { Value = DateTime.Now }
                };

                bool isQuery = dBContext.ExecuteNonQuery(query, parameters);
                if (isQuery)
                {
                    MessageBox.Show("Your login time has been updated");
                    EntryTime(EmployeeID);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("You dont do exit");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_last_exit_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.CloseAllForms();
            FormHandler.ShowForms<string>("LoginForm", dBContext);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            string query = "SELECT top(1) * FROM EmployeeAttendance WHERE EmployeeCode = @EmployeeID order by EntryTime desc";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = EmployeeID }
            };
            DataTable entryTime = dBContext.MakeQuery(query, parameters);
            if (entryTime.Rows[0]["ExitTime"].ToString() == "")
            {
                string query2 = "update EmployeeAttendance set ExitTime = @ExitTime where EntryTime = (SELECT top(1) EntryTime FROM EmployeeAttendance WHERE EmployeeCode = @EmployeeID order by EntryTime desc)";
                SqlParameter[] parameters2 = new SqlParameter[]
                {
                    new SqlParameter ("@ExitTime", SqlDbType.DateTime) {Value = DateTime.Now },
                    new SqlParameter ("@EmployeeID", SqlDbType.Int) {Value = EmployeeID }


                };
                bool isQuery = dBContext.ExecuteNonQuery(query2, parameters2);
                if (isQuery)
                {
                    MessageBox.Show("Your Exit time has been updated");
                    ExitTime(EmployeeID);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("You have not logged in");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_time_exit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClockForm_Load(object sender, EventArgs e)
        {

        }

        private void label_workerID_Click(object sender, EventArgs e)
        {

        }
    }
}
