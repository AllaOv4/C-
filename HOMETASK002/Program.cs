/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*int method01(int number)

{
    int dec = number / 10;
    int result = dec % 10;
    return result;
}

Console.Write (" Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = method01(number);
Console.WriteLine($" The second digit is {x}");*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */


/*void method02(double num)
{
if(num<100) Console.WriteLine($" There isn't the third digit");
  if (num>99)
  {
  int b = 99;
  int c = 2;
  while (num-b>0)
   {                   
      b = b*10+9;
      c++;
   }
   double x = num%Math.Pow(10,c-2);
   double  thirdNumber = x/Math.Pow(10,c-3);
   int a;
   a = (int)thirdNumber;
   Console.WriteLine($"The third digit is {a}");
  }
}

Console.Write (" Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
method02(number); */

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*void method03(int num)
{
    if (num>0 && num<6) Console.WriteLine($"It's not a day off");
    if(num==6) Console.WriteLine($"It's a day off");
    if(num==7) Console.WriteLine($"It's a day off");
    if(num<1) Console.WriteLine($"There's not such day of week");
    if(num>7) Console.WriteLine($"There's not such day of week");
}   

Console.Write (" Input number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());
method03(number);*/