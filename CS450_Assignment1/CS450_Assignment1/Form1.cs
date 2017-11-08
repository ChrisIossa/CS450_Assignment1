using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS450_Assignment1
{
    public partial class Form1 : Form
    {
        //private member variables
        private int maxProc = 10; //number of processes specefied by the user
        private int totalSeconds = 0;
        //private int currTime = 0;
        LinkedList<Process> processesLL;
        Random randGen = new Random(); //RNG needed to randomly generate values

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(rbtnFCFS.Checked)
            {
                fcfsAlg();
            }
        }
        
        private void fcfsAlg()
        {
            
            Queue<Process> processQueue = new Queue<Process>(); //queue to store processes waiting for CPU
            DateTime internalClock;
            for (int i = 0; i < maxProc; i++)
            {
                if (i == 0)
                {
                    processQueue.Enqueue(new Process(String.Concat("Process ", (i + 1).ToString()), randGen.Next(1, 100), i));
                }
                else
                {
                    processQueue.Enqueue(new Process(String.Concat("Process ", (i + 1).ToString()), randGen.Next(1, 100), i, processQueue.ElementAt(i-1).getTurnaroundTime()));
                }
                
                txtConsole.AppendText("["+processQueue.ElementAt(i).getArrvTime().ToString("h:mm:ss.fff tt") + "] Added " + processQueue.ElementAt(i).getProcName() + ".\n");
                txtConsole.AppendText("\t            Priority: " + processQueue.ElementAt(i).getPriority() + ".\n");
                txtConsole.AppendText("\t            Burst Time: " + processQueue.ElementAt(i).getBurstTime() +"\n");
                
                txtConsole.AppendText("\n");
                if (i == 0)
                {
                    internalClock = processQueue.Peek().getArrvTime();
                    txtConsole.AppendText("[" + processQueue.Peek().getArrvTime().ToString("h:mm:ss.fff tt") + "] " + processQueue.Peek().getProcName() + " now executing.\n");
                    txtConsole.AppendText("[" + processQueue.Peek().getArrvTime().ToString("h:mm:ss.fff tt") + "] " + processQueue.Peek().getProcName() + " now finished.\n"")

                }
            }
           
        }
    }
}
