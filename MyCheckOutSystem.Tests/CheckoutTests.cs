using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCheckOutSystem.Tests
{
    [TestClass()]
    public class CheckoutTests
    {
        [TestMethod()]
        public void Should_Return_Total_Cost_When_Valid_Item_And_Price_Is_Added_To_Cart()
        {
            // Arrange
            var expectedPrice = 675;
            var main = new MainProgram();
            var myCart = new InitialiseCart();
            // Act
            myCart.ItemsInCart.Add("Apple",10);
            myCart.ItemsInCart.Add("Orange",3);
            var actualPrice = main.PurchaseItems(myCart);
            // Assert
            Assert.AreEqual(expectedPrice,actualPrice,$"Actaul price does not match with expected price");
        }

        [TestMethod()]
        public void Should_Return_Total_Cost_When_Items_Added_To_Existing_Cart()
        {
            // Arrange
            const int expectedPrice = 675;
            var main = new MainProgram();
            var myCart = new InitialiseCart();
            // Act
            myCart.ItemsInCart.Add("Apple", 10);
            new CartOperations(myCart.ItemsInCart).AddItem("Orange", 3);
            var actualPrice = main.PurchaseItems(myCart);
            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, $"Actual price does not match with expected price");
        }

        [TestMethod()]
        public void Should_Return_Total_Cost_When_Items_Removed_From_Existing_Cart()
        {
            // Arrange
            var expectedPrice = 600;
            var main = new MainProgram();
            var myCart = new InitialiseCart();
            // Act
            myCart.ItemsInCart.Add("Apple", 10);
            myCart.ItemsInCart.Add("Orange", 3);
            new CartOperations(myCart.ItemsInCart).DeleteItem("Orange", 3);
            var actualPrice = main.PurchaseItems(myCart);
            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, $"Actaul price does not match with expected price");
        }

        [TestMethod()]
        public void Should_Return_Total_Cost_When_Item_Quantity_Updated_From_Existing_Cart()
        {
            // Arrange
            var expectedPrice = 750;
            var main = new MainProgram();
            var myCart = new InitialiseCart();
            // Act
            myCart.ItemsInCart.Add("Apple", 10);
            myCart.ItemsInCart.Add("Orange", 3);
            new CartOperations(myCart.ItemsInCart).UpdateItem("Orange", 3);
            var actualPrice = main.PurchaseItems(myCart);
            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, $"Actaul price does not match with expected price");
        }

        [TestMethod()]
        public void Should_Return_Total_Cost_As_Zero_When_No_Items_Added_To_Cart()
        {
            // Arrange
            const double expectedPrice = 0.0;
            var main = new MainProgram();
            var myCart = new InitialiseCart();
            // Act
            new CartOperations(myCart.ItemsInCart);
            var actualPrice = main.PurchaseItems(myCart);
            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, $"Actaul price does not match with expected price");
        }

        [TestMethod()]
        public void Should_Return_Total_Cost_When_Invalid_Item_Is_Added_In_Cart()
        {
            // Arrange
            const int expectedPrice = 0;
            var main = new MainProgram();
            var myCart = new InitialiseCart();
            // Act
            myCart.ItemsInCart.Add("Mango", 10);
            var actualPrice = main.PurchaseItems(myCart);
            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, $"Actaul price does not match with expected price");
        }
        [TestMethod()]
        public void Should_Return_Total_Cost_When_Valid_And_InValid_Items_Are_Added_In_Cart()
        {
            // Arrange
            var expectedPrice = 250;
            var main = new MainProgram();
            var myCart = new InitialiseCart();
            // Act
            myCart.ItemsInCart.Add("Orange", 10);
            myCart.ItemsInCart.Add("Mango", 100000);
            var actualPrice = main.PurchaseItems(myCart);
            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, $"Actaul price does not match with expected price");
        }

        [TestMethod()]
        public void Should_Return_Total_Cost_When_Items_With_Zero_Quantity_Are_Added_In_Cart()
        {
            // Arrange
            const int expectedPrice = 0;
            var main = new MainProgram();
            var myCart = new InitialiseCart();
            // Act
            myCart.ItemsInCart.Add("Orange", 0);
            myCart.ItemsInCart.Add("Apple", 0);
            var actualPrice = main.PurchaseItems(myCart);
            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, $"Actaul price does not match with expected price");
        }
    }
}






