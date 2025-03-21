using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Newspaper : PrintMedia
    {
        public int PageCount { get; set; } 
        public double PageCost { get; set; }
        public int Circulation { get; set; } 

        public Newspaper(string title, int pageCount, double pageCost, int circulation) : base(title)
        {
            PageCount = pageCount;
            PageCost = pageCost;
            Circulation = circulation;
        }

        public override double CalculateTotalCost()
        {
            return PageCount * PageCost * Circulation;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Газета: {Title}, Листов: {PageCount}, Цена листа: {PageCost} руб., Тираж: {Circulation}, Общая стоимость: {CalculateTotalCost()} руб.");
        }
    }
}
