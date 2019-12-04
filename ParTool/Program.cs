﻿// -------------------------------------------------------
// © Kaplas. Licensed under MIT. See LICENSE for details.
// -------------------------------------------------------
namespace ParTool
{
    using System;
    using CommandLine;

    /// <summary>
    /// Main program.
    /// </summary>
    internal static partial class Program
    {
        private static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<Options.List, Options.Extract, Options.Create, Options.Remove, Options.Add>(args)
                .WithParsed<Options.List>(List)
                .WithParsed<Options.Extract>(Extract)
                .WithParsed<Options.Create>(Create)
                .WithParsed<Options.Remove>(Remove)
                .WithParsed<Options.Add>(Add);
        }

        private static void WriteHeader()
        {
            Console.WriteLine(CommandLine.Text.HeadingInfo.Default);
            Console.WriteLine(CommandLine.Text.CopyrightInfo.Default);
            Console.WriteLine();
        }
    }
}
