// See https://aka.ms/new-console-template for more information

using OperatorOverloadingTekrar;

Employees employee1 = new Employees()
{
    Name = "Turan",
    LastName = "Hacısüleymanoğlu",
    Age = 25,
    Address = "Avcılar",
    Sales = 300
};
Employees employee2 = new Employees()
{
    Name = "Onur",
    LastName = "Akıncı",
    Age = 27,
    Address = "Kadıköy",
    Sales = 250
};

var result = employee1 == employee2;
Console.WriteLine($"Equality conditions = {result}");

var result2 = employee2 - employee1;
Console.WriteLine($"Sales difference between employees = {result2}");

Console.ReadLine();
