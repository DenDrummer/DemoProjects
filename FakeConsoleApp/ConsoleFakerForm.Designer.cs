using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Demo.FakeConsoleApp
{
    partial class ConsoleFakerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TimeLabel = new Label();
            SendMsgButton = new Button();
            SendMsgTextBox = new TextBox();
            LogBox = new TextBox();
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TimeLabel.Location = new Point(221, 9);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(149, 17);
            TimeLabel.TabIndex = 2;
            TimeLabel.Text = "20/02/2017 10:12:0";
            // 
            // SendMsgButton
            // 
            SendMsgButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            SendMsgButton.Cursor = Cursors.Hand;
            SendMsgButton.Location = new Point(295, 167);
            SendMsgButton.Name = "SendMsgButton";
            SendMsgButton.Size = new Size(75, 22);
            SendMsgButton.TabIndex = 1;
            SendMsgButton.Text = "Send";
            SendMsgButton.UseVisualStyleBackColor = true;
            SendMsgButton.Click += new EventHandler(SendMsgButton_Click);
            // 
            // SendMsgTextBox
            // 
            SendMsgTextBox.Anchor = ((AnchorStyles.Bottom | AnchorStyles.Left) | AnchorStyles.Right);
            SendMsgTextBox.Location = new Point(12, 167);
            SendMsgTextBox.Name = "SendMsgTextBox";
            SendMsgTextBox.Size = new Size(277, 22);
            SendMsgTextBox.TabIndex = 0;
            // 
            // LogBox
            // 
            LogBox.AcceptsReturn = true;
            LogBox.AcceptsTab = true;
            LogBox.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right);
            LogBox.BorderStyle = BorderStyle.None;
            LogBox.Cursor = Cursors.Default;
            LogBox.Location = new Point(12, 29);
            LogBox.Multiline = true;
            LogBox.Name = "LogBox";
            LogBox.ReadOnly = true;
            LogBox.ScrollBars = ScrollBars.Vertical;
            LogBox.Size = new Size(358, 132);
            LogBox.TabIndex = 0;
            LogBox.TabStop = false;
            // 
            // ConsoleFakerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 201);
            ControlBox = false;
            Controls.Add(LogBox);
            Controls.Add(SendMsgTextBox);
            Controls.Add(SendMsgButton);
            Controls.Add(TimeLabel);
            MinimumSize = new Size(400, 250);
            Name = "ConsoleFakerForm";
            Text = "Console Faker";
            Load += new EventHandler(ConsoleFakerForm_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMsgButton.PerformClick();
                e.Handled = true;
            }
        }

        #endregion
        private Label TimeLabel;
        private Button SendMsgButton;
        private TextBox SendMsgTextBox;
        private TextBox LogBox;
    }
}

