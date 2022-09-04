Console.Write (" Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
Console.WriteLine($"Число {number} является четным ");
Console.WriteLine("да");
}
else
{
Console.WriteLine($"Число {number} является нечетным ");
Console.WriteLine("нет");
}