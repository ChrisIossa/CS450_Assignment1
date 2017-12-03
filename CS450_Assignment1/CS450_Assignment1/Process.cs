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

        // constructor with varaibles passed as parameters, and no wait time. 
        // Used for first process, which has no wait time, as it executes as soon as it is created
        public Process(String nameIn, int burstIn, int priorIn, bool isFCFS)
        {
            procName = nameIn;
            burstTime = burstIn;
            priority = priorIn;
            arrvTime = 0;
            startTime = arrvTime;
            if(!isFCFS)
            {
                burstRemaining = burstTime;
                completed = false;
                started = false;
            }
        }

        public Process(String nameIn, int burstIn, int priorIn, int arrvIn, bool isFCFS)
        {
            procName = nameIn;
            burstTime = burstIn;
            priority = priorIn;
            arrvTime = arrvIn;
            startTime = arrvTime;
            if (!isFCFS)
            {
                burstRemaining = burstTime;
                completed = false;
                started = false;
            }
        }

        public Process(String nameIn, int burstIn, int priorIn, int startIn, int arrvIn, bool isFCFS)
        {
            procName = nameIn;
            burstTime = burstIn;
            priority = priorIn;
            arrvTime = arrvIn;
            completed = false;
            started = false;
            if (startIn > arrvIn)
            {
                startTime = startIn;
            }
            else
            {
                startTime = arrvTime;
            }

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

        public void setArrvTime(int arrvIn)
        {
            arrvTime = arrvIn;
        }

        public void setStartTime(int startIn, bool isFCFS)
        {
            if (isFCFS)
            {
                if (startIn > arrvTime)
                {
                    startTime = startIn;
                }
                else
                {
                    startTime = arrvTime;
                }
            }
            else
            {
                startTime = startIn;
            }
        }
        
        public void setBurstRemaining(int burstRemIn)
        {
            burstRemaining = burstRemIn;
        }

        public int giveSlice(int quantum, int internalTime)
        {
            if(!started)
            {
                started = true;
                startTime = internalTime;
            }
            if(burstRemaining>quantum)
            {
                burstRemaining -= quantum;
                return quantum;
            }
            else
            {
                int timeUsed = burstRemaining;
                burstRemaining = 0;
                return timeUsed;
            }


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

        public int getBurstRem()
        {
            return burstRemaining;
        }

        public int getPriority()
        {
            return priority;
        }

        public int getArrvTime()
        {
            return arrvTime;
        }

        public void setCompletionTime(int compTimeIn)
        {
            if (!completed)
            {
                compTime = compTimeIn;
                completed = true;
            }
        }

        public int getWaitTime(bool isFCFS)
        {
            return getTurnaroundTime(isFCFS) - burstTime;
        }

        public int getTurnaroundTime(bool isFCFS)
        {
            return getCompletionTime(isFCFS) - arrvTime;
        }

        public int getCompletionTime(bool isFCFS)
        {
            if (isFCFS)
            {
                return startTime + burstTime;
            }
            else
            {
                return compTime;
            }
        }

        public int getBurstRemain()
        {
            return burstRemaining;
        }
        
        public int getStartTime()
        {
            return startTime;
        }

        public bool isCompleted()
        {
            return completed;
        }


        //member variables
        private String procName = "";
        private int burstTime = 0;
        private int priority = 0;
        private int arrvTime = 0;
        private int startTime = 0;
        private int burstRemaining = 0;
        private int compTime = 0;
        private bool completed = false;
        private bool started = false;

    }
}
