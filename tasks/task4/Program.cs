// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите размер массива ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] RandArray(int len)
{
    int[] arrays = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < arrays.Length; i++)
    {
        arrays[i] = rnd.Next(0, 2);
    }
    return arrays;
}

int[] res = RandArray(lenght);

void PrintArray(int[] res1)
{
    Console.Write($"[ ");
    for (int i = 0; i < res1.Length; i++)
    {
        Console.Write($"{res1[i]} ");
    }
    Console.Write($"]");
}

PrintArray(res);
