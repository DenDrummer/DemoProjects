using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MainMenuFormsApp
{
    partial class MainMenuForm
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
            this.APMButton = new System.Windows.Forms.Button();
            this.AsyncForms1Button = new System.Windows.Forms.Button();
            this.AsyncFruitCountingButton = new System.Windows.Forms.Button();
            this.EAPButton = new System.Windows.Forms.Button();
            this.FakeConsoleAppButton = new System.Windows.Forms.Button();
            this.LocksButton = new System.Windows.Forms.Button();
            this.ParallelCodeButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.FCNAAButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // APMButton
            // 
            this.APMButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.APMButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.APMButton.Location = new System.Drawing.Point(12, 12);
            this.APMButton.Name = "APMButton";
            this.APMButton.Size = new System.Drawing.Size(218, 32);
            this.APMButton.TabIndex = 0;
            this.APMButton.Text = "&1 - APM";
            this.APMButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.APMButton.UseVisualStyleBackColor = true;
            this.APMButton.Click += new System.EventHandler(this.APMButton_Click);
            // 
            // AsyncForms1Button
            // 
            this.AsyncForms1Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsyncForms1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsyncForms1Button.Enabled = false;
            this.AsyncForms1Button.Location = new System.Drawing.Point(12, 50);
            this.AsyncForms1Button.Name = "AsyncForms1Button";
            this.AsyncForms1Button.Size = new System.Drawing.Size(218, 32);
            this.AsyncForms1Button.TabIndex = 1;
            this.AsyncForms1Button.Text = "&2 - AsyncForms1";
            this.AsyncForms1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AsyncForms1Button.UseVisualStyleBackColor = true;
            this.AsyncForms1Button.Click += new System.EventHandler(this.AsyncForms1Button_Click);
            // 
            // AsyncFruitCountingButton
            // 
            this.AsyncFruitCountingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsyncFruitCountingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsyncFruitCountingButton.Location = new System.Drawing.Point(12, 88);
            this.AsyncFruitCountingButton.Name = "AsyncFruitCountingButton";
            this.AsyncFruitCountingButton.Size = new System.Drawing.Size(218, 32);
            this.AsyncFruitCountingButton.TabIndex = 2;
            this.AsyncFruitCountingButton.Text = "&3 - AsyncFruitCounting";
            this.AsyncFruitCountingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AsyncFruitCountingButton.UseVisualStyleBackColor = true;
            this.AsyncFruitCountingButton.Click += new System.EventHandler(this.AsyncFruitCountingButton_Click);
            // 
            // EAPButton
            // 
            this.EAPButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EAPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EAPButton.Location = new System.Drawing.Point(12, 126);
            this.EAPButton.Name = "EAPButton";
            this.EAPButton.Size = new System.Drawing.Size(218, 32);
            this.EAPButton.TabIndex = 3;
            this.EAPButton.Text = "&4 - EAP";
            this.EAPButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EAPButton.UseVisualStyleBackColor = true;
            this.EAPButton.Click += new System.EventHandler(this.EAPButton_Click);
            // 
            // FakeConsoleAppButton
            // 
            this.FakeConsoleAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FakeConsoleAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FakeConsoleAppButton.Location = new System.Drawing.Point(12, 164);
            this.FakeConsoleAppButton.Name = "FakeConsoleAppButton";
            this.FakeConsoleAppButton.Size = new System.Drawing.Size(218, 32);
            this.FakeConsoleAppButton.TabIndex = 4;
            this.FakeConsoleAppButton.Text = "&5 - FakeConsoleApp";
            this.FakeConsoleAppButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FakeConsoleAppButton.UseVisualStyleBackColor = true;
            this.FakeConsoleAppButton.Click += new System.EventHandler(this.FakeConsoleAppButton_Click);
            // 
            // LocksButton
            // 
            this.LocksButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocksButton.Location = new System.Drawing.Point(12, 202);
            this.LocksButton.Name = "LocksButton";
            this.LocksButton.Size = new System.Drawing.Size(218, 32);
            this.LocksButton.TabIndex = 5;
            this.LocksButton.Text = "&6 - Locks";
            this.LocksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocksButton.UseVisualStyleBackColor = true;
            this.LocksButton.Click += new System.EventHandler(this.LocksButton_Click);
            // 
            // ParallelCodeButton
            // 
            this.ParallelCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParallelCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParallelCodeButton.Location = new System.Drawing.Point(12, 240);
            this.ParallelCodeButton.Name = "ParallelCodeButton";
            this.ParallelCodeButton.Size = new System.Drawing.Size(218, 32);
            this.ParallelCodeButton.TabIndex = 6;
            this.ParallelCodeButton.Text = "&7 - ParallelCode";
            this.ParallelCodeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParallelCodeButton.UseVisualStyleBackColor = true;
            this.ParallelCodeButton.Click += new System.EventHandler(this.ParallelCodeButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Location = new System.Drawing.Point(12, 327);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(218, 32);
            this.QuitButton.TabIndex = 8;
            this.QuitButton.Text = "&Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FCNAAButton
            // 
            this.FCNAAButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FCNAAButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FCNAAButton.Location = new System.Drawing.Point(12, 278);
            this.FCNAAButton.Name = "FCNAAButton";
            this.FCNAAButton.Size = new System.Drawing.Size(218, 32);
            this.FCNAAButton.TabIndex = 7;
            this.FCNAAButton.Text = "&8 - FakeConsoleNonAsyncApp";
            this.FCNAAButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FCNAAButton.UseVisualStyleBackColor = true;
            this.FCNAAButton.Click += new System.EventHandler(this.FCNAAButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 371);
            this.ControlBox = false;
            this.Controls.Add(this.FCNAAButton);
            this.Controls.Add(this.AsyncForms1Button);
            this.Controls.Add(this.AsyncFruitCountingButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ParallelCodeButton);
            this.Controls.Add(this.LocksButton);
            this.Controls.Add(this.EAPButton);
            this.Controls.Add(this.FakeConsoleAppButton);
            this.Controls.Add(this.APMButton);
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button APMButton;
        private Button AsyncForms1Button;
        private Button AsyncFruitCountingButton;
        private Button EAPButton;
        private Button FakeConsoleAppButton;
        private Button LocksButton;
        private Button ParallelCodeButton;
        private Button QuitButton;
        private Button FCNAAButton;
    }
}

