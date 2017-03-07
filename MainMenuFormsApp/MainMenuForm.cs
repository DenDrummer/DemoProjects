using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MainMenuFormsApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void APMButton_Click(object sender, EventArgs e)
        {
            APM.Program p = new APM.Program();
            Process.Start(p.ReturnPath() + "\\APM.exe");
        }

        private void AsyncForms1Button_Click(object sender, EventArgs e)
        {
            Demo.AsyncForms1.Program p = new Demo.AsyncForms1.Program();
            Process.Start(p.ReturnPath() + "\\Demo.AsyncForms1.exe");
        }

        private void AsyncFruitCountingButton_Click(object sender, EventArgs e)
        {
            Demo.AsyncFruitCounting.Program p = new Demo.AsyncFruitCounting.Program();
            Process.Start(p.ReturnPath() + "\\Demo.AsyncFruitCounting.exe");
        }

        private void EAPButton_Click(object sender, EventArgs e)
        {
            EAP.Program p = new EAP.Program();
            Process.Start(p.ReturnPath() + "\\EAP.exe");
        }

        private void FakeConsoleAppButton_Click(object sender, EventArgs e)
        {
            Demo.FakeConsoleApp.Program p = new Demo.FakeConsoleApp.Program();
            Process.Start(p.ReturnPath() + "\\Demo.FakeConsoleApp.exe");
        }

        private void LocksButton_Click(object sender, EventArgs e)
        {
            Locks.Program p = new Locks.Program();
            Process.Start(p.ReturnPath() + "\\Locks.exe");
        }

        private void ParallelCodeButton_Click(object sender, EventArgs e)
        {
            ParallelCode.ParallelMain p = new ParallelCode.ParallelMain();
            Process.Start(p.ReturnPath() + "\\Parallel.exe");
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
