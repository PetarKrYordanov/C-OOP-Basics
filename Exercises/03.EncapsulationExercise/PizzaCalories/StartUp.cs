using System;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var pizzaArgs = Console.ReadLine().Split(' ');
        try
        {
        var pizza = new Pizza(pizzaArgs[1]);                

        var doughArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var dough = new Dough(doughArgs[1],doughArgs[2],double.Parse(doughArgs[3]));
        pizza.dough = dough;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                var toppingArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1)
                    .ToArray();

                var topping = new Topping(toppingArgs[0], double.Parse(toppingArgs[1]));
                pizza.AddTopping(topping);
            }
            Console.WriteLine(pizza.ToString());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }
    }
}

