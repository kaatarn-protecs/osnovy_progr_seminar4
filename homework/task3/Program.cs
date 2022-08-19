// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int lenght = 0;
while (true)
{
    Console.WriteLine("Введите размер массива ");
    lenght = Convert.ToInt32(Console.ReadLine());
    if (lenght >= 0) break;
    else 
    {
        Console.WriteLine("Вы ввели некорректный размер массива!");
        Console.WriteLine("Для выхода, нажмите CTRL + C");
    }
}

int[] NewArray(int len)
{
    int[] newArray = new int[len];

    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент массива");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

int[] res = NewArray(lenght);

void PrintArray(int[] res1)
{
    Console.Write($"[ ");
    for (int i = 0; i < res1.Length; i++)
    {
        if (i < res1.Length - 1) Console.Write($"{res1[i]}, ");
        else Console.Write($"{res1[i]} ");
    }
    Console.Write($"]");
}

PrintArray(res);