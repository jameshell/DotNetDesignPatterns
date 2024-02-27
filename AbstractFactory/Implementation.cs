namespace AbstractFactory;
/// <summary>
/// Abstract Factory
/// </summary>
public interface IShoppingCartFactory
{
    IDiscountService CreateDiscountService();
    IShippingCostsService CreateShippingCostsService();
}

/// <summary>
/// Abstract Product for discounts
/// </summary>
public interface IDiscountService
{
    int DiscountPercentage { get; }
}

/// <summary>
/// Abstract Product for shipping costs
/// </summary>
public interface IShippingCostsService
{
    decimal ShippingCosts { get; }
}

/// <summary>
/// Concrete Product for Colombia's Discounts
/// </summary>
public class ColombiaDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
}

/// <summary>
/// Concrete Product for Spain's Discounts
/// </summary>
public class SpainDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
}

/// <summary>
/// Concrete Product for Colombia's Shipping Costs
/// </summary>
public class ColombiaShippingCosts : IShippingCostsService
{
    public decimal ShippingCosts => 12;
}

/// <summary>
/// Concrete Product for Spain's Shipping Costs
/// </summary>
public class SpainShippingCosts : IShippingCostsService
{
    public decimal ShippingCosts => 15;
}

/// <summary>
/// Concrete Factory for Colombian Services
/// </summary>
public class ColombiaShoppingCartFactory : IShoppingCartFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new ColombiaDiscountService();
    }
    public IShippingCostsService CreateShippingCostsService()
    {
        return new ColombiaShippingCosts();
    }
}

/// <summary>
/// Concrete Factory for Spanish Services
/// </summary>
public class SpainShoppingCartFactory : IShoppingCartFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new SpainDiscountService();
    }
    public IShippingCostsService CreateShippingCostsService()
    {
        return new SpainShippingCosts();
    }
}

/// <summary>
/// Client class
/// </summary>
public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;
    private decimal _orderCosts;

    public ShoppingCart(IShoppingCartFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();
        // Assuming total cost of items is 300 USD
        _orderCosts = 300;
    }

    public void CalculateCosts()
    {
        Console.WriteLine($"Total Costs = {_orderCosts - (_orderCosts/100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
    }
}

