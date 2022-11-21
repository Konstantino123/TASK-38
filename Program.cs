﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76


Random myRnd = new Random();// Объявляется генератор случайных чисел.
int[] a = new int[6];//Объявление целочисленного массива длинной 10.
Console.WriteLine("Исходный массив:");
 for (int i = 0; i < a.Length; i++)//Цикл заполнения массива.
{
a[i] = myRnd.Next(-99, 999);//Присвоение случайного числа от -99 до 999 [i]-тому элементу массива.
Console.Write(a[i] + " ");//Вывод на экран.
}
var max = a[0];
var min = a[0];
for (int i = 1; i < a.Length; i++)
{
    if (a[i] < min) min = a[i];
    if (a[i] > max) max = a[i];
}
            
Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);