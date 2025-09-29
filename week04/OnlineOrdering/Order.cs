public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double totalCost = 0.0;
        for (int i = 0; i < _products.Count(); i++)
        {
            totalCost += _products[i].GetTotalCostProduct();
            //Console.WriteLine(totalCost);
        }


        double shipping_cost = 0.0;
        if (_customer.GetLivesInUSA())
        {
            shipping_cost = 5.00;
        }
        else
        {
            shipping_cost = 35.00;
        }

        return Math.Round(totalCost + shipping_cost,2);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        for (int i = 0; i < _products.Count(); i++)
        {
            packingLabel += $"{_products[i].GetName()}  {_products[i].GetProductId()} \n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customer.GetName()} \n" +
            $"{_customer.GetAddress()}";
    }
}