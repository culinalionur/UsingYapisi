// See https://aka.ms/new-console-template for more information

using OperatorOverLoading;

Student student1 = new Student("Nurhan", "Akyol", 15, 178,20);
Student student2 = new Student("Nurhan", "Akyol", 18, 234,30);

//var isEqual = student1 == student2; (Bu karşılaştırma yapıldığında iki nesnenin bellekteki yeri karşılaştırıldı. Aynı adreste olduğunda true döner)
var result = student1 + student2;
var newStudent = Student.Sum(student1, student2);
Console.WriteLine(newStudent);