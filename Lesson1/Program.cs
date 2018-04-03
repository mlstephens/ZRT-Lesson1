﻿using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = string.Empty;
            CommandLineArguments commandLineArgs = new CommandLineArguments(args);

            if (commandLineArgs.HaveValidArguments())
            {
                message = $"Hello World - { commandLineArgs.FormatForDisplay() }";
            }
            else
            {
                message = "Valid command line example: Commandline arg1=test arg2=name";
            }

            Console.WriteLine(message);
        }
    }
}
