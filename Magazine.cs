using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Magazine : PrintMedia
    {
        public int Circulation { get; set; } 
        public double Price { get; set; }    

        public Magazine(string title, int circulation, double price) : base(title)
        {
            Circulation = circulation;
            Price = price;
        }

        public override double CalculateTotalCost()
        {
            return Circulation * Price;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Журнал: {Title}, Тираж: {Circulation}, Цена за шт.: {Price} руб., Общая стоимость: {CalculateTotalCost()} руб.");
        }
    }
}
