// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
int aDigit = 0;
while (true)
{
    Console.WriteLine("Введите новое число ");
    aDigit = Convert.ToInt32(Console.ReadLine());
    if (aDigit >= 0) break;
    else 
    {
        Console.WriteLine("Вы ввели некорректное число!");
        Console.WriteLine("Для выхода, нажмите CTRL + C");
    }
}

int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    if (sum == 0) return 1;
    else return sum;
}

int res = SumDigits(aDigit);
Console.WriteLine($"{aDigit} -> {res}");