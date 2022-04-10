// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. 

// Пример,     [3, 7, 23, 12] -> 26                  [-4, -6, 4, 67] -> 0

Console.Clear();

int[] arr = new int[Promt("Введи длину массива = ")];
FindArray(arr);
FillArray(arr);

Console.Write(" -> ");

int sumNegElemens = 0;
for (int index = 0; index < arr.Length; index++)
{
    if (index % 2 == 0)
    {
        sumNegElemens = sumNegElemens + arr[index];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumNegElemens}");




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
        array[index] = new Random().Next(-100, 100);
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