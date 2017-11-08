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
        private int maxProc = 0;
        private int waitProc = 0;
        private int currTime = 0;
        LinkedList<Process> processesLL;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            
        }
        
        private void fcfsAlg()
        {
            Random randGen = new Random();
            Queue<Process> processQueue;
            for (int i = 0; i < maxProc; i++)
            {
                processQueue.Enqueue(new Process(String.Concat("Process ", (i + 1).ToString()), randGen.Next(1, 100), i));
                System.Console.WriteLine("Added Process " + i+1 + ".");
                System.Console.WriteLine("Priority: " + i + ".");
                System.Console.WriteLine("Burst Time:" )
            }
        }
    }
}
