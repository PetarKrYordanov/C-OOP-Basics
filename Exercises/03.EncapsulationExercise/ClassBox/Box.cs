using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double length;


    public double Length
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            else
            this.length = value;
        }
        get { return this.length; }
    }

    private double width;
    public double Width
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            else
            this.width = value;
        }
        get { return this.width; }
    }
    private double height;
    public double Height
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            else
            this.height = value;
        }
        get { return this.height; }
    }
    private double surfaceArea;
    public Box(double len, double width, double height)
    {
        this.Length = len;
        this.Width = width;
        this.Height = height;
    }

    public double CalculateSurface()
    {
        this.surfaceArea = 2.0 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
        return surfaceArea;
    }

    public double LateralSurfaceArea()
    {
        return this.surfaceArea - 2.0 * this.Length * this.Width;
    }

    public double CalculateVolume()
    {
        return this.Height * this.Length * this.Width;
    }
}

