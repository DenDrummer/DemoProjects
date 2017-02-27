using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.FakeConsoleApp
{
    public partial class ConsoleFakerForm : Form
    {
        private StringBuilder text = new StringBuilder();
        private bool updateTime = false;
        private bool continueApp = true;
        private string inputString = null;
        public ConsoleFakerForm()
        {
            InitializeComponent();
            Program();
        }

        private async void Program()
        {
            text.Append("Welcome!");
            TextLabel.Text = text.ToString();
        }

        private void ConsoleFakerForm_Load(object sender, EventArgs e)
        {
        }

        private Task UpdateTime()
        {
            //while (updateTime)
            //{
            //    TimeLabel.Text = DateTime.Now.ToString();
            //}
            return Task.Run(() =>
            {
                while (updateTime)
                {
                    TimeLabel.Invoke(new Action(() => TimeLabel.Text = DateTime.Now.ToString()));
                }
            });
        }

        private void SetTime()
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }

        private async void SendMsgButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SendMsgTextBox.Text))
            {

                if (SendMsgTextBox.Text.Equals("quit"))
                {
                    inputString = SendMsgTextBox.Text;
                    SendMsgTextBox.Text = "";
                    TextLabel.Text = text.Append("\n" + inputString).ToString();
                    updateTime = false;
                    
                }
                else if (SendMsgTextBox.Text.Equals("start"))
                {
                    inputString = SendMsgTextBox.Text;
                    SendMsgTextBox.Text = "";
                    TextLabel.Text = text.Append("\n" + inputString).ToString();
                    updateTime = true;
                    Task timeTask = UpdateTime();                    
                    await Task.WhenAll(timeTask);
                }
                else
                {
                    inputString = SendMsgTextBox.Text;
                    SendMsgTextBox.Text = "";                    
                    TextLabel.Text = text.Append("\n" + inputString).ToString();
                }
            }
        }
    }
}
