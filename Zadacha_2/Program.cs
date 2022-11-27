void Zadacha36()
{
    //Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов с нечётными индексами.
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 10, 250);
    PrintArray(numbers);
    for (int i = 0; i < size; i++)
    {
    }
    FindSumPos(numbers);
    
}
Zadacha36();




void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] nums)
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

void FindSumPos(int[] nums)
{
    int sumPos = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
       i++;
        sumPos += nums[i];

    }
    Console.WriteLine("Сумма элементов с нечетным индексом: " + sumPos);
}