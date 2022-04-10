// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Пример,     [345, 897, 568, 234] -> 2

Console.Clear();

int[] arr = new int[Promt("Введи длину массива = ")];
FindArray(arr);
FillArray(arr);

int sumPositive = 0;
for (int index = 0; index < arr.Length; index++)
{
    if (arr[index] % 2 == 0)
    {
        sumPositive = sumPositive + 1;
    }
}
Console.WriteLine($"Сумма положительных чисел = {sumPositive}");



//--------------------------------------------
int Promt(string messsage)
{
    Console.Write(messsage);
    string strMassive = Console.ReadLine();
    int answer = int.Parse(strMassive);
    return answer;
}

void FindArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(100, 1000);
    }
}

void FillArray(int[] collection)
{
    Console.Write($"[ ");
    for (int index = 0; index < collection.Length - 1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.WriteLine($"{collection[collection.Length - 1]} ]");
}