using System;
using FileMeta;
using System.Diagnostics;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.Assembly.GetExecutingAssembly()

            var metadata = new AssemblyMetadata(typeof(Program));
            foreach(var prop in metadata.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(metadata)}");
            }
        }

    }
}
