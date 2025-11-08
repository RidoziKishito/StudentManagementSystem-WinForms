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
    public partial class EditTuitionUC : UserControl
    {
        Modify modify;
        MainForm mainForm;
        public EditTuitionUC()
        {
            InitializeComponent();
        }
        public EditTuitionUC(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }


        private void EditTuitionUC_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            tuitionDGV.DataSource = modify.GetAllTuition();
        }

        private void idTB_Enter(object sender, EventArgs e)
        {
            if (idTB.Text == "Student ID")
            {
                idTB.Text = "";
                idTB.ForeColor = Color.Black;
            }
        }

        private void idTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTB.Text))
            {
                idTB.Text = "Student ID";
                idTB.ForeColor = Color.Silver;
            }
        }

        private void amountTB_Enter(object sender, EventArgs e)
        {
            if (amountTB.Text == "Amount")
            {
                amountTB.Text = "";
                amountTB.ForeColor = Color.Black;
            }
        }

        private void amountTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amountTB.Text))
            {
                amountTB.Text = "Amount";
                amountTB.ForeColor = Color.Silver;
            }
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idTB.Text;
                decimal amount = Convert.ToDecimal(amountTB.Text);
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("ID is Empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    modify = new Modify();
                    modify.UpdateTuition(id, amount);
                    tuitionDGV.DataSource = modify.GetAllTuition();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
