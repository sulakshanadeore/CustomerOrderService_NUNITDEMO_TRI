using NUnit.Framework;
//Intall Nunit


namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class CustomerOrderServiceTests
    {

        [TestCase]
        public void When_PremiumCustomer_Expect_10PercentDiscount()
        {
            //Arrange
            Customer premiumCustomer = new Customer
            {
                CustomerId = 1,
                CustomerName = "George",
                CustomerType = CustomerType.Premium
            };

            Order order = new Order
            {
                OrderId = 1,
                ProductId = 212,
                ProductQuantity = 1,
                Amount = 150
            };

            CustomerOrderService customerOrderService = new CustomerOrderService();

            //Act
            customerOrderService.ApplyDiscount(premiumCustomer, order);

            //Assert
            Assert.Equals(order.Amount, 135);
        }



    }
}
