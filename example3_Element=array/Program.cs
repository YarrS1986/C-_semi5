// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// Например, 4; массив [6, 7, 19, 345, 3] -> нет

Console.Clear();
int[] arr = new int[8];
FindArray(arr);
FillArray(arr);

Console.Write("Введи число = ");
string Number = Console.ReadLine();
int num = int.Parse(Number);

for (int index = 0; index < arr.Length; index++)
{
    if (arr[index] == num) Console.WriteLine($"Число {num} найдено в массиве ! ");
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