namespace Demo.FakeConsoleApp
{
    partial class ConsoleFakerForm
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
            this.SendMsgButton = new System.Windows.Forms.Button();
            this.SendMsgTextBox = new System.Windows.Forms.TextBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.Location = new System.Drawing.Point(221, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(149, 17);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "20/02/2017 10:12:0";
            // 
            // SendMsgButton
            // 
            this.SendMsgButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendMsgButton.Location = new System.Drawing.Point(295, 167);
            this.SendMsgButton.Name = "SendMsgButton";
            this.SendMsgButton.Size = new System.Drawing.Size(75, 22);
            this.SendMsgButton.TabIndex = 2;
            this.SendMsgButton.Text = "Send";
            this.SendMsgButton.UseVisualStyleBackColor = true;
            this.SendMsgButton.Click += new System.EventHandler(this.SendMsgButton_Click);
            // 
            // SendMsgTextBox
            // 
            this.SendMsgTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendMsgTextBox.Location = new System.Drawing.Point(12, 167);
            this.SendMsgTextBox.Name = "SendMsgTextBox";
            this.SendMsgTextBox.Size = new System.Drawing.Size(277, 22);
            this.SendMsgTextBox.TabIndex = 3;
            this.SendMsgTextBox.TabStop = false;
            // 
            // LogBox
            // 
            this.LogBox.AcceptsReturn = true;
            this.LogBox.AcceptsTab = true;
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogBox.Location = new System.Drawing.Point(12, 29);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(358, 132);
            this.LogBox.TabIndex = 5;
            this.LogBox.TabStop = false;
            // 
            // ConsoleFakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 201);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.SendMsgTextBox);
            this.Controls.Add(this.SendMsgButton);
            this.Controls.Add(this.TimeLabel);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "ConsoleFakerForm";
            this.Text = "Console Faker";
            this.Load += new System.EventHandler(this.ConsoleFakerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button SendMsgButton;
        private System.Windows.Forms.TextBox SendMsgTextBox;
        private System.Windows.Forms.TextBox LogBox;
    }
}

