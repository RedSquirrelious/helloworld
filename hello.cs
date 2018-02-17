using System;
using System.Collections.Generic;
using System.Text;

namespace CommandLine
{
    public class Greetings
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0} args passed in", args.Length);
            Echo.Goodbye bye = new Echo.Goodbye(args);
            int linesDumped = 0;
            linesDumped = bye.DumpArgs();
            Console.WriteLine("{0} lines dumped", linesDumped);
        }
    }

}