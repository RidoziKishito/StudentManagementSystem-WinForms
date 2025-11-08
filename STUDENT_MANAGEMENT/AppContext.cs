using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_MS
{
    public class AppContext : ApplicationContext
    {
        public AppContext()
        {
            ShowLoginForm();
        }

        public void ShowLoginForm()
        {
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        public void ShowMainForm()
        {
            var mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
