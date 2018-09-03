using System;

public class Circle:Shape
    {
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException();
            }
            radius = value;
        }
    }

    public override double CalculateArea()
    {
        return 2 * Math.PI * this.Radius;
    }

    public override double CalculatePerimeter()
    {
        return Math.PI * this.Radius * this.Radius;
    }

    public override string Draw()
    {
        return base.Draw() + $"{this.GetType().Name}";
    }
}
