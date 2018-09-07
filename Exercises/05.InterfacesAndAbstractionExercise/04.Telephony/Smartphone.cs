using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Smartphone : IBrowse, ICall
{
    public Smartphone()
    {
    }
   public void Browse(string site)
    {
        if (site.Any(c => char.IsDigit(c))/* || string.IsNullOrWhiteSpace(site)*/)
        {
            Console.WriteLine($"Invalid URL!");
            return;
        }
        if (site == null)
        {
            site = "" ;
        }
        Console.WriteLine($"Browsing: {site}!");
    }

    public void MakeCall(string number)
    {
        if (!number.All(c=>char.IsDigit(c)))
        {
            Console.WriteLine("Invalid number!");
            return;
        }
        Console.WriteLine($"Calling... {number}");
    }
}

