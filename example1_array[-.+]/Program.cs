// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();

int[] arr = new int[12];

FindArray(arr);
FillArray(arr);

int sumPoloz = 0;
int sumOtric = 0;
for (int index = 0; index < arr.Length; index++)
{
    if (arr[index] > 0) sumPoloz = sumPoloz + arr[index];
    else if (arr[index] < 0) sumOtric = sumOtric - arr[index];
}

Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumPoloz}");
Console.WriteLine($"Сумма отрицательных чисел = -{sumOtric}");



//--------------------------------------------
void FindArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-9, 10);
    }
}

void FillArray(int[] collection)
{
    Console.Write($"[ ");
    for (int index = 0; index < collection.Length - 1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.Write($"{collection[collection.Length - 1]} ]");
}