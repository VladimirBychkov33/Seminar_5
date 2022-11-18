// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int[] array = GetArray(5, 1, 100);
Console.WriteLine();


int max = 0;
int min = array[0];
int diff = 0;
for (int i = 0; i < array.Length; i++)
{
   if(array[i] > max) max = array[i];
   if(array[i] < array[0]) min = array[i];
    diff = max -min;
}

Console.WriteLine($"Максимальное {max}, минимальное {min}, а разница между ними равна {diff}");
