void Zadacha38()
{
    // Задайте массив вещественных чисел.
    //Найдите разницу между максимальным и минимальным элементов массива.

    int size = 6;

    double[] array = new double[size];
    Random rand = new Random();
    double minArr = array[0];
    double maxArr = array[0];
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-100, 100) + rand.NextDouble();
    }
    PrintArray(array);

    double SumArr = 0;
    for (int i = 0; i < size; i++)
    {
        if (minArr > array[i])
        {
            minArr = array[i];
        }
    }
    Console.WriteLine("Минимальное значение массива " + minArr);

    for (int i = 0; i < size; i++)
    {
    if(maxArr < array[i])
    {
    maxArr = array[i];
    }
    }
    Console.WriteLine("Максимальное значение массива " + maxArr);


for (int i = 0; i < size; i++)
{
SumArr = minArr + maxArr;
}
Console.WriteLine("Сумма максимального и минимального значения массива " + SumArr);
}
Zadacha38();

void PrintArray(double[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
