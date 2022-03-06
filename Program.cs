using System;
using RPG.src.Entities;

namespace RPG
{

    public class Program
    {

        static void Main(string[] args)
        {

        Knigth Arus = new Knigth("Arus", 23 , "Knight");
        Wizard Jennica = new Wizard("Jennica", 24, "Wizard");
        
        Console.WriteLine(Arus.Attack());
        Console.WriteLine(Jennica.Attack(7));
        Console.WriteLine(Jennica.Attack(5));

        }
    }

}

