using System.Collections.Generic;

namespace MyCheckOutSystem
{
    public class InitialiseCart
    {
        public Dictionary<string, int> ItemsInCart;
        public InitialiseCart()
        {
            ItemsInCart = new Dictionary<string, int>();
        }
    }
}
