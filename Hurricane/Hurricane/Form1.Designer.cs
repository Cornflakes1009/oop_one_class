﻿namespace Hurricane
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.windSpeedInput = new System.Windows.Forms.TextBox();
            this.speedCalculatedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the wind speed of the hurricane. ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "calculate hurricane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // windSpeedInput
            // 
            this.windSpeedInput.Location = new System.Drawing.Point(96, 67);
            this.windSpeedInput.Name = "windSpeedInput";
            this.windSpeedInput.Size = new System.Drawing.Size(100, 20);
            this.windSpeedInput.TabIndex = 2;
            // 
            // speedCalculatedLabel
            // 
            this.speedCalculatedLabel.AutoSize = true;
            this.speedCalculatedLabel.Location = new System.Drawing.Point(96, 123);
            this.speedCalculatedLabel.Name = "speedCalculatedLabel";
            this.speedCalculatedLabel.Size = new System.Drawing.Size(0, 13);
            this.speedCalculatedLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speedCalculatedLabel);
            this.Controls.Add(this.windSpeedInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox windSpeedInput;
        private System.Windows.Forms.Label speedCalculatedLabel;
    }
}

