using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace STUDENT_MS
{
    public partial class LecturerHomeUC : UserControl
    {
        MainForm mainForm;
        public LecturerHomeUC()
        {
            InitializeComponent();
        }

        public LecturerHomeUC(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void LecturerHomeUC_Load(object sender, EventArgs e)
        {
            welcomeLB.Text = "Welcome " + Modify.GetName(mainForm.Username) + "!";
            informationLB.Text = "Information: \n" + Modify.PrintByID(mainForm.Username, 1);
        }
    }
}
