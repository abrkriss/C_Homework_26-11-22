void Zadacha38()
{
    // Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным и минимальным элементов массива.

    int size = 6;
    double[] numbers = new double[size];
    FillArray(numbers, 0, 15);
    PrintArray(numbers);
    


}
Zadacha38();


void FillArray(double[] nums, double minValue, double maxValue)
{
    maxValue++;
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.NextDouble(minValue, maxValue);
        Convert.ToDouble(rand.Next(1, 11));
    }
}

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