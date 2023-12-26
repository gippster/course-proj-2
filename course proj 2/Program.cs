using System;

class Program
{
    static void Main() {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter email:");
        string? email = Console.ReadLine();

        Person person = new(name, email);
    }
}