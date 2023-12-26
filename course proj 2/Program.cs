using course_proj_2;
using System;

class Program
{
    static void Main() {
        Console.WriteLine("Введите имя:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Введите фамилию:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Введите электронную почту:");
        string? email = Console.ReadLine();


        Person person = new(firstName, lastName, email);
    }
}