/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] numbers = new int[4];
int sum = 0;
int i =0;
FillArray(numbers);
WriteArray(numbers);

while(i < numbers.Length)
{
    sum += numbers[i];
    i = i + 2;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
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
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");

