﻿using System;
using System.Collections.Generic;
using System.Linq;
using MIPS.Architecture;
using MIPS.Debugger;
using System.Windows.Forms;

namespace MIPS.Simulator
{
    static class Program
    {
        const string path = @"C:\Program Files (x86)\CodeSourcery\Sourcery_CodeBench_Lite_for_MIPS_ELF\bin";
        const string prefix = "mips-sde-elf";
        const string program = "program.elf";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Hypothetical Machine Simulator based on MIPS, written by Josh Wyant");

            // Create a program
            //var toolchain = new ElfToolchain(path, prefix);
            //var lib = new[] { "syscalls.c" };
            //var sources = new[] { "source.c" };
            //toolchain.ExecuteTool("gcc", string.Format("-o {0} {1}", program, string.Join(" ", sources.Union(lib))));

            // Create a new MIPS machine with 32MB of RAM.
            Machine mips = new Machine(32); 

            // Map the stack and video memory
            mips.Memory.Map(0x7FFF0000, 0xFFFFFFFC, 0x00C00000); // Stack
            mips.Memory.Map(0x80000000, 0x007FFFFC, 0x00100000); // Video memory

            // Load the program
            mips.LoadElf(program, 0x00800000);

            Application.EnableVisualStyles();
            Application.Run(new DebugForm(mips));
        }
    }
}
