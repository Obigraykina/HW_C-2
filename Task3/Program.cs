
///Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

///6 -> да
///7 -> да
///1 -> нет

Console.WriteLine ("ВВедите цифру обозначающую день недели:");
Console.WriteLine("1- пн, 2- вт, 3-ср, 4-чет, 5-пят, 6- суб, 7- вскр");

int NumWeek = Convert.ToInt32(Console.ReadLine());
if(NumWeek == 6|| NumWeek == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}