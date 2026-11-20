using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotalCost()
    {
        double productsTotal = 0;

        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUsa() ? 5.0 : 35.0;
        return productsTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");

        foreach (Product product in _products)
        {
            sb.AppendLine($"- {product.GetName()} (ID: {product.GetProductId()})");
        }

        return sb.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetShippingLabel()}";
    }
}