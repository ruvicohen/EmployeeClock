using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock
{
    internal static class FormHandler
    {

        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
                item.Close();
            }
        }
        public static void ShowForms<T>(string formName, DBContext DB, string ID = null)
        {
            CloseAllForms();
            Form form = formName switch
            {
                "LoginForm" => new LoginForm(DB),
                "ClockForm" => new ClockForm(DB, ID),
                "PasswordChangeForm" => new PasswordChangeForm(DB),
                _ => throw new ArgumentException("invalid form name.", nameof(formName)),
            };
            form.Show();
        }

            
        
    }
}
