using course_proj_2;
using Newtonsoft.Json;
using System;


class Program
{
    const string YES = "да";
    const string JOURNAL_FILE = "journal.json";
    static void Main() {

        Console.WriteLine("Выберите режим работы (0 - Поиск 1 - Запись):");
        if (Console.ReadLine()=="1")
        {
            AddNewPerson();
        }
        else
        {
            FindPerson();
        }
    }
    private static void FindPerson()
    {
        Console.WriteLine("Введите номер или имя:");
        var findString = Console.ReadLine();
        var persons = ReadFile();
        var findedPersons = persons.Where(person => person.FirstName.Contains(findString) 
            || person.LastName.Contains(findString) 
            || person.Telephones.Any(number => number.PhoneNumber.Equals(findString)));
        foreach(var person in findedPersons)
        {
            Console.WriteLine("{0,10} |{1,10}", $"{person.FirstName} {person.LastName}", string.Join(", ", person.Telephones.Select(telephone => telephone.PhoneNumber)));
        }
    }
    private static void AddNewPerson() {
        Console.Clear();
        Console.WriteLine("Введите имя:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Введите фамилию:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Введите электронную почту:");
        string email = Console.ReadLine();

        Console.WriteLine("Введите страну:");
        string country = Console.ReadLine();
        Console.WriteLine("Введите город:");
        string city = Console.ReadLine();
        Console.WriteLine("Введите улицу:");
        string street = Console.ReadLine();
        Console.WriteLine("Введите номер дома:");
        string houseNumber = Console.ReadLine();
        Console.WriteLine("Введите номер квартиры:");
        string apartmentNumber = Console.ReadLine();
        Console.WriteLine("Введите почтовый индекс:");
        string postCode = Console.ReadLine();

        Adress adress = new Adress()
        {
            Street = street,
            HouseNumber = houseNumber,
            ApartmentNumber = apartmentNumber,
            Country = country,
            City = city,
            PostCode = postCode
        };

        var telephones = GetTelephones();
        Person person = new(firstName, lastName, email, adress, telephones);
        AddToFile(person);
    }
    private static void AddToFile(Person person)
    {
        var persons = ReadFile();
        persons.Add(person);
        File.WriteAllText(JOURNAL_FILE, JsonConvert.SerializeObject(persons));
    }
    private static List<Person> ReadFile()
    {
        var persons = new List<Person>();
        if (File.Exists(JOURNAL_FILE))
        {
            persons = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(JOURNAL_FILE)) ?? new List<Person>();
        }
        else
        {
            using (File.Create(JOURNAL_FILE)) { }
        }
        return persons;
    }
    private static List<TelephoneBase> GetTelephones() 
    {
        var addNew = true;
        List<TelephoneBase> telephones = new List<TelephoneBase>();
        while (addNew)
        {
            Console.WriteLine("Введите тип телефона (0 - Домашний 1 - Основной 2 - Рабочий 3 - Мобильный):");
            TelephoneType type = (TelephoneType)Enum.Parse(typeof(TelephoneType), Console.ReadLine().ToString());
            bool typeNumber = false;
            if (type != TelephoneType.Mobile)
            {
                Console.WriteLine("Введите тип номера телефона (0 - Городской 1 - Мобильный):");
                typeNumber = Console.ReadLine() == "0" ? true : false;
            }

            Console.WriteLine("Введите номер телефона:");
            string phone = Console.ReadLine();
            TelephoneBase telephone;
            if (typeNumber)
            {
                telephone = new LandlinePhone(phone, type);
            }
            else
            {
                telephone = new MobilePhone(phone, type);
            }
            telephones.Add(telephone);
            Console.WriteLine("Хотите ввести ещё один номер телефона? (Да/Нет)");
            addNew = Console.ReadLine().ToLower() == YES ? true : false;
        }
        return telephones;
    }
}