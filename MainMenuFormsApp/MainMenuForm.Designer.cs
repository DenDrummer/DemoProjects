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
            APMButton = new Button();
            AsyncForms1Button = new Button();
            AsyncFruitCountingButton = new Button();
            EAPButton = new Button();
            FakeConsoleAppButton = new Button();
            LocksButton = new Button();
            ParallelCodeButton = new Button();
            QuitButton = new Button();
            SuspendLayout();
            // 
            // APMButton
            // 
            APMButton.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            APMButton.Cursor = Cursors.Hand;
            APMButton.Location = new Point(12, 12);
            APMButton.Name = "APMButton";
            APMButton.Size = new Size(178, 32);
            APMButton.TabIndex = 0;
            APMButton.Text = "&1 - APM";
            APMButton.TextAlign = ContentAlignment.MiddleLeft;
            APMButton.UseVisualStyleBackColor = true;
            APMButton.Click += new EventHandler(APMButton_Click);
            // 
            // AsyncForms1Button
            // 
            AsyncForms1Button.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            AsyncForms1Button.Cursor = Cursors.Hand;
            AsyncForms1Button.Location = new Point(12, 50);
            AsyncForms1Button.Name = "AsyncForms1Button";
            AsyncForms1Button.Size = new Size(178, 32);
            AsyncForms1Button.TabIndex = 1;
            AsyncForms1Button.Text = "&2 - AsyncForms1";
            AsyncForms1Button.TextAlign = ContentAlignment.MiddleLeft;
            AsyncForms1Button.UseVisualStyleBackColor = true;
            AsyncForms1Button.Click += new EventHandler(AsyncForms1Button_Click);
            // 
            // AsyncFruitCountingButton
            // 
            AsyncFruitCountingButton.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            AsyncFruitCountingButton.Cursor = Cursors.Hand;
            AsyncFruitCountingButton.Location = new Point(12, 88);
            AsyncFruitCountingButton.Name = "AsyncFruitCountingButton";
            AsyncFruitCountingButton.Size = new Size(178, 32);
            AsyncFruitCountingButton.TabIndex = 2;
            AsyncFruitCountingButton.Text = "&3 - AsyncFruitCounting";
            AsyncFruitCountingButton.TextAlign = ContentAlignment.MiddleLeft;
            AsyncFruitCountingButton.UseVisualStyleBackColor = true;
            AsyncFruitCountingButton.Click += new EventHandler(AsyncFruitCountingButton_Click);
            // 
            // EAPButton
            // 
            EAPButton.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            EAPButton.Cursor = Cursors.Hand;
            EAPButton.Location = new Point(12, 126);
            EAPButton.Name = "EAPButton";
            EAPButton.Size = new Size(178, 32);
            EAPButton.TabIndex = 3;
            EAPButton.Text = "&4 - EAP";
            EAPButton.TextAlign = ContentAlignment.MiddleLeft;
            EAPButton.UseVisualStyleBackColor = true;
            EAPButton.Click += new EventHandler(EAPButton_Click);
            // 
            // FakeConsoleAppButton
            // 
            FakeConsoleAppButton.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            FakeConsoleAppButton.Cursor = Cursors.Hand;
            FakeConsoleAppButton.Location = new Point(12, 164);
            FakeConsoleAppButton.Name = "FakeConsoleAppButton";
            FakeConsoleAppButton.Size = new Size(178, 32);
            FakeConsoleAppButton.TabIndex = 4;
            FakeConsoleAppButton.Text = "&5 - FakeConsoleApp";
            FakeConsoleAppButton.TextAlign = ContentAlignment.MiddleLeft;
            FakeConsoleAppButton.UseVisualStyleBackColor = true;
            FakeConsoleAppButton.Click += new EventHandler(FakeConsoleAppButton_Click);
            // 
            // LocksButton
            // 
            LocksButton.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            LocksButton.Cursor = Cursors.Hand;
            LocksButton.Location = new Point(12, 202);
            LocksButton.Name = "LocksButton";
            LocksButton.Size = new Size(178, 32);
            LocksButton.TabIndex = 5;
            LocksButton.Text = "&6 - Locks";
            LocksButton.TextAlign = ContentAlignment.MiddleLeft;
            LocksButton.UseVisualStyleBackColor = true;
            LocksButton.Click += new EventHandler(LocksButton_Click);
            // 
            // ParallelCodeButton
            // 
            ParallelCodeButton.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            ParallelCodeButton.Cursor = Cursors.Hand;
            ParallelCodeButton.Location = new Point(12, 240);
            ParallelCodeButton.Name = "ParallelCodeButton";
            ParallelCodeButton.Size = new Size(178, 32);
            ParallelCodeButton.TabIndex = 6;
            ParallelCodeButton.Text = "&7 - ParallelCode";
            ParallelCodeButton.TextAlign = ContentAlignment.MiddleLeft;
            ParallelCodeButton.UseVisualStyleBackColor = true;
            ParallelCodeButton.Click += new EventHandler(ParallelCodeButton_Click);
            // 
            // QuitButton
            // 
            QuitButton.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            QuitButton.Cursor = Cursors.Hand;
            QuitButton.Location = new Point(12, 287);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(178, 32);
            QuitButton.TabIndex = 7;
            QuitButton.Text = "&Quit";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += new EventHandler(QuitButton_Click);
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 331);
            ControlBox = false;
            Controls.Add(AsyncForms1Button);
            Controls.Add(AsyncFruitCountingButton);
            Controls.Add(QuitButton);
            Controls.Add(ParallelCodeButton);
            Controls.Add(LocksButton);
            Controls.Add(EAPButton);
            Controls.Add(FakeConsoleAppButton);
            Controls.Add(APMButton);
            MinimumSize = new Size(220, 380);
            Name = "MainMenuForm";
            ShowIcon = false;
            Text = "Main Menu";
            ResumeLayout(false);

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
    }
}

