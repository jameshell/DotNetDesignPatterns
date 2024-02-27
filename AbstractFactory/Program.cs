// See https://aka.ms/new-console-template for more information

using AbstractFactory;

Console.Title = "Abstract Factory";

var colombiaShoppingCartFactory = new ColombiaShoppingCartFactory();
var shoppingCart = new ShoppingCart(colombiaShoppingCartFactory);
shoppingCart.CalculateCosts();

var spainShoppingCartFactory = new SpainShoppingCartFactory();
var shoppingCart2 = new ShoppingCart(spainShoppingCartFactory);
shoppingCart2.CalculateCosts();