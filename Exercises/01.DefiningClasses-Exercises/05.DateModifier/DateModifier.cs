using System;

public class DateModifier
{
    public static int GetDifferenceBetween(string firstDateAsString, string secondDateAsString)
    {
        DateTime firstDate = DateTime.Parse(firstDateAsString);
        DateTime secondDate = DateTime.Parse(secondDateAsString);
        int difference = (firstDate - secondDate).Days;
        return Math.Abs(difference);
    }
}

