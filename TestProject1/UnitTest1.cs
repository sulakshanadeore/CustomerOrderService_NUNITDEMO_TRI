using CustomerOrderService;
namespace TestProject1
{
    [TestFixture]
    public class CustomerOrderServiceTests
    {

        [Test]
        public void Test1()
        {
            Assert.That(1 == 1);

        }

        [Test]
        public void When_PremiumCustomer_Expect_10PercentDiscount()
        {
            //Arrange
            Customer premiumCustomer = new Customer
            {
                CustomerId = 2,
                CustomerName = "George",
                CustomerType = CustomerType.Premium
            };

            Order order = new Order
            {
                OrderId = 201,
                ProductId = 212,
                ProductQuantity = 1,
                Amount = 100
            };

            CustomerOService customerOrderService = new CustomerOService();

            //Act
            customerOrderService.ApplyDiscount(premiumCustomer, order);

            //Assert--check
            Assert.AreEqual(order.Amount,90);
        }


        [TestCase]
        public void When_SpecialCustomer_Expect_20PercentDiscount()
        {
            //Arrange
            Customer specialCustomer = new Customer
            {
                CustomerId = 1,
                CustomerName = "George",
                CustomerType = CustomerType.SpecialCustomer
            };

            Order order1 = new Order
            {
                OrderId = 1,
                ProductId = 212,
                ProductQuantity = 1,
                Amount = 150
            };

            CustomerOService customerOrderService1 = new CustomerOService();

            //Act
            customerOrderService1.ApplyDiscount(specialCustomer, order1);

            //Assert--check
            Assert.AreEqual(order1.Amount, 120);
        }


    }
}