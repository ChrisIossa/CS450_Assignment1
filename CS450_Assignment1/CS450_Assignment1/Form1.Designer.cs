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
            this.rbtn_FCFS = new System.Windows.Forms.RadioButton();
            this.rbtn_RoundRobin = new System.Windows.Forms.RadioButton();
            this.lbl_SchedAlg = new System.Windows.Forms.Label();
            this.lblPrefEval = new System.Windows.Forms.Label();
            this.rbtnSingAlg = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtn_FCFS
            // 
            this.rbtn_FCFS.AutoSize = true;
            this.rbtn_FCFS.Location = new System.Drawing.Point(24, 485);
            this.rbtn_FCFS.Name = "rbtn_FCFS";
            this.rbtn_FCFS.Size = new System.Drawing.Size(63, 21);
            this.rbtn_FCFS.TabIndex = 0;
            this.rbtn_FCFS.TabStop = true;
            this.rbtn_FCFS.Text = "FCFS";
            this.rbtn_FCFS.UseVisualStyleBackColor = true;
            this.rbtn_FCFS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_RoundRobin
            // 
            this.rbtn_RoundRobin.AutoSize = true;
            this.rbtn_RoundRobin.Location = new System.Drawing.Point(24, 458);
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
            this.lbl_SchedAlg.Location = new System.Drawing.Point(24, 435);
            this.lbl_SchedAlg.Name = "lbl_SchedAlg";
            this.lbl_SchedAlg.Size = new System.Drawing.Size(141, 17);
            this.lbl_SchedAlg.TabIndex = 2;
            this.lbl_SchedAlg.Text = "Scheduling Algorithm";
            // 
            // lblPrefEval
            // 
            this.lblPrefEval.AutoSize = true;
            this.lblPrefEval.Location = new System.Drawing.Point(523, 435);
            this.lblPrefEval.Name = "lblPrefEval";
            this.lblPrefEval.Size = new System.Drawing.Size(159, 17);
            this.lblPrefEval.TabIndex = 3;
            this.lblPrefEval.Text = "Performance Evaluation";
            this.lblPrefEval.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbtnSingAlg
            // 
            this.rbtnSingAlg.AutoSize = true;
            this.rbtnSingAlg.Location = new System.Drawing.Point(526, 458);
            this.rbtnSingAlg.Name = "rbtnSingAlg";
            this.rbtnSingAlg.Size = new System.Drawing.Size(131, 21);
            this.rbtnSingAlg.TabIndex = 4;
            this.rbtnSingAlg.TabStop = true;
            this.rbtnSingAlg.Text = "Single Algorithm";
            this.rbtnSingAlg.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(526, 485);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 559);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbtnSingAlg);
            this.Controls.Add(this.lblPrefEval);
            this.Controls.Add(this.lbl_SchedAlg);
            this.Controls.Add(this.rbtn_RoundRobin);
            this.Controls.Add(this.rbtn_FCFS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_FCFS;
        private System.Windows.Forms.RadioButton rbtn_RoundRobin;
        private System.Windows.Forms.Label lbl_SchedAlg;
        private System.Windows.Forms.Label lblPrefEval;
        private System.Windows.Forms.RadioButton rbtnSingAlg;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

