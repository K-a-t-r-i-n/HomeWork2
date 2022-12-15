//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using System.Xml.Linq;
using System.Diagnostics;

Console.WriteLine("Здравтсвуйте!");

string? nameCompany = null;
do
{
    Console.WriteLine("\nНапишите название фирмы:");
    nameCompany = Console.ReadLine();
}
while (String.IsNullOrEmpty(nameCompany));



string? answer = null;
do
{
    Console.WriteLine("Вы хотите добавить сотрудника?(да/нет)");
    answer = Console.ReadLine();
}
while (answer == null || (answer != "да" && answer != "нет"));

//for (int count = null; answer == "да"; count++)
//{
    if (answer == "да")
    {
        string? surname = null;
        do
        {
            Console.WriteLine("Напишите вашу фамилию");
            surname = Console.ReadLine();
        }
        while (String.IsNullOrEmpty(surname));

        string? name = null;
        do
        {
            Console.WriteLine("Напишите ваше имя");
            name = Console.ReadLine();
        }
        while (String.IsNullOrEmpty(name));

        string? patronymic = null;
        do
        {
            Console.WriteLine("Напишите ваше отчество");
            patronymic = Console.ReadLine();
        }
        while (String.IsNullOrEmpty(patronymic));

        string? strAge = null;
        do
        {
            Console.WriteLine("Напишите ваш возраст цифрой");
            patronymic = Console.ReadLine();
        }
        while (String.IsNullOrEmpty(strAge));
        var age = Convert.ToInt32(strAge);
}
    else
    {
        Console.WriteLine($"В фирму {nameCompany} было добавлено  сотрудников.\nСпасибо за использование нашей программы!");
    }
    Console.WriteLine("Вы хотите добавить сотрудника?(да/нет)");
    answer = Console.ReadLine();
//}
