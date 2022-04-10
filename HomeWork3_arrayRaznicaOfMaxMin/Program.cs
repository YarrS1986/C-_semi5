// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 

// Пример,     [3, 7, 22, 2, 78] -> 76

Console.Clear();

int[] arr = new int[Promt("Введи длину массива = ")];
FindArray(arr);
FillArray(arr);

Console.Write(" -> ");

int minValue = 100;
int maxValue = 0;
for (int index = 0; index < arr.Length; index++)
{
    if (arr[index] > maxValue) maxValue = arr[index];
}
for (int index = 0; index < arr.Length; index++)
{
    if (arr[index] < minValue) minValue = arr[index];
}

Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxValue - minValue}");



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
        array[index] = new Random().Next(1, 100);
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