/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] numbers = new double [4];

FillArray(numbers);
WriteArray(numbers);

double minNumbers = numbers[0];
double maxNumbers = numbers[0];
double difference = 0;

 for (int i = 0; i < numbers.Length; i++)
 {
     
     if(numbers[i] < minNumbers)
     {
         minNumbers = numbers[i];
     }
    
     if(numbers[i] > maxNumbers)
     {
         maxNumbers = numbers[i];
     }
 }

difference = maxNumbers - minNumbers;

void FillArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Минимальное значение = {minNumbers}");
Console.WriteLine($"Максимальное значение = {maxNumbers}");
Console.WriteLine($"Разница между min и max = {difference}");
