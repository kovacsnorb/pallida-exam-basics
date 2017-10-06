using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class Program
    {
        static void Main(string[] args)
        {
            var candyShop = new CandyShop(300);
            candyShop.CreateCandy();
            candyShop.CreateLollipop();


            Console.WriteLine(candyShop.totalSugar);
            Console.ReadLine();
        }
    }
}
