using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();


            //Date & Time 

            labelDatum.Text = DateTime.Now.ToShortDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblUhrzeit.Text = DateTime.Now.ToString("T");
        }
    }
}
