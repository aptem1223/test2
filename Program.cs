using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

          Magazine magazine = new Magazine("Tech Today", 5000, 150);
          Newspaper newspaper = new Newspaper("Daily News", 12, 2.5, 10000);

          magazine.PrintInfo();
          newspaper.PrintInfo();
          
        }
    }
}
