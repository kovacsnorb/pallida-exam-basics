using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class Sweets
    {
        protected float price;
        protected int sugarNeededToMakeOne;
        protected string typeOfSweet;

        public int GetSugarNeededToMakeOne()
        {
            return sugarNeededToMakeOne;
        }

        public string GetTypeOfSweet()
        {
            return typeOfSweet;
        }

        public float GetPrice()
        {
            return price;
        }

        public void SetPrice(float newPrice)
        {
            this.price = newPrice;
        }
    }
}
