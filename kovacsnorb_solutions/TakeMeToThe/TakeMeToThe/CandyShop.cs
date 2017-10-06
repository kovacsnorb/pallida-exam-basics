using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop
    {
        public int totalSugar;
        public float incomeMoney;
        List<Sweets> inventory;

        public CandyShop(int sugarIncome)
        {
            this.totalSugar = sugarIncome;
            inventory = new List<Sweets>();
        }

        public void CreateCandy()
        {
            inventory.Add(new Candies());
            totalSugar -= inventory[inventory.Count - 1].sugarNeededToMakeOne;
        }

        public void CreateLollipop()
        {
            inventory.Add(new Lollipops());
            totalSugar -= inventory[inventory.Count - 1].sugarNeededToMakeOne;
        }

        public void PrintInfo()
        {
            int inventorySum = inventory.Count;
            int candyCounter = 0;
            int lolliCounter = 0;

            foreach (Sweets sweet in inventory)
            {
                if (sweet.typeOfSweet == "candy")
                {
                    candyCounter++;
                }
                else
                {
                    lolliCounter++;
                }
            }

            Console.WriteLine("Inventory: totally {0} sweets: {1} candies, {2} lollipops. Income: {3}$, Sugar: {4}gr."
                , inventorySum, candyCounter, lolliCounter, incomeMoney, totalSugar);
        }
    }
}
