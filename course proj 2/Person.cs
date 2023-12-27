using course_proj_2;
using System;
using System.Collections.Generic;
using System.Net.Mail;

public class Person
{
    public string ID { get; protected set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public List<TelephoneBase> Telephones { get; private set; }
    public Adress Adress { get; set; }

    public Person(string firstName, string lastName, string email, Adress adress, List<TelephoneBase> telephones = null)
    {
        ID = Guid.NewGuid().ToString();
        Telephones = telephones ?? new List<TelephoneBase>();
        Adress = adress;
        FirstName = firstName;
        LastName = lastName;
        Email = email;

    }
    private void EmailValidate(string email)
    {
        new MailAddress(email);
    }
    public void AddTelephone(TelephoneBase telephone)
    {
        Telephones.Add(telephone);
    }
    public void AddTelephone(IEnumerable<TelephoneBase> telephones) 
    {
        Telephones.AddRange(telephones);
    }
    public void RemoveTelephone(TelephoneBase telephone)
    {
        Telephones.Remove(telephone);
    }
}