namespace _3ShapeTestPalindromic_Prime
{
    partial class PalindromicPrime
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
            this.cmbNumberSystem = new System.Windows.Forms.ComboBox();
            this.lbNumberSystem = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMinValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNumberSystem
            // 
            this.cmbNumberSystem.FormattingEnabled = true;
            this.cmbNumberSystem.Items.AddRange(new object[] {
            "Binary",
            "Decimal"});
            this.cmbNumberSystem.Location = new System.Drawing.Point(135, 12);
            this.cmbNumberSystem.Name = "cmbNumberSystem";
            this.cmbNumberSystem.Size = new System.Drawing.Size(121, 21);
            this.cmbNumberSystem.TabIndex = 0;
            this.cmbNumberSystem.SelectedIndexChanged += new System.EventHandler(this.cmbNumberSystem_SelectedIndexChanged);
            // 
            // lbNumberSystem
            // 
            this.lbNumberSystem.AutoSize = true;
            this.lbNumberSystem.Location = new System.Drawing.Point(11, 15);
            this.lbNumberSystem.Name = "lbNumberSystem";
            this.lbNumberSystem.Size = new System.Drawing.Size(118, 13);
            this.lbNumberSystem.TabIndex = 1;
            this.lbNumberSystem.Text = "Choose Number system";
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(11, 70);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(322, 316);
            this.lbResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "In range";
            // 
            // nudMinValue
            // 
            this.nudMinValue.Location = new System.Drawing.Point(64, 37);
            this.nudMinValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMinValue.Name = "nudMinValue";
            this.nudMinValue.Size = new System.Drawing.Size(70, 20);
            this.nudMinValue.TabIndex = 4;
            this.nudMinValue.ThousandsSeparator = true;
            this.nudMinValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.Location = new System.Drawing.Point(164, 37);
            this.nudMaxValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(65, 20);
            this.nudMaxValue.TabIndex = 6;
            this.nudMaxValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // PalindromicPrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 396);
            this.Controls.Add(this.nudMaxValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMinValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbNumberSystem);
            this.Controls.Add(this.cmbNumberSystem);
            this.Name = "PalindromicPrime";
            this.Text = "Palindromic Primes";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNumberSystem;
        private System.Windows.Forms.Label lbNumberSystem;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMinValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
    }
}

