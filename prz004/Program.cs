// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели -> ");
int daynumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int daynumber)
{
   if (daynumber == 6 || daynumber == 7)
   {
      Console.WriteLine("(этот день выходной) -> да");
   }
   else if (daynumber < 1 || daynumber > 7)
   {
      Console.WriteLine("это вообще не день недели");
   }
   else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(daynumber);

