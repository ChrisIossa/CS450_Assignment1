
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
    public partial class Form1 : Form
    {
        //private member variables
        private int maxProc = 10; //number of processes specefied by the user
        private int totalSeconds = 0;
        //private int currTime = 0;
        private Queue<Process> processQueueCpy;
        private LinkedList<Process> processesLL;
        private Random randGen = new Random(); //RNG needed to randomly generate values

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rbtnFCFS.Checked)
            {
                fcfsAlg();
                totalSeconds = 0;
            }
            else
            {
               
            }
        }

        private void fcfsAlg()
        {
            Queue<Process> processQueue = new Queue<Process>(); //queue to store processes waiting for CPU
            
            //DateTime internalClock;
            for (int i = 0; i < maxProc; i++)
            {
                if (i == 0)
                {
                    //this is the first element, it's wait time is 0, since it is the first in the FIFO, and executes immediately
                    processQueue.Enqueue(new Process(String.Concat("Process ", (i + 1).ToString()), randGen.Next(1, 100), i));
                }
                else
                {
                    processQueue.Enqueue(new Process(String.Concat("Process ", (i + 1).ToString()), randGen.Next(1, 100), i, processQueue.ElementAt(i - 1).getTurnaroundTime()));
                }

                txtConsole.AppendText("[" + processQueue.ElementAt(i).getArrvTime().ToString("h:mm:ss.fff tt") + "] Added " + processQueue.ElementAt(i).getProcName() + ".\r\n");
                txtConsole.AppendText("\t            Priority: " + processQueue.ElementAt(i).getPriority() + ".\r\n");
                txtConsole.AppendText("\t            Burst Time: " + processQueue.ElementAt(i).getBurstTime() + "\r\n");
                txtConsole.AppendText("\r\n");
            }

            while (processQueue.Count != 0)
            {
                txtConsole.AppendText("[" + processQueue.Peek().getTurnaroundTime().ToString("h:mm:ss.fff tt") + "] " + processQueue.Peek().getProcName() + " has finished executing.\r\n\r\n\r\n");
                totalSeconds += processQueue.Peek().getWaitTimeSec();
                processQueue.Dequeue();
                txtAvgWaitTime.Text = String.Concat((totalSeconds / (maxProc - processQueue.Count)).ToString(), " seconds");
            }

            txtConsole.AppendText("\r\n");

        }

        private void numSelProcCnt_ValueChanged(object sender, EventArgs e)
        {
            maxProc = Convert.ToInt32(numSelProcCnt.Value);
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

        private void lblAvgWait_Click(object sender, EventArgs e)
        {

        }

        private void rbtnReuseDataY_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnReuseDataN_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnFCFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
        }
    }
}
