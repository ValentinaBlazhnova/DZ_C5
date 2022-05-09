/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] numbers = new int[7];
int count = 0;
FillArray(numbers);
WriteArray(numbers);

for( int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
   {
       count++;
   }   
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"В массиве {count} чётных чисел (числа)");
