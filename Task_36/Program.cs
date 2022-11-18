// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
    Console.WriteLine();
}

int[] array = GetArray(6, 1, 10);
Console.WriteLine();

int oddSum = 0;

for (int i = 0; i < array.Length; i++)
{
   if(i % 2 != 0) oddSum = oddSum + array[i];
}

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {oddSum}");