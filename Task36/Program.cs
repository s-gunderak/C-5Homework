// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arrayA = GetArray(5, 0, 10);
int[] oddNumsSum = OddNumsSum(arrayA);
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
int[] OddNumsSum(int[] array)
{
    int[] res = array;
    for (int i = 1; i < array.Length; i += 2)
    {
        res[i] += res[i];
    }
    return res;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {oddNumsSum}.");