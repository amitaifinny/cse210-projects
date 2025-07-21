using System.ComponentModel.DataAnnotations;

public class Product
{
    private string _name;
    private string _id;
    private decimal _price;
    private int _quantity;

    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public decimal CalculateProductCost()
    {
        return _price * _quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product name(ID: {_id}): {_name}\nPrice: {CalculateProductCost()}\nQuantity: {_quantity}");
    }

    public string DisplayPackingLabel()
    {
        return $"{_name}({_id})\n";
    }
}