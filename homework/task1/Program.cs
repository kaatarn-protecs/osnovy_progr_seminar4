// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int anumber = 0;
int bnumber = 0;

while (true)
{
    Console.WriteLine("Введите число А ");
    if (int.TryParse(Console.ReadLine(), out anumber)) break;
    else 
    {
        Console.WriteLine("Вы ввели некорректное число A!");
        Console.WriteLine("Для выхода, нажмите CTRL + C");
    }
}
while (true)
{   
    Console.WriteLine("Введите число B ");
    if (int.TryParse(Console.ReadLine(), out bnumber)) break;
    else 
    {
        Console.WriteLine("Вы ввели некорректное число B!");
        Console.WriteLine("Для выхода, нажмите CTRL + C");
    }
}

int PowUp(int digit, int inpow)
{
    int newDigit = 1;
    for (int i = 1; i != (Math.Abs(inpow)+1); i++)
    {
        newDigit = newDigit * digit;
    }
    return newDigit;
}

int res = PowUp(anumber, bnumber);
Console.WriteLine($"Число {anumber} в степени {bnumber} = {res}");
