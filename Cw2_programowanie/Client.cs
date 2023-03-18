﻿namespace Cw2_programowanie;

public class Client
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Client(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public override string ToString()
    {
        return $"{Name,-8} {Surname,-15} ";
    }
}