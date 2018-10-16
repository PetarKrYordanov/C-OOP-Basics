using System;
using System.Collections.Generic;
using System.Text;

    class Engine
    {
    public Engine(int power, int speed)
    {
        this.speed = speed;
        this.power = power;
    }
    private int power;
    private int speed;

    public int EngineSpeed { get => speed; set => speed = value; }
    public int EnginePower { get => power; set => power = value; }
}

