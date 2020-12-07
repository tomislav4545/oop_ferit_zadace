using System;
using System.IO;

namespace IPrinterNamespace
{
    public interface IPrinter
    {
        void Print(string season);
    }
    public class ConsolePrinter : IPrinter
    {
        public void Print(string season)
        {
            Console.WriteLine(season);
        }
    }


    public class FilePrinter : IPrinter
    {
        string fileName;
        public FilePrinter(string fileName)
        {
            this.fileName = fileName;
        }
        
        public void Print(string season)
        {
            File.WriteAllText($"{fileName}", season);
        }
    }
}

