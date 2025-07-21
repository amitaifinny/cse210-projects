public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public decimal CalculateTotal()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.CalculateProductCost();

        }
            if (_customer.HasUsaCitizenship())
            {
                totalCost += 5;
        
            }
            else
            {
                totalCost += 35;
            }

        return totalCost;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += product.DisplayPackingLabel();
        
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomerInformation();
    }

}