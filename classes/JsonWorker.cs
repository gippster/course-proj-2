using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class JsonWorker
{
    private static JsonSerializerSettings _JSON_SETTINGS = new JsonSerializerSettings()
    {
        TypeNameHandling = TypeNameHandling.All
    };
    internal static List<Person> LoadPersonsFromFile(string path)
    {
        if (File.Exists(path))
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(path), _JSON_SETTINGS) ?? new List<Person>();
            }
            catch {
                return null;
            }
        } 
        else 
        { 
            File.Create(path).Close();
            return null; 
        }
    }
    internal static void RecreateFileFromList(string path, List<Person> persons)
    {
        File.WriteAllText(path, JsonConvert.SerializeObject(persons, _JSON_SETTINGS));
    }
}
