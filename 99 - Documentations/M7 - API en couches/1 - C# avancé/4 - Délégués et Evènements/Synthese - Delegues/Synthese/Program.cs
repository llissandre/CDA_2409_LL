
using Synthese;

List<Student> studentList = new List<Student>() 
{
    new Student() { Id = 1, Name = "John", Age = 13} ,
    new Student() { Id = 2, Name = "Moin",  Age = 21 } ,
    new Student() { Id = 3, Name = "Will",  Age = 18 } ,
    new Student() { Id = 4, Name = "Ram" , Age = 20} ,
    new Student() { Id = 5, Name = "Ron" , Age = 15 }
};

var gest = new GestStudents(studentList);

Console.WriteLine(gest);
Console.WriteLine(gest.ToString(null, s => s.Name));


