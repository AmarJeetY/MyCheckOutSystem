using System.Collections.Generic;

namespace MyCheckOutSystem
{
    public class CartOperations
    {
        public Dictionary<string, int> MyCart;
        public CartOperations(Dictionary<string, int> cart)
        {
            MyCart = cart;
        }
        
        public void AddItem(string itemName, int itemQuantity)
        {
            MyCart.Add(itemName,itemQuantity);
        }

        public void UpdateItem(string itemName, int itemQuantity)
        {
            MyCart[itemName] += itemQuantity;
        }

        public void DeleteItem(string itemName, int itemQuantity)
        {
            MyCart.Remove(itemName);
        }
    }
}