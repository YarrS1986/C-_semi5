// апишите программу замена элементов массива:  
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// Например, [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int[] arr = new int[4];

FindArray(arr);
FillArray(arr);
RandArray(arr);

void RandArray(int[] randArray)
{
    Console.Write($" -> [ ");
    for (int index = 0; index < randArray.Length; index++)
    {
        randArray[index] = randArray[index] * -1;
        Console.Write($"{randArray[index]}, ");
    }
    Console.Write("]");
}





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