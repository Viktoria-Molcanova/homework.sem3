// задача 1 Напишите программу, которая принимает 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99 && a<1000)
{
    a = (a / 10) % 10;
    Console.WriteLine(a);
}
else 
Console.WriteLine("число не трёхзначное,повторите попытку");
