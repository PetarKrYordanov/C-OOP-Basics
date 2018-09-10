using System;

public class StartUp
{
    static void Main(string[] args)
    {
        try
        {
            var studentArgs = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var student = new Student(studentArgs[0], studentArgs[1], studentArgs[2]);

            var workerArgs = Console.ReadLine().Split( new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var worker = new Worker(workerArgs[0],
                                workerArgs[1],
                               decimal.Parse(workerArgs[2]),
                               decimal.Parse(workerArgs[3]));
            Console.WriteLine(student+Environment.NewLine);
            Console.WriteLine(worker);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

