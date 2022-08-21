///Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
/// 645 -> 5
/// 78 -> третьей цифры нет
/// 32679 -> 6


//с отрицательными числами не работает!!!


Console.WriteLine("Введите положительное трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string atext = Convert.ToString(a);

if(atext.Length > 2)
{
    Console.WriteLine(atext[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
