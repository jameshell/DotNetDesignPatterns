using FactoryMethod;

Console.Title = "Factory Method";

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("CO")
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine(
        $"Discount Service: {discountService}, Discount Percentage: {discountService.DiscountPercentage}%");
}