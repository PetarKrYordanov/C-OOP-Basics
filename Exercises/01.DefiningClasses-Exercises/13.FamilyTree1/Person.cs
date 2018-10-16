using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private string birthdate;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {
        this.parents = new List<Person>();
        this.children = new List<Person>();
    }

    public Person(string name ) :this()
    {
        this.name = name;
    }

    public string Name { get => name; set => name = value; }
    public string Birthdate { get => birthdate; set => birthdate = value; }
    public List<Person> Parents { get => parents; set => parents = value; }
    public List<Person> Children { get => children; set => children = value; }
}

