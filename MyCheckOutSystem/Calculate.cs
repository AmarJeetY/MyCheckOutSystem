
using System.Collections.Generic;
using System.Linq;

namespace MyCheckOutSystem
{
    public class Calculate
    {
        public static double CalculateTotalCost(Dictionary<string,int> allItemsInCart)
        {
            var fruitPrice = new FruitListAndPrices();
            return (from item in allItemsInCart where fruitPrice.FruitPrices.ContainsKey(item.Key) let priceOfFruit = fruitPrice.FruitPrices[item.Key] let quantityOfFruit = item.Value select priceOfFruit * quantityOfFruit).Aggregate(0.0, (current, cost) => current + cost);
        }
    }
}