public class Product
{
    private string _name;
    private int _product_id;
    private double _price;
    private int _quantity;

    public Product(string name, int product_id, double price, int quantity)
    {
        _name = name;
        _product_id = product_id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCostProduct()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _product_id;
    }
}