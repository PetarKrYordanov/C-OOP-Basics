using System;


class StartUp
{
    static void Main(string[] args)
    {
        var length = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        try
        {
        Box box = new Box(length, width, height);
            Console.WriteLine($"Surface Area - {box.CalculateSurface():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.CalculateVolume():f2}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
      
        }
       
    }
}

