using System.Collections.Generic;

namespace MyCheckOutSystem
{
    class FruitListAndPrices
    {
        public IDictionary<string, int> FruitPrices = new Dictionary<string, int>
        {
            {"Apple", 60},
            {"Orange", 25}
            // Add new fruits and their prices here.
        };
    }

}