﻿using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.FakeConsoleApp
{
    public partial class ConsoleFakerForm : Form
    {
        private bool updateTime = false;
        private int backgroundTasks = 0;
        private bool closeApp = false;
        private bool closing = false;
        private string inputString = null;
        private static readonly Task completedTask = Task.FromResult(0);
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

        private async void Program()
        {
            await AppendLine(LogBox, "Welcome ( ° v°)b");
            await AppendLine(LogBox, "This project has been built with TAP");
            await AppendLine(LogBox, "(Task-based Asynchronous Pattern)");
            await AppendLine(LogBox, "Type \"commands\" for a list of commands");
        }

        private void ConsoleFakerForm_Load(object sender, EventArgs e)
        {
            updateTime = true;
            UpdateTime();
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
                Task timeTask = completedTask;
                Task lineTask;
                inputString = SendMsgTextBox.Text;
                SendMsgTextBox.Text = "";
                switch (inputString.ToLower().Split(' ')[0])
                {
                    #region commands
                    case "commands":
                        lineTask = Task.Run(async () =>
                        {
                            await AppendLine(LogBox, "• commands");
                            Thread.Sleep(500);
                            await AppendLine(LogBox, "• countfruit");
                            Thread.Sleep(500);
                            await AppendLine(LogBox, "• delayed [delay in seconds] [message]");
                            Thread.Sleep(500);
                            await AppendLine(LogBox, "• quit");
                            Thread.Sleep(500);
                            await AppendLine(LogBox, "• rickroll");
                            Thread.Sleep(500);
                            await AppendLine(LogBox, "• start");
                            Thread.Sleep(500);
                            await AppendLine(LogBox, "• stop");
                            Thread.Sleep(500);
                        });
                        break;
                    #endregion
                    #region countfruit
                    case "countfruit":
                        lineTask = CountFruit();
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
                                lineTask = DelayedMsg(this, seconds, msg.ToString());
                            }
                            else
                            {
                                lineTask = DelayedMsg(this, seconds, null);
                            }
                        }
                        else
                        {
                            lineTask = DelayedMsg(this, 10, null);
                        }
                        break;
                    #endregion
                    #region quit
                    case "quit":
                        lineTask = AppendLine(LogBox, "Au revoir!");
                        closeApp = true;
                        SendMsgTextBox.Enabled = false;
                        SendMsgButton.Enabled = false;
                        break;
                    #endregion
                    #region rickroll
                    case "rickroll":
                        lineTask = RickRoll();
                        break;
                    #endregion
                    #region start
                    case "start":
                        if (!updateTime)
                        {
                            lineTask = AppendLine(LogBox, "Clock is now running");
                            updateTime = true;
                            timeTask = UpdateTime();
                        }
                        else
                        {
                            lineTask = AppendLine(LogBox, "Clock is already running");
                        }
                        break;
                    #endregion
                    #region stop
                    case "stop":
                        if (updateTime)
                        {
                            lineTask = AppendLine(LogBox, "Clock is no longer running");
                            updateTime = false;
                        }
                        else
                        {
                            lineTask = AppendLine(LogBox, "Clock isn't running");
                        }
                        break;
                    #endregion
                    #region default
                    default:
                        lineTask = AppendLine(LogBox, inputString);
                        break;
                        #endregion
                }
                await Task.WhenAll(lineTask, timeTask);
                if (closeApp && !closing)
                {
                    closing = true;
                    if (backgroundTasks > 0)
                    {
                        AppendLine(LogBox, "Waiting on delayed messages...");
                    }
                    await Task.Run(() =>
                    {
                        while (backgroundTasks > 0) { /*wait until there are no delayed messages left*/ }
                    });
                    //doesn't make much of a difference wether it's awaited or not
                    AppendLine(LogBox, "(The app will now close in about 10 seconds)");
                    await Task.Run(() => Thread.Sleep(10 * 1000));
                    updateTime = false;
                    await Task.Run(() => Thread.Sleep(100));
                    Application.Exit();
                }
            }
        }

        private Task CountFruit()
        {
            return Task.Run(async () =>
            {
                backgroundTasks++;
                int apples = 200;
                int pears = 175;
                Task appleTask = CountApplesAsync(LogBox, apples);
                Task pearTask = CountPearsAsync(LogBox, pears);
                await Task.WhenAll(appleTask, pearTask);
                await AppendLine(LogBox, $"You should have {apples} apple{(apples == 1 ? "" : "s")} and {pears} pear{(pears == 1 ? "" : "s")}");
                backgroundTasks--;
            });
        }

        private static Task CountApplesAsync(TextBox textBox, int appleCount)
        {
            return Task.Run(async () =>
            {
                for (int i = 1; i <= appleCount; i++)
                {
                    await AppendLine(textBox, $"{i} apple{(i == 1 ? "" : "s")}");
                    Thread.Sleep(10);
                }
                await AppendLine(textBox, $"All apples have been counted. You have {appleCount} apple{(appleCount == 1 ? "" : "s")}");
            });
        }

        private static Task CountPearsAsync(TextBox textBox, int pearCount)
        {
            return Task.Run(async () =>
            {
                for (int i = 1; i <= pearCount; i++)
                {
                    await AppendLine(textBox, $"{i} pear{(i == 1 ? "" : "s")}");
                    Thread.Sleep(10);
                }
                await AppendLine(textBox, $"All pears have been counted. You have {pearCount} pear{(pearCount == 1 ? "" : "s")}");
            });
        }

        private Task RickRoll()
        {
            //this has to be async so it doesn't run in the same thread
            return Task.Run(async () =>
            {
                await AppendLine(LogBox, "Never gonna give you up!");
                Thread.Sleep(1000);
                await AppendLine(LogBox, "Never gonna let you down!");
                Thread.Sleep(1000);
                await AppendLine(LogBox, "Never gonna run around");
                Thread.Sleep(1000);
                await AppendLine(LogBox, "and desert you!");
                Thread.Sleep(1000);
                await AppendLine(LogBox, "Never gonna make you cry!");
                Thread.Sleep(1000);
                await AppendLine(LogBox, "Never gonna say goodbye!");
                Thread.Sleep(1000);
                await AppendLine(LogBox, "Never gonna tell a lie");
                Thread.Sleep(1000);
                await AppendLine(LogBox, "and hurt you!");
                Thread.Sleep(1000);
                Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=dQw4w9WgXcQ"));
            });
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

        private static Task DelayedMsg(ConsoleFakerForm ctx, int seconds, string msg)
        {
            return Task.Run(() =>
            {
                ctx.backgroundTasks++;
                Thread.Sleep(seconds * 1000);
                AppendLine(ctx.LogBox, $"This message was requested {seconds} seconds ago{(string.IsNullOrEmpty(msg) ? "" : $": {msg}")}");
                ctx.backgroundTasks--;
            });
        }
    }
}
