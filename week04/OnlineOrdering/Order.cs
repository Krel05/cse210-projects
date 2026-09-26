public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCostOfOrder()
    {
        int shippingCost;
        double totalCost = 0;
        if (_customer.CustomerInUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost() + (0.1 * shippingCost);
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var p in _products)
        {
            packingLabel += $"{p.GetName()}, {p.GetId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"{_customer.GetName()}: {_customer.GetAddress()}";
        return shippingLabel;
    }
}