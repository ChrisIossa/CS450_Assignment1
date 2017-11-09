namespace CS450_Assignment1
{
    partial class Simulator
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
            this.rbtnSingAlg = new System.Windows.Forms.RadioButton();
            this.rbtnComp = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.lblAvgWait = new System.Windows.Forms.Label();
            this.numSelProcCnt = new System.Windows.Forms.NumericUpDown();
            this.txtAvgWaitTime = new System.Windows.Forms.TextBox();
            this.lblMaxProc = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.rbtnReuseDataY = new System.Windows.Forms.RadioButton();
            this.rbtnReuseDataN = new System.Windows.Forms.RadioButton();
            this.grpBoxSchedAlg = new System.Windows.Forms.GroupBox();
            this.grpBoxPerfEval = new System.Windows.Forms.GroupBox();
            this.grpboxUseSameData = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSelProcCnt)).BeginInit();
            this.grpBoxSchedAlg.SuspendLayout();
            this.grpBoxPerfEval.SuspendLayout();
            this.grpboxUseSameData.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnFCFS
            // 
            this.rbtnFCFS.AutoSize = true;
            this.rbtnFCFS.Checked = true;
            this.rbtnFCFS.Location = new System.Drawing.Point(7, 21);
            this.rbtnFCFS.Name = "rbtnFCFS";
            this.rbtnFCFS.Size = new System.Drawing.Size(63, 21);
            this.rbtnFCFS.TabIndex = 0;
            this.rbtnFCFS.TabStop = true;
            this.rbtnFCFS.Text = "FCFS";
            this.rbtnFCFS.UseVisualStyleBackColor = true;
            this.rbtnFCFS.CheckedChanged += new System.EventHandler(this.rbtnFCFS_CheckedChanged);
            // 
            // rbtn_RoundRobin
            // 
            this.rbtn_RoundRobin.AutoSize = true;
            this.rbtn_RoundRobin.Location = new System.Drawing.Point(6, 48);
            this.rbtn_RoundRobin.Name = "rbtn_RoundRobin";
            this.rbtn_RoundRobin.Size = new System.Drawing.Size(112, 21);
            this.rbtn_RoundRobin.TabIndex = 1;
            this.rbtn_RoundRobin.TabStop = true;
            this.rbtn_RoundRobin.Text = "Round Robin";
            this.rbtn_RoundRobin.UseVisualStyleBackColor = true;
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
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(605, 399);
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
            this.txtConsole.Size = new System.Drawing.Size(568, 401);
            this.txtConsole.TabIndex = 28;
            this.txtConsole.WordWrap = false;
            // 
            // lblAvgWait
            // 
            this.lblAvgWait.AutoSize = true;
            this.lblAvgWait.Location = new System.Drawing.Point(610, 313);
            this.lblAvgWait.Name = "lblAvgWait";
            this.lblAvgWait.Size = new System.Drawing.Size(99, 17);
            this.lblAvgWait.TabIndex = 30;
            this.lblAvgWait.Text = "Avg Wait Time";
            this.lblAvgWait.Click += new System.EventHandler(this.lblAvgWait_Click);
            // 
            // numSelProcCnt
            // 
            this.numSelProcCnt.Location = new System.Drawing.Point(719, 338);
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
            // txtAvgWaitTime
            // 
            this.txtAvgWaitTime.Location = new System.Drawing.Point(719, 310);
            this.txtAvgWaitTime.Name = "txtAvgWaitTime";
            this.txtAvgWaitTime.ReadOnly = true;
            this.txtAvgWaitTime.Size = new System.Drawing.Size(100, 22);
            this.txtAvgWaitTime.TabIndex = 32;
            this.txtAvgWaitTime.Text = "0 seconds";
            // 
            // lblMaxProc
            // 
            this.lblMaxProc.AutoSize = true;
            this.lblMaxProc.Location = new System.Drawing.Point(610, 340);
            this.lblMaxProc.Name = "lblMaxProc";
            this.lblMaxProc.Size = new System.Drawing.Size(102, 17);
            this.lblMaxProc.TabIndex = 33;
            this.lblMaxProc.Text = "# of Processes";
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
            this.rbtnReuseDataY.Checked = true;
            this.rbtnReuseDataY.Location = new System.Drawing.Point(6, 21);
            this.rbtnReuseDataY.Name = "rbtnReuseDataY";
            this.rbtnReuseDataY.Size = new System.Drawing.Size(53, 21);
            this.rbtnReuseDataY.TabIndex = 38;
            this.rbtnReuseDataY.TabStop = true;
            this.rbtnReuseDataY.Text = "Yes";
            this.rbtnReuseDataY.UseVisualStyleBackColor = true;
            this.rbtnReuseDataY.CheckedChanged += new System.EventHandler(this.rbtnReuseDataY_CheckedChanged);
            // 
            // rbtnReuseDataN
            // 
            this.rbtnReuseDataN.AutoSize = true;
            this.rbtnReuseDataN.Location = new System.Drawing.Point(6, 48);
            this.rbtnReuseDataN.Name = "rbtnReuseDataN";
            this.rbtnReuseDataN.Size = new System.Drawing.Size(47, 21);
            this.rbtnReuseDataN.TabIndex = 37;
            this.rbtnReuseDataN.Text = "No";
            this.rbtnReuseDataN.UseVisualStyleBackColor = true;
            this.rbtnReuseDataN.CheckedChanged += new System.EventHandler(this.rbtnReuseDataN_CheckedChanged);
            // 
            // grpBoxSchedAlg
            // 
            this.grpBoxSchedAlg.Controls.Add(this.rbtnFCFS);
            this.grpBoxSchedAlg.Controls.Add(this.rbtn_RoundRobin);
            this.grpBoxSchedAlg.Location = new System.Drawing.Point(610, 133);
            this.grpBoxSchedAlg.Name = "grpBoxSchedAlg";
            this.grpBoxSchedAlg.Size = new System.Drawing.Size(209, 81);
            this.grpBoxSchedAlg.TabIndex = 40;
            this.grpBoxSchedAlg.TabStop = false;
            this.grpBoxSchedAlg.Text = "Scheduling Algorithm";
            // 
            // grpBoxPerfEval
            // 
            this.grpBoxPerfEval.Controls.Add(this.rbtnSingAlg);
            this.grpBoxPerfEval.Controls.Add(this.rbtnComp);
            this.grpBoxPerfEval.Location = new System.Drawing.Point(610, 54);
            this.grpBoxPerfEval.Name = "grpBoxPerfEval";
            this.grpBoxPerfEval.Size = new System.Drawing.Size(209, 73);
            this.grpBoxPerfEval.TabIndex = 41;
            this.grpBoxPerfEval.TabStop = false;
            this.grpBoxPerfEval.Text = "Performance Evaluation";
            // 
            // grpboxUseSameData
            // 
            this.grpboxUseSameData.Controls.Add(this.rbtnReuseDataY);
            this.grpboxUseSameData.Controls.Add(this.rbtnReuseDataN);
            this.grpboxUseSameData.Location = new System.Drawing.Point(610, 220);
            this.grpboxUseSameData.Name = "grpboxUseSameData";
            this.grpboxUseSameData.Size = new System.Drawing.Size(209, 72);
            this.grpboxUseSameData.TabIndex = 42;
            this.grpboxUseSameData.TabStop = false;
            this.grpboxUseSameData.Text = "Use Same Data";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(605, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(860, 446);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpboxUseSameData);
            this.Controls.Add(this.grpBoxPerfEval);
            this.Controls.Add(this.grpBoxSchedAlg);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblMaxProc);
            this.Controls.Add(this.txtAvgWaitTime);
            this.Controls.Add(this.numSelProcCnt);
            this.Controls.Add(this.lblAvgWait);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Simulator";
            this.Text = "Scheduling Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSelProcCnt)).EndInit();
            this.grpBoxSchedAlg.ResumeLayout(false);
            this.grpBoxSchedAlg.PerformLayout();
            this.grpBoxPerfEval.ResumeLayout(false);
            this.grpBoxPerfEval.PerformLayout();
            this.grpboxUseSameData.ResumeLayout(false);
            this.grpboxUseSameData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnFCFS;
        private System.Windows.Forms.RadioButton rbtn_RoundRobin;
        private System.Windows.Forms.RadioButton rbtnSingAlg;
        private System.Windows.Forms.RadioButton rbtnComp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label lblAvgWait;
        private System.Windows.Forms.NumericUpDown numSelProcCnt;
        private System.Windows.Forms.TextBox txtAvgWaitTime;
        private System.Windows.Forms.Label lblMaxProc;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RadioButton rbtnReuseDataY;
        private System.Windows.Forms.RadioButton rbtnReuseDataN;
        private System.Windows.Forms.GroupBox grpBoxSchedAlg;
        private System.Windows.Forms.GroupBox grpBoxPerfEval;
        private System.Windows.Forms.GroupBox grpboxUseSameData;
        private System.Windows.Forms.Button btnClear;
    }
}

