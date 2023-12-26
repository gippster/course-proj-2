using course_proj_2;
using System;
using System.Collections.Generic;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }
    public List<Telephone> Telephones { get; private set; }
    public Adress Adress { get; set; }

    public Person(string firstName, string lastName, string? email, Adress adress, List<Telephone> telephones = null)
    {
        Telephones = telephones ?? new List<Telephone>();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}