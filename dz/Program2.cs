// задача 2 Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99)
{
    int b = (int)Math.Floor(Math.Log10(a))-2;
    int c = (int)Math.Pow( 10, b );
    Console.WriteLine( a / c % 10 );
}
else 
Console.WriteLine("3 числа нет");

