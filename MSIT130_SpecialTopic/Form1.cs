using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT130_SpecialTopic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmWorkouts frmWorkouts = new FrmWorkouts();
            frmWorkouts.TopLevel = false;
            frmWorkouts.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frmWorkouts);
            frmWorkouts.Show();

        }
    }
}
