using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCheckOutSystem
{
    public class Calculate
    {
        public static double CalculateTotalCost(Dictionary<string,int> AllItemsInCart)
        {
            var fruitprice = new FruitListAndPrices();
            var finalcost = 0.0;
            foreach (var item in AllItemsInCart)
            {
                if (fruitprice.FruitPrices.ContainsKey(item.Key))
                {
                    var priceOfFruit = fruitprice.FruitPrices[item.Key];
                    var quantityOfFruit = item.Value;
                    var cost = priceOfFruit * quantityOfFruit;
                    finalcost += cost;
                }
                
            }
            return finalcost;
        }
    }
}
