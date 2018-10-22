using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    public List<Product> products;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;

        products = new List<Product>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Trim()==string.Empty)
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
        
    }

    public decimal Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            else
            this.money = value;
        }
    }

    public bool BuyStock(Product product)
    {
        if (this.Money-product.Cost>=0)
        {
            this.Money -= product.Cost;
            this.products.Add(product);
            return true;
        }
        return false; 
    }
}

