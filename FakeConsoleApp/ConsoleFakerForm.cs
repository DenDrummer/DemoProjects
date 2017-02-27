using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.FakeConsoleApp
{
    public partial class ConsoleFakerForm : Form
    {
        private bool updateTime = false;
        private int delayedMessages = 0;
        private bool closeApp = false;
        private string inputString = null;
        public ConsoleFakerForm()
        {
            InitializeComponent();
            Program();
        }

        private async void Program()
        {
            await AppendLine(LogBox, "Welcome");
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

        private async void SendMsgButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SendMsgTextBox.Text))
            {
                Task timeTask = Task.FromResult(0);
                Task lineTask;
                inputString = SendMsgTextBox.Text;
                SendMsgTextBox.Text = "";
                switch (inputString.ToLower().Split(' ')[0])
                {
                    #region delayed ##
                    case "delayed":
                        delayedMessages++;
                        int seconds;
                        if (inputString.Split(' ').Length > 1)
                        {
                            int.TryParse(inputString.Split(' ')[1], out seconds);
                            if (inputString.Split(' ').Length > 2)
                            {
                                StringBuilder msg = new StringBuilder();
                                for (int i = 2; i < inputString.Split(' ').Length; i++)
                                {
                                    msg.Append(inputString.Split(' ')[i]);
                                    if (i != inputString.Split(' ').Length -1)
                                    {
                                        msg.Append(' ');
                                    }
                                }
                                lineTask = DelayedMsg(LogBox, seconds, msg.ToString());
                            }
                            else
                            {
                                lineTask = DelayedMsg(LogBox, seconds, null);
                            }
                        }
                        else
                        {
                            lineTask = DelayedMsg(LogBox, 10, null);
                        }
                        delayedMessages--;
                        break;
                    #endregion
                    #region quit
                    case "quit":
                        lineTask = AppendLine(LogBox, "Goodbye!");
                        timeTask = Task.Run(() => Thread.Sleep(10 * 1000));
                        closeApp = true;
                        SendMsgTextBox.Enabled = false;
                        SendMsgButton.Enabled = false;
                        break;
                    #endregion
                    #region start
                    case "start":
                        lineTask = AppendLine(LogBox, inputString);
                        updateTime = true;
                        timeTask = UpdateTime();
                        break;
                    #endregion
                    #region stop
                    case "stop":
                        lineTask = AppendLine(LogBox, inputString);
                        updateTime = false;
                        break;
                    #endregion
                    #region default
                    default:
                        lineTask = AppendLine(LogBox, inputString);
                        break;
                    #endregion
                }
                await Task.WhenAll(lineTask, timeTask);
                if (closeApp)
                {
                    //wait on delayed messages

                    Application.Exit();
                }
            }
        }

        private static Task AppendLine(TextBox textBox, string text)
        {
            return Task.Run(() =>
            {
                if (textBox.Text.Length == 0)
                {
                    textBox.Text = text;
                }
                else
                {
                    textBox.Invoke(new Action(() => textBox.AppendText($"\r\n{text}")));
                }
            });
        }

        private static Task DelayedMsg(TextBox textBox, int seconds, string msg)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(seconds * 1000);
                AppendLine(textBox, $"This message was requested {seconds} seconds ago{(string.IsNullOrEmpty(msg) ? "" : $": {msg}")}");
            });
        }
    }
}
