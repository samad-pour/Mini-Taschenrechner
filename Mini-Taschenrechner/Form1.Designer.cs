namespace Mini_Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkInv = new System.Windows.Forms.CheckBox();
            this.T = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnCeiling = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnTruncate = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnKomma = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btnSinus = new System.Windows.Forms.Button();
            this.btnWurzel = new System.Windows.Forms.Button();
            this.btnCosinus = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnTangens = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnKehrwert = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkInv
            // 
            this.chkInv.AutoSize = true;
            this.chkInv.Location = new System.Drawing.Point(12, 41);
            this.chkInv.Name = "chkInv";
            this.chkInv.Size = new System.Drawing.Size(42, 19);
            this.chkInv.TabIndex = 0;
            this.chkInv.Text = "Inv";
            this.chkInv.UseVisualStyleBackColor = true;
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(12, 12);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(293, 23);
            this.T.TabIndex = 1;
            this.T.TextChanged += new System.EventHandler(this.T_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(276, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(29, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(241, 41);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(29, 23);
            this.btnBackSpace.TabIndex = 2;
            this.btnBackSpace.Text = "BS";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnCeiling
            // 
            this.btnCeiling.Location = new System.Drawing.Point(241, 70);
            this.btnCeiling.Name = "btnCeiling";
            this.btnCeiling.Size = new System.Drawing.Size(64, 23);
            this.btnCeiling.TabIndex = 2;
            this.btnCeiling.Text = "Ceiling";
            this.btnCeiling.UseVisualStyleBackColor = true;
            this.btnCeiling.Click += new System.EventHandler(this.btnCeiling_Click);
            // 
            // btnFloor
            // 
            this.btnFloor.Location = new System.Drawing.Point(241, 99);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(64, 23);
            this.btnFloor.TabIndex = 2;
            this.btnFloor.Text = "Floor";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(241, 128);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(64, 23);
            this.btnRound.TabIndex = 2;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnTruncate
            // 
            this.btnTruncate.Location = new System.Drawing.Point(241, 157);
            this.btnTruncate.Name = "btnTruncate";
            this.btnTruncate.Size = new System.Drawing.Size(64, 23);
            this.btnTruncate.TabIndex = 2;
            this.btnTruncate.Text = "Truncate";
            this.btnTruncate.UseVisualStyleBackColor = true;
            this.btnTruncate.Click += new System.EventHandler(this.btnTruncate_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(192, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(192, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(192, 128);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(29, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // btnKomma
            // 
            this.btnKomma.Location = new System.Drawing.Point(192, 157);
            this.btnKomma.Name = "btnKomma";
            this.btnKomma.Size = new System.Drawing.Size(29, 23);
            this.btnKomma.TabIndex = 2;
            this.btnKomma.Text = ".";
            this.btnKomma.UseVisualStyleBackColor = true;
            this.btnKomma.Click += new System.EventHandler(this.btnKomma_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(157, 157);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(29, 23);
            this.button11.TabIndex = 2;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(157, 128);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(29, 23);
            this.button12.TabIndex = 2;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(157, 99);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(29, 23);
            this.button13.TabIndex = 2;
            this.button13.Text = "5";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(157, 70);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(29, 23);
            this.button14.TabIndex = 2;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(122, 70);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(29, 23);
            this.button15.TabIndex = 2;
            this.button15.Text = "7";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(122, 99);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(29, 23);
            this.button16.TabIndex = 2;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(122, 128);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(29, 23);
            this.button17.TabIndex = 2;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // btnSinus
            // 
            this.btnSinus.Location = new System.Drawing.Point(12, 70);
            this.btnSinus.Name = "btnSinus";
            this.btnSinus.Size = new System.Drawing.Size(42, 23);
            this.btnSinus.TabIndex = 2;
            this.btnSinus.Text = "sin";
            this.btnSinus.UseVisualStyleBackColor = true;
            this.btnSinus.Click += new System.EventHandler(this.btnSinus_Click);
            // 
            // btnWurzel
            // 
            this.btnWurzel.Location = new System.Drawing.Point(60, 70);
            this.btnWurzel.Name = "btnWurzel";
            this.btnWurzel.Size = new System.Drawing.Size(42, 23);
            this.btnWurzel.TabIndex = 2;
            this.btnWurzel.Text = "Sqrt";
            this.btnWurzel.UseVisualStyleBackColor = true;
            this.btnWurzel.Click += new System.EventHandler(this.btnWurzel_Click);
            // 
            // btnCosinus
            // 
            this.btnCosinus.Location = new System.Drawing.Point(12, 99);
            this.btnCosinus.Name = "btnCosinus";
            this.btnCosinus.Size = new System.Drawing.Size(42, 23);
            this.btnCosinus.TabIndex = 2;
            this.btnCosinus.Text = "cos";
            this.btnCosinus.UseVisualStyleBackColor = true;
            this.btnCosinus.Click += new System.EventHandler(this.btnCosinus_Click);
            // 
            // btnLn
            // 
            this.btnLn.Location = new System.Drawing.Point(60, 99);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(42, 23);
            this.btnLn.TabIndex = 2;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnTangens
            // 
            this.btnTangens.Location = new System.Drawing.Point(12, 128);
            this.btnTangens.Name = "btnTangens";
            this.btnTangens.Size = new System.Drawing.Size(42, 23);
            this.btnTangens.TabIndex = 2;
            this.btnTangens.Text = "tan";
            this.btnTangens.UseVisualStyleBackColor = true;
            this.btnTangens.Click += new System.EventHandler(this.btnTangens_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(60, 128);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(42, 23);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Location = new System.Drawing.Point(12, 186);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(48, 23);
            this.btnPlusMinus.TabIndex = 2;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnKehrwert
            // 
            this.btnKehrwert.Location = new System.Drawing.Point(66, 186);
            this.btnKehrwert.Name = "btnKehrwert";
            this.btnKehrwert.Size = new System.Drawing.Size(48, 23);
            this.btnKehrwert.TabIndex = 2;
            this.btnKehrwert.Text = "1/x";
            this.btnKehrwert.UseVisualStyleBackColor = true;
            this.btnKehrwert.Click += new System.EventHandler(this.btnKehrwert_Click);
            // 
            // btnPI
            // 
            this.btnPI.Location = new System.Drawing.Point(120, 186);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(48, 23);
            this.btnPI.TabIndex = 2;
            this.btnPI.Text = "PI";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(173, 186);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(48, 23);
            this.btnE.TabIndex = 2;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 222);
            this.Controls.Add(this.btnTruncate);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.btnCeiling);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnPI);
            this.Controls.Add(this.btnKehrwert);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnTangens);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnCosinus);
            this.Controls.Add(this.btnWurzel);
            this.Controls.Add(this.btnSinus);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnKomma);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.T);
            this.Controls.Add(this.chkInv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkInv;
        private TextBox T;
        private Button btnClear;
        private Button btnBackSpace;
        private Button btnCeiling;
        private Button btnFloor;
        private Button btnRound;
        private Button btnTruncate;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnKomma;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button btnSinus;
        private Button btnWurzel;
        private Button btnCosinus;
        private Button btnLn;
        private Button btnTangens;
        private Button btnLog;
        private Button btnPlusMinus;
        private Button btnKehrwert;
        private Button btnPI;
        private Button btnE;
    }
}