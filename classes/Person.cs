using System;
using System.Collections.Generic;
using System.Net.Mail;

public class Person
{
    public string ID { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public List<Telephone> Telephones { get; set; }
    public List<Address> Addresses { get; set; }

    public Person(string firstName, string lastName, string email, List<Address> addresses, List<Telephone> telephones = null, string id = null)
    {
        ID = id ?? Guid.NewGuid().ToString();
        Telephones = telephones ?? new List<Telephone>();
        Addresses = addresses ?? new List<Address>();
        
        if (firstName.Length == 0)
        {
            throw new Exception("Длина имени должна быть больше 0 символов");
        }
        FirstName = firstName;
        
        if (lastName.Length == 0)
        {
            throw new Exception("Длина фамилии должна быть больше 0 символов");
        }
        LastName = lastName;
        
        try
        {
            new MailAddress(email);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        Email = email;
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