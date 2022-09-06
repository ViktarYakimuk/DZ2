// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа. 
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 1000);
int newnumber = 0;

int NumberWithoutSecDig()
{
   newnumber = number / 100 * 10 + number % 10;
   return newnumber;
}

NumberWithoutSecDig();

System.Console.WriteLine();
System.Console.WriteLine($"Если из числа {number} удалить вторую цифру, получится число {newnumber}");
System.Console.WriteLine();
