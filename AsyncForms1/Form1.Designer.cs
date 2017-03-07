using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Demo.AsyncForms1
{
    partial class Form1
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
            StuffProgressBar = new ProgressBar();
            DoStuffButton = new Button();
            updateTimeButton = new Button();
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(151, 17);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(132, 17);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "20/02/2017 10:12:0";
            TimeLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // StuffProgressBar
            // 
            StuffProgressBar.Anchor = ((AnchorStyles.Bottom | AnchorStyles.Left) | AnchorStyles.Right);
            StuffProgressBar.Location = new Point(12, 57);
            StuffProgressBar.Maximum = 10000000;
            StuffProgressBar.Name = "StuffProgressBar";
            StuffProgressBar.Size = new Size(190, 30);
            StuffProgressBar.Step = 1;
            StuffProgressBar.TabIndex = 1;
            // 
            // DoStuffButton
            // 
            DoStuffButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            DoStuffButton.Location = new Point(208, 57);
            DoStuffButton.Name = "DoStuffButton";
            DoStuffButton.Size = new Size(75, 30);
            DoStuffButton.TabIndex = 2;
            DoStuffButton.Text = "Do Stuff";
            DoStuffButton.UseVisualStyleBackColor = true;
            DoStuffButton.Click += new EventHandler(DoStuffButton_Click);
            // 
            // updateTimeButton
            // 
            updateTimeButton.Anchor = ((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right);
            updateTimeButton.Location = new Point(12, 12);
            updateTimeButton.Name = "updateTimeButton";
            updateTimeButton.Size = new Size(133, 27);
            updateTimeButton.TabIndex = 3;
            updateTimeButton.Text = "Update Time";
            updateTimeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 99);
            Controls.Add(updateTimeButton);
            Controls.Add(DoStuffButton);
            Controls.Add(StuffProgressBar);
            Controls.Add(TimeLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeLabel;
        private ProgressBar StuffProgressBar;
        private Button DoStuffButton;
        private Button updateTimeButton;
    }
}

