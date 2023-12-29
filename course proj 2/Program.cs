using course_proj_2;
using Newtonsoft.Json;
using System;


class Program
{
    private const string YES = "да";
    private const string JOURNAL_FILE = "journal.json";

    private static JsonSerializerSettings _jsonSettings = new JsonSerializerSettings()
    {
        TypeNameHandling = TypeNameHandling.All
    };

    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Выберите режим работы:");
                var startMenu = new Menu(
                    new List<MenuItem>()
                    {
                        new MenuItem("Поиск", FindPerson),
                        new MenuItem("Запись", () => { }, 
                            new List<MenuItem>()
                            {
                                new MenuItem("Добавить новую запись", AddNewPerson),
                                new MenuItem("Изменить существующую запись", ChangePerson)
                            }),
                        new MenuItem("Удаление", RemovePerson),
                        new MenuItem("Очистить ввод", () => Console.Clear()),
                        new MenuItem("Выход", () =>  Environment.Exit( 0 ))
                    });

                var cursorPosition = Console.GetCursorPosition();
                startMenu.Run(cursorPosition.Top, cursorPosition.Left);

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                WriteLineWithColor("Что-то пошло не так", ConsoleColor.Red);
                WriteLineWithColor(ex.Message, ConsoleColor.Red);
            }
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

        if (!findedPersons.Any())
        {
            WriteLineWithColor("По вашему запросу ничего не найдено", ConsoleColor.DarkYellow);
            Console.WriteLine("Нажмите любую кнопку для перехода в меню");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            WriteLineWithColor($"По вашему запросу найдено совпадений: {findedPersons.Count()}", ConsoleColor.Green);
            Console.Write("{0,40} |", "ID");
            Console.WriteLine("{0,30} |{1,20}", $"Имя Фамилия", "Номера телефонов");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
        }
        foreach (var person in findedPersons)
        {
            Console.Write("{0,40} |", $"{person.ID}");
            
            Console.WriteLine("{0,30} |{1,20}", $"{person.FirstName} {person.LastName}", string.Join(", ", person.Telephones.Select(telephone => telephone.PhoneNumber)));
            
        }
    }

    private static void AddNewPerson() {
        var firstName = GetFirstName();
        var lastName = GetLastName();
        var email = GetEmail();
        var adress = GetAdress();

        var telephones = GetTelephones();
        Person person = new(firstName, lastName, email, adress, telephones);
        AddPersonToFile(person);

        WriteLineWithColor("Запись успешно добавлена", ConsoleColor.Green);
    }

    private static void ChangePerson()
    {
        Console.WriteLine("Введите идентификатор:");
        var personId = ValidateInputLine(Console.ReadLine());

        var persons = ReadFile();
        var findedPerson = persons.FirstOrDefault(person => person.ID == personId);

        if (findedPerson != null)
        {
            var stop = false;
            while (!stop) {
                Console.WriteLine("Выберите что вы хотите изменить");
                var changeMenu = new Menu(
                    new List<MenuItem>()
                    {
                        new MenuItem("Имя", () => findedPerson.FirstName = GetFirstName()),
                        new MenuItem("Фамилия", () => findedPerson.LastName = GetLastName()),
                        new MenuItem("Email", () => findedPerson.Email = GetEmail()),
                        new MenuItem("Адрес", () => findedPerson.Adress = GetAdress()),
                        new MenuItem("Телефоны", () => findedPerson.AddTelephone(GetTelephones())),
                        new MenuItem("Сохранить", () => stop = true)
                    });

                var cursorPosition = Console.GetCursorPosition();
                changeMenu.Run(cursorPosition.Top, cursorPosition.Left);
            }

            ChangePersonInFile(findedPerson);
        }
        else
        {
            throw new ArgumentException($"Запись с идентификатором \"{personId}\" не найдена");
        }
    }

    private static void ChangePersonInFile(Person changedPerson)
    {
        var persons = ReadFile();
        var findedPerson = persons.FirstOrDefault(person => person.ID == changedPerson.ID);
        var findedPersonIndex = persons.IndexOf(findedPerson);
        if (findedPerson != null)
        {
            persons.Remove(findedPerson);
            persons.Insert(findedPersonIndex, changedPerson);
            WriteFile(persons);

            WriteLineWithColor("Запись успешно изменена", ConsoleColor.Green);
        }
        else
        {
            throw new ArgumentException($"Запись с идентификатором \"{changedPerson.ID}\" не найдена");
        }
    }

    private static void RemovePerson()
    {
        Console.WriteLine("Введите идентификатор:");
        RemovePersonFromFile(ValidateInputLine(Console.ReadLine()));
    }

    private static void RemovePersonFromFile(string personId)
    {
        var persons = ReadFile();
        var findedPerson = persons.FirstOrDefault(person => person.ID == personId);
        if (findedPerson != null)
        {
            persons.Remove(findedPerson);
            WriteFile(persons);

            WriteLineWithColor("Запись успешно удалена", ConsoleColor.Green);
        }
        else
        {
            throw new ArgumentException($"Запись с идентификатором \"{personId}\" не найдена");
        }
    }

    private static void AddPersonToFile(Person person)
    {
        var persons = ReadFile();
        persons.Add(person);
        WriteFile(persons);
    }

    private static List<Person> ReadFile()
    {
        var persons = new List<Person>();
        if (File.Exists(JOURNAL_FILE))
        {
            persons = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(JOURNAL_FILE), _jsonSettings) ?? new List<Person>();
        }
        else
        {
            using (File.Create(JOURNAL_FILE)) { }
        }
        return persons;
    }

    private static void WriteFile(IEnumerable<Person> persons)
    {
        File.WriteAllText(JOURNAL_FILE, JsonConvert.SerializeObject(persons, _jsonSettings));
    }

    private static string GetFirstName()
    {
        Console.WriteLine("Введите имя:");
        return ValidateInputLine(Console.ReadLine());
    }

    private static string GetLastName()
    {
        Console.WriteLine("Введите фамилию:");
        return ValidateInputLine(Console.ReadLine());
    }

    private static string GetEmail()
    {
        Console.WriteLine("Введите электронную почту:");
        return ValidateInputLine(Console.ReadLine());
    }

    private static Adress GetAdress()
    {
        Console.WriteLine("Введите страну:");
        string country = ValidateInputLine(Console.ReadLine());
        Console.WriteLine("Введите город:");
        string city = ValidateInputLine(Console.ReadLine());
        Console.WriteLine("Введите улицу:");
        string street = ValidateInputLine(Console.ReadLine());
        Console.WriteLine("Введите номер дома:");
        string houseNumber = ValidateInputLine(Console.ReadLine());
        Console.WriteLine("Введите номер квартиры:");
        string apartmentNumber = ValidateInputLine(Console.ReadLine());
        Console.WriteLine("Введите почтовый индекс:");
        string postCode = ValidateInputLine(Console.ReadLine());
        
        return new Adress()
        {
            Street = street,
            HouseNumber = houseNumber,
            ApartmentNumber = apartmentNumber,
            Country = country,
            City = city,
            PostCode = postCode
        };
    }

    private static List<Telephone> GetTelephones() 
    {
        var addNew = true;
        List<Telephone> telephones = new List<Telephone>();
        while (addNew)
        {
            try
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
                Telephone telephone;
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
            catch (Exception ex)
            {
                WriteLineWithColor(ex.Message, ConsoleColor.Red);

                addNew = true;
            }
        }
        return telephones;
    }

    private static string ValidateInputLine(string line)
    {
        while (string.IsNullOrWhiteSpace(line))
        {
            Console.WriteLine("Введенные данные некоректны. Попробуйте ещё раз:");
            line = Console.ReadLine();
        }

        return line;
    }

    private static void WriteLineWithColor(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine();
        Console.WriteLine(message);
        Console.WriteLine();
        Console.ResetColor();
    }
}