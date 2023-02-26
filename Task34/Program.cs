// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetArray(5, 100, 999);
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}
int evenNumbers = 0;
foreach (int el in array)//foreach берёт каждый элемент (el) по заданному условию (el==n или el<>n и т.д.)
//и выводит результат, который мы хотим в теле цикла if else. Ему не нужно задавать границы, т.к. они у нас уже заданы ранее условиями массива.
{
    if (el % 2 == 0)
    {
        evenNumbers += 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве = {evenNumbers}.");