using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using WorkingWithFiles;

var route = @"C:\Users\ASUS\source\OD\WorkingWithFiles\WorkingWithFiles\people.json";

var person = new Person { Id = 1, Name = "Felipe Gavilán", Salary = 25.99m };

var json = JsonConvert.SerializeObject(person);


using (var sw = new StreamWriter(route))
{
    sw.Write(json);
}

var fileContent = File.ReadAllText(route);
var deserializedPerson = JsonConvert.DeserializeObject<Person>(fileContent);

Console.WriteLine(json);
