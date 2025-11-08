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
    public partial class StudentTuitionUC : UserControl
    {
        Student s;
        Modify modify;
        MainForm mainForm;
        public StudentTuitionUC()
        {
            InitializeComponent();
        }

        public StudentTuitionUC(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }
        private void StudentTuitionUC_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            s = modify.GetStudentByID(mainForm.Username);
            if (s != null)
            {
                amountLB.Text = Convert.ToString(s.Fee.Amount);
                if (!s.Fee.IsPaid)
                {
                    amountLeftLB.Text = Convert.ToString(s.Fee.Amount);
                    amountLeftLB.ForeColor = Color.DarkOrange;
                }
                else
                {
                    amountLeftLB.Text = "Paid successful!";
                    amountLeftLB.ForeColor = Color.DarkGreen;
                }
            }
        }
        private void payBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!s.Fee.IsPaid)
                {
                    string amount = amountTB.Text;
                    if (!string.IsNullOrEmpty(amount))
                    {
                        try
                        {
                            if (Convert.ToDecimal(amount) < 0) throw new Exception("Negative amount of money!");
                            s.Fee.pay(Convert.ToDecimal(amount));
                            modify.TuitionChange(s);
                            if (!s.Fee.IsPaid)
                            {
                                amountLeftLB.Text = Convert.ToString(s.Fee.Amount);
                                amountLeftLB.ForeColor = Color.DarkOrange;
                            }
                            else
                            {
                                amountLeftLB.Text = "Paid successful!";
                                amountLeftLB.ForeColor = Color.DarkGreen;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have paid successfully!!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void amountTB_Enter(object sender, EventArgs e)
        {
            if (amountTB.Text == "Amount (USD)")
            {
                amountTB.Text = "";
                amountTB.ForeColor = Color.Black;
            }
        }
        private void amountTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amountTB.Text))
            {
                amountTB.Text = "Amount (USD)";
                amountTB.ForeColor = Color.Silver;
            }
        }

    }
}
