﻿namespace MainMenuFormsApp
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
            this.APMButton = new System.Windows.Forms.Button();
            this.AsyncForms1Button = new System.Windows.Forms.Button();
            this.AsyncFruitCountingButton = new System.Windows.Forms.Button();
            this.EAPButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // APMButton
            // 
            this.APMButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.APMButton.Location = new System.Drawing.Point(12, 12);
            this.APMButton.Name = "APMButton";
            this.APMButton.Size = new System.Drawing.Size(178, 32);
            this.APMButton.TabIndex = 0;
            this.APMButton.Text = "&1 - APM";
            this.APMButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.APMButton.UseVisualStyleBackColor = true;
            // 
            // AsyncForms1Button
            // 
            this.AsyncForms1Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsyncForms1Button.Location = new System.Drawing.Point(12, 50);
            this.AsyncForms1Button.Name = "AsyncForms1Button";
            this.AsyncForms1Button.Size = new System.Drawing.Size(178, 32);
            this.AsyncForms1Button.TabIndex = 0;
            this.AsyncForms1Button.Text = "&2 - AsyncForms1";
            this.AsyncForms1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AsyncForms1Button.UseVisualStyleBackColor = true;
            // 
            // AsyncFruitCountingButton
            // 
            this.AsyncFruitCountingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsyncFruitCountingButton.Location = new System.Drawing.Point(12, 88);
            this.AsyncFruitCountingButton.Name = "AsyncFruitCountingButton";
            this.AsyncFruitCountingButton.Size = new System.Drawing.Size(178, 32);
            this.AsyncFruitCountingButton.TabIndex = 0;
            this.AsyncFruitCountingButton.Text = "&3 - AsyncFruitCounting";
            this.AsyncFruitCountingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AsyncFruitCountingButton.UseVisualStyleBackColor = true;
            // 
            // EAPButton
            // 
            this.EAPButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EAPButton.Location = new System.Drawing.Point(12, 126);
            this.EAPButton.Name = "EAPButton";
            this.EAPButton.Size = new System.Drawing.Size(178, 32);
            this.EAPButton.TabIndex = 0;
            this.EAPButton.Text = "&4 - EAP";
            this.EAPButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EAPButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 251);
            this.Controls.Add(this.AsyncForms1Button);
            this.Controls.Add(this.AsyncFruitCountingButton);
            this.Controls.Add(this.EAPButton);
            this.Controls.Add(this.APMButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button APMButton;
        private System.Windows.Forms.Button AsyncForms1Button;
        private System.Windows.Forms.Button AsyncFruitCountingButton;
        private System.Windows.Forms.Button EAPButton;
    }
}
