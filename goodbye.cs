using System;
using System.Collections.Generic;
using System.Text;

namespace Echo
{
    public class Goodbye
    {
        public string[] ArgsPassedIn;

        public Goodbye(string[] args)
        {
            ArgsPassedIn = args;
        }

        public int DumpArgs()
        {
            int lineCounter = 0;
            foreach (string currArg in ArgsPassedIn)
            {
                Console.WriteLine(currArg);
                lineCounter++;
            }
            return lineCounter;
        }
    }

}