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
        private float raisePercentage;
        List<Sweets> inventory;

        public CandyShop(int sugarIncome)
        {
            this.totalSugar = sugarIncome;
            inventory = new List<Sweets>();
        }

        public void CreateCandy()
        {
            inventory.Add(new Candies());
            totalSugar -= inventory[inventory.Count - 1].GetSugarNeededToMakeOne();
        }

        public void SellCandy(int numberToSell)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].GetTypeOfSweet() == "candy")
                {
                    incomeMoney += inventory[i].GetPrice();
                    inventory.Remove(inventory[i]);
                    numberToSell--;
                    if (numberToSell == 0)
                    {
                        return;
                    }
                }
            }
        }

        public void CreateLollipop()
        {
            inventory.Add(new Lollipops());
            totalSugar -= inventory[inventory.Count - 1].GetSugarNeededToMakeOne();
        }

        public void SellLollipop(int numberToSell)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].GetTypeOfSweet() == "lollipop")
                {
                    incomeMoney += inventory[i].GetPrice();
                    inventory.Remove(inventory[i]);
                    numberToSell--;
                    if (numberToSell == 0)
                    {
                        return;
                    }
                }
            }
        }

        public void PrintInfo()
        {
            int inventorySum = inventory.Count;
            int candyCounter = 0;
            int lolliCounter = 0;

            foreach (Sweets sweet in inventory)
            {
                if (sweet.GetTypeOfSweet() == "candy")
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

        public void RaisePrice(float percentage)
        {
            this.raisePercentage = percentage;
        }
    }
}
