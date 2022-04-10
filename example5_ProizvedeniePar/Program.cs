// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// Пример          [1 2 3 4 5] -> 5 8 3                 [6 7 3 6] -> 36 21
Console.Clear();

Console.Write("Введи длину массива = ");
string strMassive = Console.ReadLine();
int valMassive = int.Parse(strMassive);

int[] arr = new int[valMassive];
FindArray(arr);
FillArray(arr);

Console.Write(" -> ");
for (int index = 0; index < arr.Length / 2; index++)
{
    int sum = arr[index] + arr[arr.Length - 1 - index];
    Console.Write($"{sum} ");
}



//--------------------------------------------
void FindArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(0, 10);
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