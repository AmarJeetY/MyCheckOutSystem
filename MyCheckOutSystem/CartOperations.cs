using System.Collections.Generic;

namespace MyCheckOutSystem
{
    public class CartOperations
    {
        public Dictionary<string, int> Mycart;
        public CartOperations(Dictionary<string, int> cart)
        {
            Mycart = cart;
        }
        
        public void AddItem(string itemname, int itemquantity)
        {
            Mycart.Add(itemname,itemquantity);
        }

        public void UpdateItem(string itemname, int itemquantity)
        {
            Mycart[itemname] += itemquantity;
        }

        public void DeleteItem(string itemname, int itemquantity)
        {
            Mycart.Remove(itemname);
        }
    }
}