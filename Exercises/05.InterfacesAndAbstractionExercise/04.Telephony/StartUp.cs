using System;
public class StartUp
{
    static void Main(string[] args)
    {
        var smartphone = new Smartphone();
        var inputNumbers = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        var inputWebsites = Console.ReadLine().Split(new char[] { ' ', '\t' });

        foreach (var number in inputNumbers)
        {
            smartphone.MakeCall(number);
        }

        foreach (var website in inputWebsites)
        {
            smartphone.Browse(website);
        }
    }
}
