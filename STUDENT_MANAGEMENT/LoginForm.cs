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
    public partial class LoginForm : Form
    {
        //FOR DRAGGING
        private bool dragging = false; //check if the mouse is in dragging state
        private Point dragCursorPoint; //save the current pos of the mouse
        private Point dragFormPoint;   //save the current pos of the form
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            hideEyePIC.Show();
            openEyePIC.Hide();
        }

        private void topPN_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true; //in dragging state
            dragCursorPoint = Cursor.Position; //update cursor pos
            dragFormPoint = this.Location; //update form pos
        }

        private void topPN_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                //calculate the displacement between init pos and current pos
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                //add the displacement into the location of the form
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void topPN_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void minimizePIC_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closePIC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forgetPasswordBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: User's ID\nPlease contact the admin via email:\nadmin01@hcmute.edu.vn", "FORGET PASSWORD?");
        }


        private void hideEyePIC_Click(object sender, EventArgs e)
        {
            hideEyePIC.Hide();
            openEyePIC.Show();
            passwordTB.UseSystemPasswordChar = false;
        }

        private void openEyePIC_Click(object sender, EventArgs e)
        {
            hideEyePIC.Show();
            openEyePIC.Hide();
            passwordTB.UseSystemPasswordChar = true;
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string password = passwordTB.Text;

            if (username[0] != 'A' && username[0] != 'S' && username[0] != 'L')
            {
                MessageBox.Show("Invalid ID or Username", "ERROR"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both ID and Password!", "ERROR"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool loginSuccess = Modify.CheckLogin(username, password);
                    if (loginSuccess)
                    {
                        MessageBox.Show("Login Successful!", "SUCCESS!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        MainForm mainForm = new MainForm(username, Modify.CheckRole(username));
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong ID or password!", "ERROR!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex, "ERROR"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
