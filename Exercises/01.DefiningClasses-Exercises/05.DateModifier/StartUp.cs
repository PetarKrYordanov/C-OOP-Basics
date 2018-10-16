using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

          int difference =  DateModifier.GetDifferenceBetween(firstDate, secondDate);
        Console.WriteLine(difference);
        }
    }
