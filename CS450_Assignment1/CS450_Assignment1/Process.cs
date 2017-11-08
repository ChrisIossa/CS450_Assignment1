using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS450_Assignment1
{
    class Process
    {
        //empty constructor, never used by me
        Process()
        {

        }

        //constructor with varaibles passed as parameters
        Process(String nameIn, int burstIn, int priorIn)
        {
            procName = nameIn;
            burstTime = burstIn;
            priority = priorIn;
            arrvTime = DateTime.Now;
        }


       //seters for member variables

        public void setProcName(String nameIn)
        {
            procName = nameIn;
        }

        public void setBurstTime(int burstIn)
        {
            burstTime = burstIn;
        }

        public void setPriority(int priorIn)
        {
            priority = priorIn;
        }

        public void setArrvTime(DateTime arrvIn)
        {
            arrvTime = arrvIn;
        }

        // getters for member variables

        public String getProcName()
        {
            return procName;
        }

        public int getBurstTime()
        {
            return burstTime;
        }    

        public int getPriority()
        {
            return priority;
        }

        public DateTime getArrvTime()
        {
            return arrvTime;
        }



        //member variables
        private String procName = "";
        private int burstTime = 0;
        private int priority = 0;
        private DateTime arrvTime;
    }
}
