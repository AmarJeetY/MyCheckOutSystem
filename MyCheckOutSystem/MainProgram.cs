
namespace MyCheckOutSystem
{
    public class MainProgram 
    {
        public double PurchaseItems(InitialiseCart purchaseRequest)
        {
            var mycart = new CartOperations(purchaseRequest.ItemsInCart);
            return Calculate.CalculateTotalCost(purchaseRequest.ItemsInCart);
        }
    }
}
