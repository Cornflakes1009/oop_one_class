namespace ResortPrices
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
            this.label2 = new System.Windows.Forms.Label();
            this.nightsInput = new System.Windows.Forms.TextBox();
            this.calculateNights = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Carefree Resort!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "How many nights will you be staying with us? ";
            // 
            // nightsInput
            // 
            this.nightsInput.Location = new System.Drawing.Point(76, 112);
            this.nightsInput.Name = "nightsInput";
            this.nightsInput.Size = new System.Drawing.Size(100, 20);
            this.nightsInput.TabIndex = 2;
            // 
            // calculateNights
            // 
            this.calculateNights.Location = new System.Drawing.Point(76, 139);
            this.calculateNights.Name = "calculateNights";
            this.calculateNights.Size = new System.Drawing.Size(100, 23);
            this.calculateNights.TabIndex = 3;
            this.calculateNights.Text = "Calculate Cost";
            this.calculateNights.UseVisualStyleBackColor = true;
            this.calculateNights.Click += new System.EventHandler(this.calculateNights_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(76, 214);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateNights);
            this.Controls.Add(this.nightsInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nightsInput;
        private System.Windows.Forms.Button calculateNights;
        private System.Windows.Forms.Label outputLabel;
    }
}

