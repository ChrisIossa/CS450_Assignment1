namespace CS450_Assignment1
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
            this.rbtnFCFS = new System.Windows.Forms.RadioButton();
            this.rbtn_RoundRobin = new System.Windows.Forms.RadioButton();
            this.lbl_SchedAlg = new System.Windows.Forms.Label();
            this.lblPrefEval = new System.Windows.Forms.Label();
            this.rbtnSingAlg = new System.Windows.Forms.RadioButton();
            this.rbtnComp = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCurrTime = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.txtCurrTime = new System.Windows.Forms.TextBox();
            this.lblNumLive = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtProcCnt = new System.Windows.Forms.TextBox();
            this.lblMaxProc = new System.Windows.Forms.Label();
            this.lblNumFin = new System.Windows.Forms.Label();
            this.txtNumFin = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnFCFS
            // 
            this.rbtnFCFS.AutoSize = true;
            this.rbtnFCFS.Location = new System.Drawing.Point(610, 185);
            this.rbtnFCFS.Name = "rbtnFCFS";
            this.rbtnFCFS.Size = new System.Drawing.Size(63, 21);
            this.rbtnFCFS.TabIndex = 0;
            this.rbtnFCFS.TabStop = true;
            this.rbtnFCFS.Text = "FCFS";
            this.rbtnFCFS.UseVisualStyleBackColor = true;
            // 
            // rbtn_RoundRobin
            // 
            this.rbtn_RoundRobin.AutoSize = true;
            this.rbtn_RoundRobin.Location = new System.Drawing.Point(610, 162);
            this.rbtn_RoundRobin.Name = "rbtn_RoundRobin";
            this.rbtn_RoundRobin.Size = new System.Drawing.Size(112, 21);
            this.rbtn_RoundRobin.TabIndex = 1;
            this.rbtn_RoundRobin.TabStop = true;
            this.rbtn_RoundRobin.Text = "Round Robin";
            this.rbtn_RoundRobin.UseVisualStyleBackColor = true;
            // 
            // lbl_SchedAlg
            // 
            this.lbl_SchedAlg.AutoSize = true;
            this.lbl_SchedAlg.Location = new System.Drawing.Point(610, 139);
            this.lbl_SchedAlg.Name = "lbl_SchedAlg";
            this.lbl_SchedAlg.Size = new System.Drawing.Size(141, 17);
            this.lbl_SchedAlg.TabIndex = 2;
            this.lbl_SchedAlg.Text = "Scheduling Algorithm";
            // 
            // lblPrefEval
            // 
            this.lblPrefEval.AutoSize = true;
            this.lblPrefEval.Location = new System.Drawing.Point(610, 51);
            this.lblPrefEval.Name = "lblPrefEval";
            this.lblPrefEval.Size = new System.Drawing.Size(159, 17);
            this.lblPrefEval.TabIndex = 3;
            this.lblPrefEval.Text = "Performance Evaluation";
            this.lblPrefEval.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbtnSingAlg
            // 
            this.rbtnSingAlg.AutoSize = true;
            this.rbtnSingAlg.Location = new System.Drawing.Point(610, 72);
            this.rbtnSingAlg.Name = "rbtnSingAlg";
            this.rbtnSingAlg.Size = new System.Drawing.Size(131, 21);
            this.rbtnSingAlg.TabIndex = 4;
            this.rbtnSingAlg.TabStop = true;
            this.rbtnSingAlg.Text = "Single Algorithm";
            this.rbtnSingAlg.UseVisualStyleBackColor = true;
            // 
            // rbtnComp
            // 
            this.rbtnComp.AutoSize = true;
            this.rbtnComp.Location = new System.Drawing.Point(610, 97);
            this.rbtnComp.Name = "rbtnComp";
            this.rbtnComp.Size = new System.Drawing.Size(167, 21);
            this.rbtnComp.TabIndex = 5;
            this.rbtnComp.TabStop = true;
            this.rbtnComp.Text = "Algorithm Comparison";
            this.rbtnComp.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(610, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblCurrTime
            // 
            this.lblCurrTime.AutoSize = true;
            this.lblCurrTime.Location = new System.Drawing.Point(610, 240);
            this.lblCurrTime.Name = "lblCurrTime";
            this.lblCurrTime.Size = new System.Drawing.Size(90, 17);
            this.lblCurrTime.TabIndex = 27;
            this.lblCurrTime.Text = "Current Time";
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(18, 21);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(568, 352);
            this.txtConsole.TabIndex = 28;
            this.txtConsole.WordWrap = false;
            // 
            // txtCurrTime
            // 
            this.txtCurrTime.Location = new System.Drawing.Point(707, 237);
            this.txtCurrTime.Name = "txtCurrTime";
            this.txtCurrTime.ReadOnly = true;
            this.txtCurrTime.Size = new System.Drawing.Size(129, 22);
            this.txtCurrTime.TabIndex = 29;
            // 
            // lblNumLive
            // 
            this.lblNumLive.AutoSize = true;
            this.lblNumLive.Location = new System.Drawing.Point(610, 268);
            this.lblNumLive.Name = "lblNumLive";
            this.lblNumLive.Size = new System.Drawing.Size(46, 17);
            this.lblNumLive.TabIndex = 30;
            this.lblNumLive.Text = "# Live";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(707, 321);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtProcCnt
            // 
            this.txtProcCnt.Location = new System.Drawing.Point(707, 265);
            this.txtProcCnt.Name = "txtProcCnt";
            this.txtProcCnt.ReadOnly = true;
            this.txtProcCnt.Size = new System.Drawing.Size(100, 22);
            this.txtProcCnt.TabIndex = 32;
            // 
            // lblMaxProc
            // 
            this.lblMaxProc.AutoSize = true;
            this.lblMaxProc.Location = new System.Drawing.Point(610, 323);
            this.lblMaxProc.Name = "lblMaxProc";
            this.lblMaxProc.Size = new System.Drawing.Size(78, 17);
            this.lblMaxProc.TabIndex = 33;
            this.lblMaxProc.Text = "Max # Proc";
            // 
            // lblNumFin
            // 
            this.lblNumFin.AutoSize = true;
            this.lblNumFin.Location = new System.Drawing.Point(610, 298);
            this.lblNumFin.Name = "lblNumFin";
            this.lblNumFin.Size = new System.Drawing.Size(73, 17);
            this.lblNumFin.TabIndex = 34;
            this.lblNumFin.Text = "# Finished";
            // 
            // txtNumFin
            // 
            this.txtNumFin.Location = new System.Drawing.Point(707, 293);
            this.txtNumFin.Name = "txtNumFin";
            this.txtNumFin.ReadOnly = true;
            this.txtNumFin.Size = new System.Drawing.Size(100, 22);
            this.txtNumFin.TabIndex = 35;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(610, 21);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 36;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 390);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtNumFin);
            this.Controls.Add(this.lblNumFin);
            this.Controls.Add(this.lblMaxProc);
            this.Controls.Add(this.txtProcCnt);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblNumLive);
            this.Controls.Add(this.txtCurrTime);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lblCurrTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbtnComp);
            this.Controls.Add(this.rbtnSingAlg);
            this.Controls.Add(this.lblPrefEval);
            this.Controls.Add(this.lbl_SchedAlg);
            this.Controls.Add(this.rbtn_RoundRobin);
            this.Controls.Add(this.rbtnFCFS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnFCFS;
        private System.Windows.Forms.RadioButton rbtn_RoundRobin;
        private System.Windows.Forms.Label lbl_SchedAlg;
        private System.Windows.Forms.Label lblPrefEval;
        private System.Windows.Forms.RadioButton rbtnSingAlg;
        private System.Windows.Forms.RadioButton rbtnComp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCurrTime;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TextBox txtCurrTime;
        private System.Windows.Forms.Label lblNumLive;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtProcCnt;
        private System.Windows.Forms.Label lblMaxProc;
        private System.Windows.Forms.Label lblNumFin;
        private System.Windows.Forms.TextBox txtNumFin;
        private System.Windows.Forms.Button btnRun;
    }
}

