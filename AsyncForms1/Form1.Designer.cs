using System;

namespace AsyncForms1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StuffProgressBar = new System.Windows.Forms.ProgressBar();
            this.DoStuffButton = new System.Windows.Forms.Button();
            this.updateTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(151, 17);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(132, 17);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "20/02/2017 10:12:0";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StuffProgressBar
            // 
            this.StuffProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StuffProgressBar.Location = new System.Drawing.Point(12, 57);
            this.StuffProgressBar.Maximum = 10000000;
            this.StuffProgressBar.Name = "StuffProgressBar";
            this.StuffProgressBar.Size = new System.Drawing.Size(190, 30);
            this.StuffProgressBar.Step = 1;
            this.StuffProgressBar.TabIndex = 1;
            // 
            // DoStuffButton
            // 
            this.DoStuffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoStuffButton.Location = new System.Drawing.Point(208, 57);
            this.DoStuffButton.Name = "DoStuffButton";
            this.DoStuffButton.Size = new System.Drawing.Size(75, 30);
            this.DoStuffButton.TabIndex = 2;
            this.DoStuffButton.Text = "Do Stuff";
            this.DoStuffButton.UseVisualStyleBackColor = true;
            this.DoStuffButton.Click += new System.EventHandler(this.DoStuffButton_Click);
            // 
            // updateTimeButton
            // 
            this.updateTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateTimeButton.Location = new System.Drawing.Point(12, 12);
            this.updateTimeButton.Name = "updateTimeButton";
            this.updateTimeButton.Size = new System.Drawing.Size(133, 27);
            this.updateTimeButton.TabIndex = 3;
            this.updateTimeButton.Text = "Update Time";
            this.updateTimeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 99);
            this.Controls.Add(this.updateTimeButton);
            this.Controls.Add(this.DoStuffButton);
            this.Controls.Add(this.StuffProgressBar);
            this.Controls.Add(this.TimeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.ProgressBar StuffProgressBar;
        private System.Windows.Forms.Button DoStuffButton;
        private System.Windows.Forms.Button updateTimeButton;
    }
}

