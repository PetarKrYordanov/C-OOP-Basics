using System;
public class StartUp
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        Person person2 = new Person(4);
        Person person3 = new Person("Ivan");
        Person person4 = new Person("name is gosho", 5);

    }
}

