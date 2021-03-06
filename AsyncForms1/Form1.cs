﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.AsyncForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            doClock();
        }

        private void doClock()
        {
            //while(this != null)
            //{
            TimeLabel.Text = DateTime.Now.ToString();
            //}
        }

        private async void DoStuffButton_Click(object sender, EventArgs e)
        {
            DoStuffButton.Enabled = false;
            CancellationTokenSource cancelToken = new CancellationTokenSource();
            await FinishProgressBar(cancelToken); ;
            StuffProgressBar.Value = 0;
            DoStuffButton.Enabled = true;
        }

        private Task FinishProgressBar(CancellationTokenSource cancelToken)
        {
            return Task.Run(() =>
            {
                for (int i = StuffProgressBar.Value; i <= StuffProgressBar.Maximum / StuffProgressBar.Step; i++)
                {
                    StuffProgressBar.PerformStep();
                }
            });
        }

        private void updateTimeButton_Click(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }
    }
}
