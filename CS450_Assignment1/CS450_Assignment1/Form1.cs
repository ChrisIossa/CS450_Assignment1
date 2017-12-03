
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS450_Assignment1
{
    public partial class lblAuthor : Form
    {
        //private member variables
        private uint maxProc = 10; //number of processes specefied by the user
        private double totalWait = 0;
        //private int currTime = 0;
        private List<Process> processList = new List<Process>(); //queue to store processes waiting for CPU
        private Random randGen = new Random(); //RNG needed to randomly generate values

        public lblAuthor()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            
            if (rbtnReuseDataN.Checked)
            {
                processList.Clear();
                if (rbtnFCFS.Checked || rbtnComp.Checked)
                {
                    for (int i = 0; i < maxProc; i++)
                    {
                        if (processList.Count == 0)
                        {
                            processList.Add(new Process(String.Concat("Process ", i), randGen.Next(1, 10), processList.Count + 1, true));
                        }
                        else
                        {
                            processList.Add(new Process(String.Concat("Process ", i), randGen.Next(1, 10), processList.Count + 1, processList[processList.Count - 1].getCompletionTime(true), randGen.Next((processList[processList.Count - 1].getArrvTime() + 1), (processList[processList.Count - 1].getArrvTime() + 10)), true));
                        }
                    }
                }
                else if (rbtnRoundRobin.Checked)
                {
                    for (int i = 0; i < maxProc; i++)
                    {
                        processList.Add(new Process(String.Concat("Process ", i), randGen.Next(1, 10), processList.Count + 1, false));
                        if (i == 0)
                        {
                            processList[i].setArrvTime(0);
                        }
                        else
                        {
                            processList[i].setArrvTime(randGen.Next((processList[i - 1].getArrvTime() + 1), (processList[i - 1].getArrvTime() + 10)));
                        }
                    }
                }
            }
            else
            {
                
                if (rbtnFCFS.Checked || rbtnComp.Checked)
                {
                    for (int i = 0; i < maxProc; i++)
                    {
                        if (i == 0)
                        {
                            processList[i].setStartTime(0,true);
                        }
                        else
                        {
                            processList[i].setStartTime(processList[i-1].getCompletionTime(true),true);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < maxProc; i++)
                    {
                        //processList[i].setStartTime(0);
                        processList[i].setBurstRemaining(processList[i].getBurstTime());
                    }
                }
            }

            if (rbtnSingAlg.Checked)
            {
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Start Simulator: ");
                txtConsole.AppendText(DateTime.Now.ToShortTimeString());
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Mode: ");
                if (rbtnSingAlg.Checked)
                {
                    txtConsole.AppendText("Single Algorithm/");
                }
                else
                {
                    txtConsole.AppendText("Algorithm Comparison/");
                }
                if (rbtnReuseDataY.Checked)
                {
                    txtConsole.AppendText("Same Data");
                }
                else
                {
                    txtConsole.AppendText("New Data");
                }
                txtConsole.AppendText("\r\n");
                
                txtConsole.AppendText("\r\n");
               if (rbtnFCFS.Checked)
                {

                    fcfsAlg();
                }
                else
                {
                    /*
                    processList.Clear();
                    processList.Add(new Process("P1", 3, 0, 3, true));
                    processList.Add(new Process("P2", 3, 0, 7, true));
                    processList.Add(new Process("P3", 4, 0, 9, true));
                    processList.Add(new Process("P4", 2, 1, 15, true));
                    processList.Add(new Process("P5", 5, 0, 16, true));
                    */
                    roundRobAlg(Convert.ToInt32(numSelQuantum.Value));
                }
            }
            else
            {
                fcfsAlg();
                roundRobAlg(Convert.ToInt32(numSelQuantum.Value));
                
            }
            rbtnReuseDataY.Enabled = true; //as there is now an existing dataset, data can be reused
            txtConsole.AppendText("End Simulator: ");
            txtConsole.AppendText(DateTime.Now.ToShortTimeString());
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("\r\n");
        }

        private void fcfsAlg()
        {
            totalWait = 0;
            txtConsole.AppendText("Algorithm:  First Come First Serve");
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("Number of Processes: ");
            txtConsole.AppendText(maxProc.ToString());
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("\r\n");
            for (int i = 0; i < processList.Count(); i++)
            {

                txtConsole.AppendText(processList[i].getProcName());
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Arrival Time:\t" + processList[i].getArrvTime());
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Burst Time:\t" + processList[i].getBurstTime());
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Start Time:\t" + processList[i].getStartTime());
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Wait Time:\t" + processList[i].getWaitTime(true));
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Completion Time:\t" + processList[i].getCompletionTime(true));
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Turnaround Time:\t" + processList[i].getTurnaroundTime(true));
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("\r\n");
                totalWait += processList[i].getWaitTime(true);
                txtTotalWaitFCFS.Text = String.Concat(totalWait.ToString(), " seconds");
                txtAvgWaitTimeFCFS.Text = String.Concat((totalWait / (i + 1)).ToString("0.000"), " seconds");
            }
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("Total Wait Time:  ");
            txtConsole.AppendText(txtTotalWaitFCFS.Text);
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("Average Wait Time:  ");
            txtConsole.AppendText(txtAvgWaitTimeFCFS.Text);
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("\r\n");


        }

        private void roundRobAlg(int quantum)
        {
            txtConsole.AppendText("Algorithm:  Round Robin");
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("Number of Processes: ");
            txtConsole.AppendText(maxProc.ToString());
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("Quantum: ");
            txtConsole.AppendText(quantum.ToString());
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("\r\n");

            totalWait = 0;
            List<Process> processListRR = new List<Process>(processList);
            for (int i = 0; i < processListRR.Count; i++)
            {
                processListRR[i].setBurstRemaining(processListRR[i].getBurstTime());
            }
            processList.Clear();
            int rrClock = 0;
            int procCount = 0;
            int passes = 0;
            int minTime = 2147483647;
            int minIndex = 0;
            while (procCount != maxProc)
            {
                passes = 0;
                minTime = 2147483647;
                for (int i = 0; i < processListRR.Count; i++)
                {
                    if (processListRR[i].getArrvTime() <= rrClock)
                    {
                        if (!processListRR[i].isCompleted())
                        {
                            int timeSlice = processListRR[i].giveSlice(quantum, rrClock);
                            rrClock += timeSlice;
                        }
                        if (!processListRR[i].isCompleted() && processListRR[i].getBurstRem() == 0)
                        {
                            processListRR[i].setCompletionTime(rrClock);
                            procCount++;
                            totalWait += processListRR[i].getWaitTime(false);
                            txtTotalWaitRR.Text = String.Concat(totalWait.ToString(), " seconds");
                            txtAvgWaitTimeRR.Text = String.Concat((totalWait / procCount).ToString("0.000"), " seconds");
                        }
                    }
                    else
                    {
                        passes++;
                        if (processListRR[i].getArrvTime() < minTime)
                        {
                            minTime = processListRR[i].getArrvTime();
                            minIndex = i;
                        }
                        if (passes == (maxProc - procCount))
                        {
                            rrClock = processListRR[minIndex].getArrvTime();
                        }
                    }
                }
            }
            for (int i = 0; i < processListRR.Count; i++)
            {
                txtConsole.AppendText(processListRR[i].getProcName());
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Arrival Time:\t" + processListRR[i].getArrvTime());
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Start Time:\t" + processListRR[i].getArrvTime());
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Wait Time:\t" + processListRR[i].getWaitTime(false));
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Burst Time:\t" + processListRR[i].getBurstTime());
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Completion Time:\t" + processListRR[i].getCompletionTime(false));
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("Turnaround Time:\t" + processListRR[i].getTurnaroundTime(false));
                txtConsole.AppendText("\r\n");
                txtConsole.AppendText("\r\n");
                processList.Add(new Process(processListRR[i].getProcName(), processListRR[i].getBurstTime(), processListRR[i].getPriority(), processListRR[i].getArrvTime(), false)); //add a copy of the process as an FCFS process to the arrayList so that it can be reused later   
                
            }
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("Total Wait Time:  ");
            txtConsole.AppendText(txtTotalWaitRR.Text);
            txtConsole.AppendText("\r\n");
            txtConsole.AppendText("Average Wait Time:  ");
            txtConsole.AppendText(txtAvgWaitTimeRR.Text);
            txtConsole.AppendText("\r\n");
        }

        private void numSelProcCnt_ValueChanged(object sender, EventArgs e)
        {
            maxProc = Convert.ToUInt32(numSelProcCnt.Value);
            rbtnReuseDataY.Enabled = false;
            rbtnReuseDataY.Checked = false;
            rbtnReuseDataN.Enabled = true;
            rbtnReuseDataN.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "SchedulingSimulation.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtOut = new StreamWriter(save.OpenFile());
                txtOut.WriteLine(txtConsole.Text);
                txtOut.Dispose();
                txtOut.Close();
            }
        }

        private void rbtnReuseDataY_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnReuseDataN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnFCFS_CheckedChanged(object sender, EventArgs e)
        {
            numSelQuantum.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
            /*
            txtAvgWaitTimeFCFS.Text = "";
            txtAvgWaitTimeRR.Text = "";
            txtTotalWaitFCFS.Text = "";
            txtTotalWaitRR.Text = "";
            */
        }

        private void lblMaxProc_Click(object sender, EventArgs e)
        {

        }

        private void rbtnComp_CheckedChanged(object sender, EventArgs e)
        {
            rbtnFCFS.Checked = false;
            rbtnRoundRobin.Checked = false;
            rbtnFCFS.Enabled = false;
            rbtnRoundRobin.Enabled = false;
            numSelQuantum.Enabled = true;
        }

        private void rbtnSingAlg_CheckedChanged(object sender, EventArgs e)
        {
            rbtnFCFS.Checked = true;
            rbtnRoundRobin.Checked = false;
            rbtnFCFS.Enabled = true;
            rbtnRoundRobin.Enabled = true;
        }

        private void rbtnRoundRobin_CheckedChanged(object sender, EventArgs e)
        {
            numSelQuantum.Enabled = true;
        }

        private void lnklblAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnklblAuthor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.github.com/ChrisIossa");
        }
    }
}
