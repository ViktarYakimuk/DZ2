// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

int Prompt(string message)
{
   Console.Write(message);               //вывод приглашения.
   string strValue;                      //обьявдения для ввода строки
   strValue = Console.ReadLine() ?? "0"; //вводими строку в консоли.(с консоли можно ввести только строку.)
   int value = int.Parse(strValue);      //преоброзование строки в целое число.
   return value;
}

int number = Prompt("Введите трёхзначное число -> ");

int max = number / 10 % 10;
if (number / 100 > max) max = number / 100;
if (number % 10 > max) max = number % 10;
Console.WriteLine(max);








