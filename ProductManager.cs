using System;
using System.Collections.Generic;
using System.Linq;

public class ProductManager
{
    private List<Product> products;

    public ProductManager()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if (products.Any(p => p.ProductID == product.ProductID))
        {
            throw new InvalidDataException("Product already exists.");
        }
        products.Add(product);
    }

    public void UpdateProduct(int productId, string name, decimal price)
    {
        var product = products.FirstOrDefault(p => p.ProductID == productId);
        if (product == null)
        {
            throw new InvalidDataException("Product not found.");
        }
        product.UpdateProductInfo(name, price);
    }

    public void RemoveProduct(int productId)
    {
        var product = products.FirstOrDefault(p => p.ProductID == productId);
        if (product == null)
        {
            throw new InvalidDataException("Product not found.");
        }
        products.Remove(product);
    }

    public Product GetProductById(int productId)
    {
#pragma warning disable CS8603 // Possible null reference return.
        return products.FirstOrDefault(p => p.ProductID == productId);
#pragma warning restore CS8603 // Possible null reference return.
    }

    public void ListProducts()
    {
        foreach (var product in products)
        {
            product.GetProductDetails();
        }
    }
}
