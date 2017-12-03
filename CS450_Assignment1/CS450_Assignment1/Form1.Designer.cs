namespace CS450_Assignment1
{
    partial class lblAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblAuthor));
            this.rbtnFCFS = new System.Windows.Forms.RadioButton();
            this.rbtnRoundRobin = new System.Windows.Forms.RadioButton();
            this.rbtnSingAlg = new System.Windows.Forms.RadioButton();
            this.rbtnComp = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.lblAvgWait = new System.Windows.Forms.Label();
            this.numSelProcCnt = new System.Windows.Forms.NumericUpDown();
            this.txtAvgWaitTimeFCFS = new System.Windows.Forms.TextBox();
            this.lblMaxProc = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.rbtnReuseDataY = new System.Windows.Forms.RadioButton();
            this.rbtnReuseDataN = new System.Windows.Forms.RadioButton();
            this.grpBoxSchedAlg = new System.Windows.Forms.GroupBox();
            this.txtTotalWaitRR = new System.Windows.Forms.TextBox();
            this.txtAvgWaitTimeRR = new System.Windows.Forms.TextBox();
            this.txtTotalWaitFCFS = new System.Windows.Forms.TextBox();
            this.lblTotalWait = new System.Windows.Forms.Label();
            this.grpBoxPerfEval = new System.Windows.Forms.GroupBox();
            this.grpboxUseSameData = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.numSelQuantum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblAuthor = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numSelProcCnt)).BeginInit();
            this.grpBoxSchedAlg.SuspendLayout();
            this.grpBoxPerfEval.SuspendLayout();
            this.grpboxUseSameData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelQuantum)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnFCFS
            // 
            this.rbtnFCFS.AutoSize = true;
            this.rbtnFCFS.Checked = true;
            this.rbtnFCFS.Location = new System.Drawing.Point(6, 39);
            this.rbtnFCFS.Name = "rbtnFCFS";
            this.rbtnFCFS.Size = new System.Drawing.Size(63, 21);
            this.rbtnFCFS.TabIndex = 0;
            this.rbtnFCFS.TabStop = true;
            this.rbtnFCFS.Text = "FCFS";
            this.rbtnFCFS.UseVisualStyleBackColor = true;
            this.rbtnFCFS.CheckedChanged += new System.EventHandler(this.rbtnFCFS_CheckedChanged);
            // 
            // rbtnRoundRobin
            // 
            this.rbtnRoundRobin.AutoSize = true;
            this.rbtnRoundRobin.Location = new System.Drawing.Point(6, 84);
            this.rbtnRoundRobin.Name = "rbtnRoundRobin";
            this.rbtnRoundRobin.Size = new System.Drawing.Size(112, 21);
            this.rbtnRoundRobin.TabIndex = 1;
            this.rbtnRoundRobin.TabStop = true;
            this.rbtnRoundRobin.Text = "Round Robin";
            this.rbtnRoundRobin.UseVisualStyleBackColor = true;
            this.rbtnRoundRobin.CheckedChanged += new System.EventHandler(this.rbtnRoundRobin_CheckedChanged);
            // 
            // rbtnSingAlg
            // 
            this.rbtnSingAlg.AutoSize = true;
            this.rbtnSingAlg.Checked = true;
            this.rbtnSingAlg.Location = new System.Drawing.Point(10, 23);
            this.rbtnSingAlg.Name = "rbtnSingAlg";
            this.rbtnSingAlg.Size = new System.Drawing.Size(131, 21);
            this.rbtnSingAlg.TabIndex = 4;
            this.rbtnSingAlg.TabStop = true;
            this.rbtnSingAlg.Text = "Single Algorithm";
            this.rbtnSingAlg.UseVisualStyleBackColor = true;
            this.rbtnSingAlg.CheckedChanged += new System.EventHandler(this.rbtnSingAlg_CheckedChanged);
            // 
            // rbtnComp
            // 
            this.rbtnComp.AutoSize = true;
            this.rbtnComp.Location = new System.Drawing.Point(10, 50);
            this.rbtnComp.Name = "rbtnComp";
            this.rbtnComp.Size = new System.Drawing.Size(167, 21);
            this.rbtnComp.TabIndex = 5;
            this.rbtnComp.TabStop = true;
            this.rbtnComp.Text = "Algorithm Comparison";
            this.rbtnComp.UseVisualStyleBackColor = true;
            this.rbtnComp.CheckedChanged += new System.EventHandler(this.rbtnComp_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(900, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtConsole.ForeColor = System.Drawing.Color.Gold;
            this.txtConsole.Location = new System.Drawing.Point(18, 21);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(568, 446);
            this.txtConsole.TabIndex = 28;
            this.txtConsole.WordWrap = false;
            // 
            // lblAvgWait
            // 
            this.lblAvgWait.AutoSize = true;
            this.lblAvgWait.Location = new System.Drawing.Point(126, 18);
            this.lblAvgWait.Name = "lblAvgWait";
            this.lblAvgWait.Size = new System.Drawing.Size(99, 17);
            this.lblAvgWait.TabIndex = 30;
            this.lblAvgWait.Text = "Avg Wait Time";
            // 
            // numSelProcCnt
            // 
            this.numSelProcCnt.Location = new System.Drawing.Point(843, 353);
            this.numSelProcCnt.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSelProcCnt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSelProcCnt.Name = "numSelProcCnt";
            this.numSelProcCnt.Size = new System.Drawing.Size(120, 22);
            this.numSelProcCnt.TabIndex = 31;
            this.numSelProcCnt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSelProcCnt.ValueChanged += new System.EventHandler(this.numSelProcCnt_ValueChanged);
            // 
            // txtAvgWaitTimeFCFS
            // 
            this.txtAvgWaitTimeFCFS.Location = new System.Drawing.Point(125, 38);
            this.txtAvgWaitTimeFCFS.Name = "txtAvgWaitTimeFCFS";
            this.txtAvgWaitTimeFCFS.ReadOnly = true;
            this.txtAvgWaitTimeFCFS.Size = new System.Drawing.Size(100, 22);
            this.txtAvgWaitTimeFCFS.TabIndex = 32;
            this.txtAvgWaitTimeFCFS.Text = "0 seconds";
            // 
            // lblMaxProc
            // 
            this.lblMaxProc.AutoSize = true;
            this.lblMaxProc.Location = new System.Drawing.Point(607, 355);
            this.lblMaxProc.Name = "lblMaxProc";
            this.lblMaxProc.Size = new System.Drawing.Size(144, 17);
            this.lblMaxProc.TabIndex = 33;
            this.lblMaxProc.Text = "Number of Processes";
            this.lblMaxProc.Click += new System.EventHandler(this.lblMaxProc_Click);
            // 
            // btnRun
            // 
            this.btnRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRun.Location = new System.Drawing.Point(610, 21);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 36;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rbtnReuseDataY
            // 
            this.rbtnReuseDataY.AutoSize = true;
            this.rbtnReuseDataY.Enabled = false;
            this.rbtnReuseDataY.Location = new System.Drawing.Point(6, 21);
            this.rbtnReuseDataY.Name = "rbtnReuseDataY";
            this.rbtnReuseDataY.Size = new System.Drawing.Size(53, 21);
            this.rbtnReuseDataY.TabIndex = 38;
            this.rbtnReuseDataY.Text = "Yes";
            this.rbtnReuseDataY.UseVisualStyleBackColor = true;
            this.rbtnReuseDataY.CheckedChanged += new System.EventHandler(this.rbtnReuseDataY_CheckedChanged);
            // 
            // rbtnReuseDataN
            // 
            this.rbtnReuseDataN.AutoSize = true;
            this.rbtnReuseDataN.Checked = true;
            this.rbtnReuseDataN.Location = new System.Drawing.Point(6, 48);
            this.rbtnReuseDataN.Name = "rbtnReuseDataN";
            this.rbtnReuseDataN.Size = new System.Drawing.Size(47, 21);
            this.rbtnReuseDataN.TabIndex = 37;
            this.rbtnReuseDataN.TabStop = true;
            this.rbtnReuseDataN.Text = "No";
            this.rbtnReuseDataN.UseVisualStyleBackColor = true;
            this.rbtnReuseDataN.CheckedChanged += new System.EventHandler(this.rbtnReuseDataN_CheckedChanged);
            // 
            // grpBoxSchedAlg
            // 
            this.grpBoxSchedAlg.Controls.Add(this.txtTotalWaitRR);
            this.grpBoxSchedAlg.Controls.Add(this.txtAvgWaitTimeRR);
            this.grpBoxSchedAlg.Controls.Add(this.txtTotalWaitFCFS);
            this.grpBoxSchedAlg.Controls.Add(this.rbtnFCFS);
            this.grpBoxSchedAlg.Controls.Add(this.lblTotalWait);
            this.grpBoxSchedAlg.Controls.Add(this.rbtnRoundRobin);
            this.grpBoxSchedAlg.Controls.Add(this.lblAvgWait);
            this.grpBoxSchedAlg.Controls.Add(this.txtAvgWaitTimeFCFS);
            this.grpBoxSchedAlg.Location = new System.Drawing.Point(610, 133);
            this.grpBoxSchedAlg.Name = "grpBoxSchedAlg";
            this.grpBoxSchedAlg.Size = new System.Drawing.Size(353, 129);
            this.grpBoxSchedAlg.TabIndex = 40;
            this.grpBoxSchedAlg.TabStop = false;
            this.grpBoxSchedAlg.Text = "Scheduling Algorithm";
            // 
            // txtTotalWaitRR
            // 
            this.txtTotalWaitRR.Location = new System.Drawing.Point(242, 83);
            this.txtTotalWaitRR.Name = "txtTotalWaitRR";
            this.txtTotalWaitRR.ReadOnly = true;
            this.txtTotalWaitRR.Size = new System.Drawing.Size(100, 22);
            this.txtTotalWaitRR.TabIndex = 47;
            this.txtTotalWaitRR.Text = "0 seconds";
            // 
            // txtAvgWaitTimeRR
            // 
            this.txtAvgWaitTimeRR.Location = new System.Drawing.Point(124, 83);
            this.txtAvgWaitTimeRR.Name = "txtAvgWaitTimeRR";
            this.txtAvgWaitTimeRR.ReadOnly = true;
            this.txtAvgWaitTimeRR.Size = new System.Drawing.Size(100, 22);
            this.txtAvgWaitTimeRR.TabIndex = 46;
            this.txtAvgWaitTimeRR.Text = "0 seconds";
            // 
            // txtTotalWaitFCFS
            // 
            this.txtTotalWaitFCFS.Location = new System.Drawing.Point(243, 38);
            this.txtTotalWaitFCFS.Name = "txtTotalWaitFCFS";
            this.txtTotalWaitFCFS.ReadOnly = true;
            this.txtTotalWaitFCFS.Size = new System.Drawing.Size(100, 22);
            this.txtTotalWaitFCFS.TabIndex = 45;
            this.txtTotalWaitFCFS.Text = "0 seconds";
            // 
            // lblTotalWait
            // 
            this.lblTotalWait.AutoSize = true;
            this.lblTotalWait.Location = new System.Drawing.Point(240, 18);
            this.lblTotalWait.Name = "lblTotalWait";
            this.lblTotalWait.Size = new System.Drawing.Size(107, 17);
            this.lblTotalWait.TabIndex = 44;
            this.lblTotalWait.Text = "Total Wait Time";
            // 
            // grpBoxPerfEval
            // 
            this.grpBoxPerfEval.Controls.Add(this.rbtnSingAlg);
            this.grpBoxPerfEval.Controls.Add(this.rbtnComp);
            this.grpBoxPerfEval.Location = new System.Drawing.Point(610, 54);
            this.grpBoxPerfEval.Name = "grpBoxPerfEval";
            this.grpBoxPerfEval.Size = new System.Drawing.Size(353, 73);
            this.grpBoxPerfEval.TabIndex = 41;
            this.grpBoxPerfEval.TabStop = false;
            this.grpBoxPerfEval.Text = "Performance Evaluation";
            // 
            // grpboxUseSameData
            // 
            this.grpboxUseSameData.Controls.Add(this.rbtnReuseDataY);
            this.grpboxUseSameData.Controls.Add(this.rbtnReuseDataN);
            this.grpboxUseSameData.Location = new System.Drawing.Point(610, 268);
            this.grpboxUseSameData.Name = "grpboxUseSameData";
            this.grpboxUseSameData.Size = new System.Drawing.Size(353, 72);
            this.grpboxUseSameData.TabIndex = 42;
            this.grpboxUseSameData.TabStop = false;
            this.grpboxUseSameData.Text = "Use Same Data";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(755, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Location = new System.Drawing.Point(607, 395);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(145, 17);
            this.lblQuantum.TabIndex = 44;
            this.lblQuantum.Text = "Quantum (Time Slice)";
            // 
            // numSelQuantum
            // 
            this.numSelQuantum.Enabled = false;
            this.numSelQuantum.Location = new System.Drawing.Point(843, 393);
            this.numSelQuantum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSelQuantum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSelQuantum.Name = "numSelQuantum";
            this.numSelQuantum.Size = new System.Drawing.Size(120, 22);
            this.numSelQuantum.TabIndex = 45;
            this.numSelQuantum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(856, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Author:";
            // 
            // lnklblAuthor
            // 
            this.lnklblAuthor.AutoSize = true;
            this.lnklblAuthor.Location = new System.Drawing.Point(906, 450);
            this.lnklblAuthor.Name = "lnklblAuthor";
            this.lnklblAuthor.Size = new System.Drawing.Size(77, 17);
            this.lnklblAuthor.TabIndex = 47;
            this.lnklblAuthor.TabStop = true;
            this.lnklblAuthor.Text = "Chris Iossa";
            this.lnklblAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAuthor_LinkClicked);
            // 
            // lblAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(995, 476);
            this.Controls.Add(this.lnklblAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSelQuantum);
            this.Controls.Add(this.lblQuantum);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpboxUseSameData);
            this.Controls.Add(this.grpBoxPerfEval);
            this.Controls.Add(this.grpBoxSchedAlg);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblMaxProc);
            this.Controls.Add(this.numSelProcCnt);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lblAuthor";
            this.Text = "Scheduling Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSelProcCnt)).EndInit();
            this.grpBoxSchedAlg.ResumeLayout(false);
            this.grpBoxSchedAlg.PerformLayout();
            this.grpBoxPerfEval.ResumeLayout(false);
            this.grpBoxPerfEval.PerformLayout();
            this.grpboxUseSameData.ResumeLayout(false);
            this.grpboxUseSameData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelQuantum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnFCFS;
        private System.Windows.Forms.RadioButton rbtnRoundRobin;
        private System.Windows.Forms.RadioButton rbtnSingAlg;
        private System.Windows.Forms.RadioButton rbtnComp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label lblAvgWait;
        private System.Windows.Forms.NumericUpDown numSelProcCnt;
        private System.Windows.Forms.TextBox txtAvgWaitTimeFCFS;
        private System.Windows.Forms.Label lblMaxProc;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RadioButton rbtnReuseDataY;
        private System.Windows.Forms.RadioButton rbtnReuseDataN;
        private System.Windows.Forms.GroupBox grpBoxSchedAlg;
        private System.Windows.Forms.GroupBox grpBoxPerfEval;
        private System.Windows.Forms.GroupBox grpboxUseSameData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotalWait;
        private System.Windows.Forms.TextBox txtTotalWaitFCFS;
        private System.Windows.Forms.TextBox txtTotalWaitRR;
        private System.Windows.Forms.TextBox txtAvgWaitTimeRR;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.NumericUpDown numSelQuantum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblAuthor;
    }
}

