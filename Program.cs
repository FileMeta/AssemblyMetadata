using System;
using FileMeta;
using System.Diagnostics;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var metadata = new AssemblyMetadata(typeof(Program));
            Console.WriteLine(metadata.Summary);
        }

    }
}
