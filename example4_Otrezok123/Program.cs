// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123. 
// [5, 18, 123, 6, 2] -> 1             [1, 2, 3, 6, 2] -> 0                [10, 11, 12, 13, 14] -> 5

Console.Clear();
int[] arr = new int[123];
FindArray(arr);
FillArray(arr);

int sumInArray = 0;
for (int index = 0; index < arr.Length; index++)
{
    if (arr[index] >= 10 && arr[index] <= 100)
    {
        sumInArray = sumInArray + 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Всего найдено {sumInArray} элементов в массиве ! ");


//--------------------------------------------
void FindArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(0, 124);
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