using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class Form2gaming : Form
    {
        private Process myprocess = new Process();
        
        public Form2gaming()
        {
            InitializeComponent();
        }

        private void StartProjectIgnis_Click(object sender, EventArgs e)
        {

            LunchApp("C:\\Riot Games\\League of Legends\\LeagueClient.exe");




        }

        private void LunchApp(string filename)
        {
            myprocess.StartInfo.FileName = filename;
            myprocess.Start();
            myprocess.WaitForExit();
        }
    }
}
