using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.FakeConsoleNonAsyncApp
{
    public partial class ConsoleFakerForm : Form
    {
        private bool updateTime = false;
        private int backgroundTasks = 0;
        private bool closeApp = false;
        private bool closing = false;
        private string inputString = null;
        public ConsoleFakerForm()
        {
            InitializeComponent();
            SetListeners();
            Program();
        }

        private void SetListeners()
        {
            SendMsgTextBox.KeyUp += new KeyEventHandler(TextBoxKeyUp);
        }

        private void Program()
        {
            AppendLine(LogBox, "Welcome ( ° v°)b");
            AppendLine(LogBox, "This project has been built with Task");
            AppendLine(LogBox, "Type \"commands\" for a list of commands");
        }

        private void ConsoleFakerForm_Load(object sender, EventArgs e)
        {
            updateTime = true;
            UpdateTime();
        }

        private Task UpdateTime()
        {
            return Task.Run(() =>
            {
                while (updateTime)
                {
                    TimeLabel.Invoke(new Action(() => TimeLabel.Text = DateTime.Now.ToString()));
                }
            });
        }

        private void SendMsgButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SendMsgTextBox.Text))
            {
                inputString = SendMsgTextBox.Text;
                SendMsgTextBox.Text = "";
                switch (inputString.ToLower().Split(' ')[0])
                {
                    #region commands
                    case "commands":
                        AppendLine(LogBox, "• commands");
                        Thread.Sleep(500);
                        AppendLine(LogBox, "• countfruit");
                        Thread.Sleep(500);
                        AppendLine(LogBox, "• delayed [delay in seconds] [message]");
                        Thread.Sleep(500);
                        AppendLine(LogBox, "• quit");
                        Thread.Sleep(500);
                        AppendLine(LogBox, "• rickroll");
                        Thread.Sleep(500);
                        AppendLine(LogBox, "• start");
                        Thread.Sleep(500);
                        AppendLine(LogBox, "• stop");
                        Thread.Sleep(500);
                        break;
                    #endregion
                    #region countfruit
                    case "countfruit":
                        CountFruit();
                        break;
                    #endregion
                    #region delayed <int time> <string msg>
                    case "delayed":
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
                                    if (i != inputString.Split(' ').Length - 1)
                                    {
                                        msg.Append(' ');
                                    }
                                }
                                DelayedMsg(this, seconds, msg.ToString());
                            }
                            else
                            {
                                DelayedMsg(this, seconds, null);
                            }
                        }
                        else
                        {
                            DelayedMsg(this, 10, null);
                        }
                        break;
                    #endregion
                    #region quit
                    case "quit":
                        AppendLine(LogBox, "Au revoir!");
                        closeApp = true;
                        SendMsgTextBox.Enabled = false;
                        SendMsgButton.Enabled = false;
                        break;
                    #endregion
                    #region rickroll
                    case "rickroll":
                        RickRoll();
                        break;
                    #endregion
                    #region start
                    case "start":
                        if (!updateTime)
                        {
                            AppendLine(LogBox, "Clock is now running");
                            updateTime = true;
                            UpdateTime();
                        }
                        else
                        {
                            AppendLine(LogBox, "Clock is already running");
                        }
                        break;
                    #endregion
                    #region stop
                    case "stop":
                        if (updateTime)
                        {
                            AppendLine(LogBox, "Clock is no longer running");
                            updateTime = false;
                        }
                        else
                        {
                            AppendLine(LogBox, "Clock isn't running");
                        }
                        break;
                    #endregion
                    #region default
                    default:
                        AppendLine(LogBox, inputString);
                        break;
                        #endregion
                }
                if (closeApp && !closing)
                {
                    closing = true;
                    if (backgroundTasks > 0)
                    {
                        AppendLine(LogBox, "Waiting on delayed messages...");
                    }
                    while (backgroundTasks > 0) { /*wait until there are no delayed messages left*/ }
                    //doesn't make much of a difference wether it's awaited or not
                    AppendLine(LogBox, "(The app will now close in about 10 seconds)");
                    Thread.Sleep(10 * 1000);
                    updateTime = false;
                    Thread.Sleep(100);
                    Application.Exit();
                }
            }
        }

        private void CountFruit()
        {
            backgroundTasks++;
            int apples = 200;
            int pears = 175;
            CountApplesAsync(LogBox, apples);
            CountPearsAsync(LogBox, pears);
            AppendLine(LogBox, $"You should have {apples} apple{(apples == 1 ? "" : "s")} and {pears} pear{(pears == 1 ? "" : "s")}");
            backgroundTasks--;
        }

        private static void CountApplesAsync(TextBox textBox, int appleCount)
        {
            for (int i = 1; i <= appleCount; i++)
            {
                AppendLine(textBox, $"{i} apple{(i == 1 ? "" : "s")}");
                Thread.Sleep(10);
            }
            AppendLine(textBox, $"All apples have been counted. You have {appleCount} apple{(appleCount == 1 ? "" : "s")}");

        }

        private static void CountPearsAsync(TextBox textBox, int pearCount)
        {
            for (int i = 1; i <= pearCount; i++)
            {
                AppendLine(textBox, $"{i} pear{(i == 1 ? "" : "s")}");
                Thread.Sleep(10);
            }
            AppendLine(textBox, $"All pears have been counted. You have {pearCount} pear{(pearCount == 1 ? "" : "s")}");
        }

        private void RickRoll()
        {
            AppendLine(LogBox, "Never gonna give you up!");
            Thread.Sleep(1000);
            AppendLine(LogBox, "Never gonna let you down!");
            Thread.Sleep(1000);
            AppendLine(LogBox, "Never gonna run around");
            Thread.Sleep(1000);
            AppendLine(LogBox, "and desert you!");
            Thread.Sleep(1000);
            AppendLine(LogBox, "Never gonna make you cry!");
            Thread.Sleep(1000);
            AppendLine(LogBox, "Never gonna say goodbye!");
            Thread.Sleep(1000);
            AppendLine(LogBox, "Never gonna tell a lie");
            Thread.Sleep(1000);
            AppendLine(LogBox, "and hurt you!");
            Thread.Sleep(1000);
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=dQw4w9WgXcQ"));
        }

        private static void AppendLine(TextBox textBox, string text)
        {
            if (textBox.Text.Length == 0)
            {
                textBox.Text = text;
            }
            else
            {
                textBox.AppendText($"\r\n{text}");
            }
        }

        private static void DelayedMsg(ConsoleFakerForm ctx, int seconds, string msg)
        {
            ctx.backgroundTasks++;
            Thread.Sleep(seconds * 1000);
            AppendLine(ctx.LogBox, $"This message was requested {seconds} seconds ago{(string.IsNullOrEmpty(msg) ? "" : $": {msg}")}");
            ctx.backgroundTasks--;
        }
    }
}
