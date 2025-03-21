using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class PrintMedia
    {
        public string Title { get; set; }
        public PrintMedia(string title)
        {
            Title = title;
        }
        public abstract double CalculateTotalCost();
        public abstract void PrintInfo();
    }
}
