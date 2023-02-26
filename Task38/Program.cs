// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] arrayA = GetArray(5, 1, 6);
Console.WriteLine();
Array.Sort(arrayA);
Console.WriteLine(String.Join(" ", arrayA));
int product = arrayA[arrayA.Length - 1] - arrayA[0];
Console.Write(product);
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{array[i]} ");
    }
    return array;
}