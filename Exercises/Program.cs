/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] array = new int[5];
int count = 0; 

for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        if (array[i] % 2 == 0) 
        count++;   
    }  
Console.WriteLine("\n" + $"количество четных чисел в массиве [{String.Join(", ",array)}] = {count}");


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] array2 = new int[5];
int sum = 0;

for (int i = 0; i < array2.Length; i++)
{
  array2[i] = new Random().Next(10,101);
  if (i % 2 == 1)
  sum += array2[i];
}    
Console.Write($"В массиве [{String.Join(", ",array2)}] сумма элементов, \nстоящих на нечетных позиция = {sum}");

/*Второй способ решения задачи*/

int[] newArray = new int[5];
int sum = 0;

for (int i = 0; i < newArray.Length; i++)
newArray[i] = new Random().Next(10,101);

for (int i = 1; i < newArray.Length; i+=2)
{
   sum += newArray[i];
}    
Console.Write($"В массиве [{String.Join(", ",newArray)}] сумма элементов, \nстоящих на нечетных позиция = {sum}");

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] arrayNumbers = new double[6];
for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1, 10);
  }
Console.Write($"В массиве [{String.Join(", ",arrayNumbers)}] ");

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if (maxNumber < arrayNumbers[i]) maxNumber = arrayNumbers[i];

    if (minNumber > arrayNumbers[i]) minNumber = arrayNumbers[i];
  }

double diff = maxNumber - minNumber;

Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами= {diff}");
