void Zadacha34()
{
   // Задайте массив заполненный случайными положительными трёхзначными числами. 
   // Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 8;
int[] numbers = new int[size];
FillArray(numbers, 100, 1000);
PrintArray(numbers);
int counter = 0;
for (int i = 0; i < size; i++)
{
    if (numbers[i] %2 == 0)
    {
        counter++;
    }
}
Console.WriteLine("Колличество четных значений в массиве: " + counter);
}
Zadacha34();




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