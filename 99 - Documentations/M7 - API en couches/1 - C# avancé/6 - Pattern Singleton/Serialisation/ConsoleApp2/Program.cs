using ConsoleApp2;
using System.Text.Json;
using System.Text.Json.Serialization;

List<Student> studentList = new List<Student>()
{
    new Student() { Id = 1, Name = "John", Age = 13} ,
    new Student() { Id = 2, Name = "Moin",  Age = 21 } ,
    new Student() { Id = 3, Name = "Will",  Age = 18 } ,
    new Student() { Id = 4, Name = "Ram" , Age = 20} ,
    new Student() { Id = 5, Age = 15 }
};

JsonSerializerOptions options = new() { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
string jsonString = JsonSerializer.Serialize(studentList, options);

Console.WriteLine(jsonString);

var students = JsonSerializer.Deserialize<List<Student>>(jsonString);

string txt = null;
foreach (Student std in students)
    txt += $"{std}{Environment.NewLine}";

Console.WriteLine(txt);