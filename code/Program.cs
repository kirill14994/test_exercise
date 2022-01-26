// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] SortArray(int[] array)
{
    int index = 0;
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 8)
        {
            newArray[index] = array[i];
            index++;
        }

    }

    Array.Resize(ref newArray, index);
    return newArray;
}

int[] numbers = { 1, 8, 3, 10, 4, 9, -2, 13, 5 };


Console.WriteLine("Даны числа: ");
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine("Числа больше 8: ");
PrintArray(SortArray(numbers));