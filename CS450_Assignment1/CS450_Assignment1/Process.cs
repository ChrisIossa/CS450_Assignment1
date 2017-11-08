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
        public Process()
        {

        }

        //constructor with varaibles passed as parameters
        public Process(String nameIn, int burstIn, int priorIn)
        {
            procName = nameIn;
            burstTime = burstIn;
            priority = priorIn;
            arrvTime = DateTime.Now;
            waitTime = arrvTime;
        }

        public Process(String nameIn, int burstIn, int priorIn, DateTime waitIn)
        {
            procName = nameIn;
            burstTime = burstIn;
            priority = priorIn;
            arrvTime = DateTime.Now;
            waitTime = waitIn;
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

        public void setWaitTime(DateTime waitIn)
        {
            waitTime = waitIn;
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

        public DateTime getWaitTime()
        {
            return waitTime;
        }

        public int getWaitTimeSec()
        {
            return (waitTime.Subtract(arrvTime).Seconds);
        }

        public DateTime getTurnaroundTime()
        {
            if (waitTime != arrvTime)
            {
                return waitTime.AddSeconds(burstTime);
            }
            else
            {
                return arrvTime.AddSeconds(burstTime);
            }
        }

        //member variables
        private String procName = "";
        private int burstTime = 0;
        private int priority = 0;
        private DateTime arrvTime;
        private DateTime waitTime;
    }
}
