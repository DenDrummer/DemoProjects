using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuFormsApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private /*async*/ void APMButton_Click(object sender, EventArgs e)
        {
            APM.Program p = /*await Task.Run(() => { return*/ new APM.Program(); /*});*/
            Process.Start(p.ReturnPath() + "\\APM.exe");
        }

        private void AsyncForms1Button_Click(object sender, EventArgs e)
        {

        }

        private void AsyncFruitCountingButton_Click(object sender, EventArgs e)
        {

        }

        private void EAPButton_Click(object sender, EventArgs e)
        {

        }

        private void FakeConsoleAppButton_Click(object sender, EventArgs e)
        {

        }

        private void LocksButton_Click(object sender, EventArgs e)
        {

        }

        private void ParallelCodeButton_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
