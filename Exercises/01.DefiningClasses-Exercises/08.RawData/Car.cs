using System;
using System.Collections.Generic;
using System.Text;

    class Car
    {
    public Car()
    {
        this.tires = new Tire[4];
    }
    public Car(string model,Engine engine, Cargo cargo)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = new Tire[4];
    }

    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tires;

    public string Model { get => model; set => model = value; }
    internal Engine Engine { get => engine; set => engine = value; }
    internal Cargo Cargo { get => cargo; set => cargo = value; }
    internal Tire[] Tires { get => tires; set => tires = value; }
}

