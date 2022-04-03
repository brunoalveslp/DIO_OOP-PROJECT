using DIO_OOP.Entities;

namespace DIO_OOP;

class Program{
    static void Main(string[] args){
        Knight Arus = new("Arus",7,"Knight");
        Wizard Jennica = new("Jennica",70,"Wizard");

        Console.WriteLine(Arus);
        Console.WriteLine(Arus.Attack());
        Console.WriteLine(Jennica);
        Console.WriteLine(Jennica.Attack());
        Console.WriteLine(Jennica.Attack(7));
    }
}