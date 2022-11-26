// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Pound_3(int n){
    while (n > 999){
        n /= 10;
    }
    return n % 10;
}
bool BadOption(int n){    
    if (n<100){
        Console.WriteLine ($"Такого числа нет");
        return false;
    }
    return true;
}

Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (BadOption(n)){
    Console.WriteLine(Pound_3(n));
}
