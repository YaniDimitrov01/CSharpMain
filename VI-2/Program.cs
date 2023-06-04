using System;

using System.Text.Json; 
class Program
{
    static void Main()
    {
        // Обект, който ще бъде сериализиран
        var person = new Person
        {
            Name = "John Doe",
            Age = 30
        };
        
        // Сериализация на обекта в JSON низ
        string jsonString = JsonSerializer.Serialize(person);
        
        // извеждане на екрана на получения JSON - низ
        Console.WriteLine($"JSON string: {jsonString}");
        
        // Десериализация на JSON низа обратно в обект
        var deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);
        
        Console.WriteLine($"Name: {deserializedPerson.Name}");
        Console.WriteLine($"Age: {deserializedPerson.Age}");
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
