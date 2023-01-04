using Strategy;

var shoppingBag1 = new ShoppingMall(new LowDiscountStrategy())
{
    CustomerName = "Rafi Samnan",
    BillingAmmount = 1000
};

var shoppingBag2 = new ShoppingMall(new HighDiscountStrategy())
{
    CustomerName = "Manik Hossain",
    BillingAmmount = 1000
};

var shoppingBag3 = new ShoppingMall(new NoDiscountStrategy())
{
    CustomerName = "Nayeem Rahman",
    BillingAmmount = 1000
};

Console.WriteLine(shoppingBag1.GetBillingAmmount());
Console.WriteLine(shoppingBag2.GetBillingAmmount());
Console.WriteLine(shoppingBag3.GetBillingAmmount());