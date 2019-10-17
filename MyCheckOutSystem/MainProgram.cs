
namespace MyCheckOutSystem
{
    public class MainProgram 
    {
        public double PurchaseItems(InitialiseCart purchaseRequest)
        {
            return Calculate.CalculateTotalCost(purchaseRequest.ItemsInCart);
        }
    }
}
