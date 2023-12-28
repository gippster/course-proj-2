using course_proj_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Mail;

public class Person
{
    public string ID { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public List<Telephone> Telephones { get; protected set; }
    public Adress Adress { get; set; }

    public Person(string firstName, string lastName, string email, Adress adress, List<Telephone> telephones = null, string id = null)
    {
        ID = id ?? Guid.NewGuid().ToString();
        Telephones = telephones ?? new List<Telephone>();
        Adress = adress;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    private void EmailValidate(string email)
    {
        new MailAddress(email);
    }

    public void AddTelephone(Telephone telephone)
    {
        Telephones.Add(telephone);
    }

    public void AddTelephone(IEnumerable<Telephone> telephones) 
    {
        Telephones.Clear();
        Telephones.AddRange(telephones);
    }

    public void RemoveTelephone(Telephone telephone)
    {
        Telephones.Remove(telephone);
    }
}