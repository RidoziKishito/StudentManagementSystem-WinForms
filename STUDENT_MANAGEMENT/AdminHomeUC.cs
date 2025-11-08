using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_MS
{
    public partial class AdminHomeUC : UserControl
    {
        Modify modify;
        public AdminHomeUC()
        {
            InitializeComponent();
            modify = new Modify();
        }

        private void AdminHomeUC_Load(object sender, EventArgs e)
        {
            accountDGV.DataSource = modify.GetAllAccount();
        }

        private void addUsernameTB_Enter(object sender, EventArgs e)
        {
            if (addUsernameTB.Text == "Username")
            {
                addUsernameTB.Text = "";
                addUsernameTB.ForeColor = Color.Black;
            }
        }

        private void addUsernameTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addUsernameTB.Text))
            {
                addUsernameTB.Text = "Username";
                addUsernameTB.ForeColor = Color.Silver;
            }
        }

        private void addPasswordTB_Enter(object sender, EventArgs e)
        {
            if (addPasswordTB.Text == "Password")
            {
                addPasswordTB.Text = "";
                addPasswordTB.ForeColor = Color.Black;
            }
        }

        private void addPasswordTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addPasswordTB.Text))
            {
                addPasswordTB.Text = "Password";
                addPasswordTB.ForeColor = Color.Silver;
            }
        }

        private void removeUsernameTB_Enter(object sender, EventArgs e)
        {
            if (removeUsernameTB.Text == "Username to remove")
            {
                removeUsernameTB.Text = "";
                removeUsernameTB.ForeColor = Color.Black;
            }
        }

        private void removeUsernameTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(removeUsernameTB.Text))
            {
                removeUsernameTB.Text = "Username to remove";
                removeUsernameTB.ForeColor = Color.Silver;
            }
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            string username = addUsernameTB.Text;
            string password = addPasswordTB.Text;
            if (string.IsNullOrEmpty(username) || username == "Username" || string.IsNullOrEmpty(password) || password == "Password")
            {
                MessageBox.Show("Invalid Input!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    modify.AddAccount(username, password);
                    accountDGV.DataSource = modify.GetAllAccount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeBT_Click(object sender, EventArgs e)
        {
            string id = removeUsernameTB.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID is Empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    modify.RemoveAccount(id);
                    accountDGV.DataSource = modify.GetAllAccount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changeUsernameTB_Enter(object sender, EventArgs e)
        {
            if (changeUsernameTB.Text == "Username to change")
            {
                changeUsernameTB.Text = "";
                changeUsernameTB.ForeColor = Color.Black;
            }
        }

        private void changeUsernameTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(changeUsernameTB.Text))
            {
                changeUsernameTB.Text = "Username to change";
                changeUsernameTB.ForeColor = Color.Silver;
            }
        }

        private void newPasswordTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newPasswordTB.Text))
            {
                newPasswordTB.Text = "New Password";
                newPasswordTB.ForeColor = Color.Silver;
            }
        }

        private void newPasswordTB_Enter(object sender, EventArgs e)
        {
            if (newPasswordTB.Text == "New Password")
            {
                newPasswordTB.Text = "";
                newPasswordTB.ForeColor = Color.Black;
            }
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(changeUsernameTB.Text) || string.IsNullOrEmpty(newPasswordTB.Text))
                {
                    throw new Exception("Missing value!!");
                }
                string id = changeUsernameTB.Text;
                string pass = newPasswordTB.Text;
                modify.ChangePassword(id, pass);
                accountDGV.DataSource = modify.GetAllAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
