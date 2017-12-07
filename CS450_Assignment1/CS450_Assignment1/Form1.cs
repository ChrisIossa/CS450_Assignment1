/***
 *      ____       _              _       _ _               ____  _                 _       _             
 *     / ___|  ___| |__   ___  __| |_   _| (_)_ __   __ _  / ___|(_)_ __ ___  _   _| | __ _| |_ ___  _ __ 
 *     \___ \ / __| '_ \ / _ \/ _` | | | | | | '_ \ / _` | \___ \| | '_ ` _ \| | | | |/ _` | __/ _ \| '__|
 *      ___) | (__| | | |  __/ (_| | |_| | | | | | | (_| |  ___) | | | | | | | |_| | | (_| | || (_) | |   
 *     |____/ \___|_| |_|\___|\__,_|\__,_|_|_|_| |_|\__, | |____/|_|_| |_| |_|\__,_|_|\__,_|\__\___/|_|   
 *                                                  |___/                                                 
 * 
 * Author: Chris Iossa
 * Language: C#
 * Date: 2017-11-04
 * Filename: Form1.cs
 * 
 * A Windows Form to control and display information from a scheduling simulator
 * running First-Come-First-Serve and Round Robin Scheduling
 * Algorithms on simulated processes
 */
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
    public partial class frmSchedulingSim : Form
    {
        //private member variables
        private uint maxProc = 10; //number of processes specefied by the user
        private double totalWait = 0;
        //private int currTime = 0;
        private List<Process> processList = new List<Process>(); //queue to store processes waiting for CPU
        private Random randGen = new Random(); //RNG needed to randomly generate values

        public frmSchedulingSim()
        {
            InitializeComponent();
        }


        private void btnRun_Click(object sender, EventArgs e)
        {

            if (rbtnReuseDataN.Checked)
            {
                processList.Clear();
                if (rbtnFCFS.Checked || rbtnComp.Checked) //create FCFS proccesses with new randomly generated data
                {
                    for (int i = 0; i < maxProc; i++)
                    {
                        if (processList.Count == 0)
                        {
                            processList.Add(new Process(String.Concat("Process ", i), randGen.Next(1, 10), processList.Count + 1, true)); //first process has an arrival time of 0
                        }
                        else
                        {
                            processList.Add(new Process(String.Concat("Process ", i), randGen.Next(1, 10),i, randGen.Next(0, 150), true)); //new process with randomly generated values
                        }
                    }
                }
                else if (rbtnRoundRobin.Checked) //create Round Robin processes with new randomly generated data
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
                            processList[i].setArrvTime(randGen.Next(0,150));
                        }
                    }
                }
            }
            else //use the old data
            {
                //make sure the processes are FCFS processes
                if (rbtnRoundRobin.Checked)
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
                    //run FCFS in single algorithm mode
                    fcfsAlg();
                }
                else
                {
                    //run Round Robin Algorithm with the user selected quantum
                    processList.Clear();
                    processList.Add(new Process("P1", 7, 1, 3, false));
                    processList.Add(new Process("P2", 5, 0, 5, false));
                    processList.Add(new Process("P3", 4, 2, 9, false));
                    processList.Add(new Process("P4", 4, 1, 15, false));
                    processList.Add(new Process("P5", 6, 0, 21, false));
                    processList.Add(new Process("P6", 3, 2, 30, false));
                    processList.Add(new Process("P7", 7, 4, 36, false));
                    processList.Add(new Process("P8", 5, 2, 37, false));
                    processList.Add(new Process("P9", 3, 1, 39, false));
                    processList.Add(new Process("P10", 5, 0, 48, false));
                    roundRobAlg(Convert.ToInt32(numSelQuantum.Value)); //run the round robin algoirthm with a time slice provided by the UI
                }
            }
            else
            {
                //run both algorithms
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
            ProcessComparer procComp = new ProcessComparer();
            processList.Sort(procComp);
            for (int i = 0; i < processList.Count(); i++)
            {
                if (i == 0)
                {
                    processList[i].setStartTime(0,true);
                }
                else
                {
                    processList[i].setStartTime(processList[i-1].getCompletionTime(true), true);
                }
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
            int rrClock = 0; //internal clock of the CPU
            int procCount = 0; //number of finished proccesses
            int passes = 0; //number of proccess whose arrivalTime is greater than current time of rrClock
            int minTime = 2147483647; //arrival time of the earliest procces, originally set to max int
            int minIndex = 0; //index of proccess with earliest arrival time
            while (procCount != maxProc)
            {
                passes = 0;
                minTime = 2147483647;
                for (int i = 0; i < processListRR.Count; i++)
                {
                    if (processListRR[i].getArrvTime() <= rrClock) //if proccess has arrived
                    {
                        if (!processListRR[i].isCompleted()) //is not completed
                        {

                            int timeSlice = processListRR[i].giveSlice(quantum, rrClock);//give it a time slice, either the value of quantum or the amount of time needed for the proccess to finish
                            rrClock += timeSlice;
                        }
                        if (!processListRR[i].isCompleted() && processListRR[i].getBurstRem() == 0) //if the process is not marked as completed, but is not waiting for more time to execute
                        {
                            processListRR[i].setCompletionTime(rrClock); //then it's completed, set the completed bool and set the completion time to the current value of the clock
                            procCount++; 
                            totalWait += processListRR[i].getWaitTime(false); //get the wait time and add it to the total wait time
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
                            rrClock = processListRR[minIndex].getArrvTime();//if there is no proccess waiting for a new time slice, set the clock to the arrival time of the proccess with the next earliest arrvTime
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
                txtConsole.AppendText("Start Time:\t" + processListRR[i].getStartTime());
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
            //data cannot be reused if the number of proccesses have changed, so reuse data is no longer available, new data must be generated
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
            //save contents of text box to file
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
            numSelQuantum.Enabled = false; //if FCFS is being used, quantum does not need to be set
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
            //when in algorithm comparison mode, no algorithm needs to be explicitly set, and quantum needs to be available to be set
            rbtnFCFS.Checked = false;
            rbtnRoundRobin.Checked = false;
            rbtnFCFS.Enabled = false;
            rbtnRoundRobin.Enabled = false;
            numSelQuantum.Enabled = true;
        }

        private void rbtnSingAlg_CheckedChanged(object sender, EventArgs e)
        {
            //when moving back to single algorithm mode, and start it out on FCFS, quantum is now disabled
            rbtnFCFS.Checked = true;
            rbtnRoundRobin.Checked = false;
            rbtnFCFS.Enabled = true;
            rbtnRoundRobin.Enabled = true;
            numSelQuantum.Enabled = false;
        }

        private void rbtnRoundRobin_CheckedChanged(object sender, EventArgs e)
        {
            numSelQuantum.Enabled = true; //make quantum available for round robin
        }

        private void lnklblAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnklblAuthor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.github.com/ChrisIossa"); //go to authors github on click
        }
    }
}
