// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int i = Convert.ToInt32(Console.ReadLine());
if (i>99 && i<1000)
{
    i /= 10;  
    i %= 10;  

    Console.WriteLine($"Вторая цифра введенного числа: {i}");
}

else {
    Console.WriteLine("Введите еще раз");
}
Console.WriteLine(i);