// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[]{345, 897, 568, 234};
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]%2 == 0)
//     {
//         sum = sum + 1;
//     }
// }
// Console.Write(sum);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] array = new int[4];
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(3,12);
//         sum = sum + array[i];
//     }
// Console.WriteLine(String.Join(",",array));
// Console.Write(sum);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[]{3,7,22,2,78};
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
double diff = Math.Round((max - min),1);
Console.WriteLine(String.Join(";",array));
Console.Write(diff);