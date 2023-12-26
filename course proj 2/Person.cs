using course_proj_2;
using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public string? Email { get; set; }
    public List<Telephone> Telephones { get; set; }

    public Person(string name, string? email, List<Telephone> telephones = null)
    {
        Telephones = telephones ?? new List<Telephone>();
        Name = name;
        Email = email;
    }
}