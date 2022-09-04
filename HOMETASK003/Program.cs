/*Задача 19

Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да  */



/*void Palindrome(int num)
{
int newNum=0;
int ed;
int temp=num;

while(num>0)
{
ed=num%10;
newNum=(newNum*10)+ed;
num/=10;
}
if(temp==newNum)
Console.Write("The number is Palindrome.");
else
Console.Write("The number isn't Palindrome");
}

Console.Write (" Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number); */

/*Напишите программу, которая принимает на вход координаты
 двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*double FindDistance(double x1,double y1,double z1,double x2,double y2,double z2)

{
    return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
}

Console.WriteLine("Input coordinates of point A one by one: ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of point B one by one: ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());
double i= FindDistance(xA,yA,zA,xB,yB,zB);
Console.WriteLine($" The distance from A to B is {i}"); */

/*Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*void Cubes(int num)
  { 
   
    int i=1;
    while(i<=num)
    {
        if(i==num) Console.Write($" {i*i*i}. ");
        else Console.Write($" {i*i*i}, ");
    i++;
    }
  }
Console.Write("Input digit from 1 to n: ");
int cube = Convert.ToInt32(Console.ReadLine());
Cubes(cube);
*/