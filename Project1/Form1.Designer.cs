namespace Project1
{
    partial class MainForm
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
            this.loanText = new System.Windows.Forms.TextBox();
            this.rebateText = new System.Windows.Forms.TextBox();
            this.annualAPR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rebateCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.twelveRadio = new System.Windows.Forms.RadioButton();
            this.twoFourRadio = new System.Windows.Forms.RadioButton();
            this.eightTeenRadio = new System.Windows.Forms.RadioButton();
            this.sixRadio = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.acceptLoanButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalInterestLabel = new System.Windows.Forms.Label();
            this.totalLoanLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanText
            // 
            this.loanText.Location = new System.Drawing.Point(143, 135);
            this.loanText.Name = "loanText";
            this.loanText.Size = new System.Drawing.Size(100, 26);
            this.loanText.TabIndex = 0;
            this.loanText.TextChanged += new System.EventHandler(this.loanText_TextChanged);
            this.loanText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loanText_KeyPress);
            // 
            // rebateText
            // 
            this.rebateText.Enabled = false;
            this.rebateText.Location = new System.Drawing.Point(143, 222);
            this.rebateText.Name = "rebateText";
            this.rebateText.Size = new System.Drawing.Size(100, 26);
            this.rebateText.TabIndex = 1;
            this.rebateText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // annualAPR
            // 
            this.annualAPR.FormattingEnabled = true;
            this.annualAPR.Items.AddRange(new object[] {
            "2.5",
            "3.5",
            "4.5",
            "5",
            "6"});
            this.annualAPR.Location = new System.Drawing.Point(143, 174);
            this.annualAPR.Name = "annualAPR";
            this.annualAPR.Size = new System.Drawing.Size(121, 28);
            this.annualAPR.TabIndex = 2;
            this.annualAPR.SelectedIndexChanged += new System.EventHandler(this.annualAPR_SelectedIndexChanged);
            this.annualAPR.TextChanged += new System.EventHandler(this.annualAPR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loan Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Annual APR (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // rebateCheck
            // 
            this.rebateCheck.AutoSize = true;
            this.rebateCheck.Location = new System.Drawing.Point(13, 222);
            this.rebateCheck.Name = "rebateCheck";
            this.rebateCheck.Size = new System.Drawing.Size(97, 24);
            this.rebateCheck.TabIndex = 6;
            this.rebateCheck.Text = "Rebate?";
            this.rebateCheck.UseVisualStyleBackColor = true;
            this.rebateCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.twelveRadio);
            this.groupBox1.Controls.Add(this.twoFourRadio);
            this.groupBox1.Controls.Add(this.eightTeenRadio);
            this.groupBox1.Controls.Add(this.sixRadio);
            this.groupBox1.Location = new System.Drawing.Point(386, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Months";
            // 
            // twelveRadio
            // 
            this.twelveRadio.AutoSize = true;
            this.twelveRadio.Location = new System.Drawing.Point(7, 68);
            this.twelveRadio.Name = "twelveRadio";
            this.twelveRadio.Size = new System.Drawing.Size(52, 24);
            this.twelveRadio.TabIndex = 3;
            this.twelveRadio.Text = "12";
            this.twelveRadio.UseVisualStyleBackColor = true;
            this.twelveRadio.CheckedChanged += new System.EventHandler(this.twelveRadio_CheckedChanged);
            // 
            // twoFourRadio
            // 
            this.twoFourRadio.AutoSize = true;
            this.twoFourRadio.Location = new System.Drawing.Point(79, 67);
            this.twoFourRadio.Name = "twoFourRadio";
            this.twoFourRadio.Size = new System.Drawing.Size(52, 24);
            this.twoFourRadio.TabIndex = 2;
            this.twoFourRadio.Text = "24";
            this.twoFourRadio.UseVisualStyleBackColor = true;
            this.twoFourRadio.CheckedChanged += new System.EventHandler(this.twelveRadio_CheckedChanged);
            // 
            // eightTeenRadio
            // 
            this.eightTeenRadio.AutoSize = true;
            this.eightTeenRadio.Location = new System.Drawing.Point(79, 33);
            this.eightTeenRadio.Name = "eightTeenRadio";
            this.eightTeenRadio.Size = new System.Drawing.Size(52, 24);
            this.eightTeenRadio.TabIndex = 1;
            this.eightTeenRadio.Text = "18";
            this.eightTeenRadio.UseVisualStyleBackColor = true;
            this.eightTeenRadio.CheckedChanged += new System.EventHandler(this.twelveRadio_CheckedChanged);
            // 
            // sixRadio
            // 
            this.sixRadio.AutoSize = true;
            this.sixRadio.Checked = true;
            this.sixRadio.Location = new System.Drawing.Point(7, 33);
            this.sixRadio.Name = "sixRadio";
            this.sixRadio.Size = new System.Drawing.Size(43, 24);
            this.sixRadio.TabIndex = 0;
            this.sixRadio.TabStop = true;
            this.sixRadio.Text = "6";
            this.sixRadio.UseVisualStyleBackColor = true;
            this.sixRadio.CheckedChanged += new System.EventHandler(this.twelveRadio_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(611, 202);
            this.listBox1.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(643, 85);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 83);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "&Calculate Loan";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // acceptLoanButton
            // 
            this.acceptLoanButton.Location = new System.Drawing.Point(643, 165);
            this.acceptLoanButton.Name = "acceptLoanButton";
            this.acceptLoanButton.Size = new System.Drawing.Size(120, 83);
            this.acceptLoanButton.TabIndex = 10;
            this.acceptLoanButton.Text = "&Accept Loan";
            this.acceptLoanButton.UseVisualStyleBackColor = true;
            this.acceptLoanButton.Click += new System.EventHandler(this.acceptLoanButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(643, 234);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(120, 91);
            this.displayButton.TabIndex = 11;
            this.displayButton.Text = "&Display All Loans";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(643, 321);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 78);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Interest:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Loans:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Interest";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Principal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Payment";
            // 
            // totalInterestLabel
            // 
            this.totalInterestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalInterestLabel.Location = new System.Drawing.Point(643, 445);
            this.totalInterestLabel.Name = "totalInterestLabel";
            this.totalInterestLabel.Size = new System.Drawing.Size(117, 23);
            this.totalInterestLabel.TabIndex = 20;
            // 
            // totalLoanLabel
            // 
            this.totalLoanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLoanLabel.Location = new System.Drawing.Point(643, 488);
            this.totalLoanLabel.Name = "totalLoanLabel";
            this.totalLoanLabel.Size = new System.Drawing.Size(117, 23);
            this.totalLoanLabel.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Academic and Industry Collaboration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Vehicle Loan Calculator";
            // 
            // MainForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(770, 519);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalLoanLabel);
            this.Controls.Add(this.totalInterestLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.acceptLoanButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rebateCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annualAPR);
            this.Controls.Add(this.rebateText);
            this.Controls.Add(this.loanText);
            this.Name = "MainForm";
            this.Text = "Vehicle Loan Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loanText;
        private System.Windows.Forms.TextBox rebateText;
        private System.Windows.Forms.ComboBox annualAPR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox rebateCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton twelveRadio;
        private System.Windows.Forms.RadioButton twoFourRadio;
        private System.Windows.Forms.RadioButton eightTeenRadio;
        private System.Windows.Forms.RadioButton sixRadio;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button acceptLoanButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalInterestLabel;
        private System.Windows.Forms.Label totalLoanLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

