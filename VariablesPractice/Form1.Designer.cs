namespace VariablesPractice
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
            this.HockeyB = new System.Windows.Forms.Button();
            this.AreaB = new System.Windows.Forms.Button();
            this.CarpetB = new System.Windows.Forms.Button();
            this.BillB = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HockeyB
            // 
            this.HockeyB.Location = new System.Drawing.Point(30, 46);
            this.HockeyB.Name = "HockeyB";
            this.HockeyB.Size = new System.Drawing.Size(83, 32);
            this.HockeyB.TabIndex = 2;
            this.HockeyB.Text = "Hockey";
            this.HockeyB.UseVisualStyleBackColor = true;
            this.HockeyB.Click += new System.EventHandler(this.HockeyB_Click);
            // 
            // AreaB
            // 
            this.AreaB.Location = new System.Drawing.Point(30, 107);
            this.AreaB.Name = "AreaB";
            this.AreaB.Size = new System.Drawing.Size(83, 32);
            this.AreaB.TabIndex = 3;
            this.AreaB.Text = "Area";
            this.AreaB.UseVisualStyleBackColor = true;
            this.AreaB.Click += new System.EventHandler(this.AreaB_Click);
            // 
            // CarpetB
            // 
            this.CarpetB.Location = new System.Drawing.Point(30, 172);
            this.CarpetB.Name = "CarpetB";
            this.CarpetB.Size = new System.Drawing.Size(83, 32);
            this.CarpetB.TabIndex = 4;
            this.CarpetB.Text = "Carpet";
            this.CarpetB.UseVisualStyleBackColor = true;
            this.CarpetB.Click += new System.EventHandler(this.CarpetB_Click);
            // 
            // BillB
            // 
            this.BillB.Location = new System.Drawing.Point(30, 241);
            this.BillB.Name = "BillB";
            this.BillB.Size = new System.Drawing.Size(83, 32);
            this.BillB.TabIndex = 5;
            this.BillB.Text = "Bill";
            this.BillB.UseVisualStyleBackColor = true;
            this.BillB.Click += new System.EventHandler(this.BillB_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Black;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(146, 46);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(398, 232);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Welcome...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 334);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.BillB);
            this.Controls.Add(this.CarpetB);
            this.Controls.Add(this.AreaB);
            this.Controls.Add(this.HockeyB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HockeyB;
        private System.Windows.Forms.Button AreaB;
        private System.Windows.Forms.Button CarpetB;
        private System.Windows.Forms.Button BillB;
        private System.Windows.Forms.Label outputLabel;
    }
}

