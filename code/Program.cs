// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0) Console.Write($"{array[i]} ");
    }
}

void SortArray(int[] array, int[] newArray)
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 8) newArray[i] = array[i];
}
}

int[] numbers = { 1, 8, 3, 10, 4, 9, -2, 13, 5 };
int[] evenNumbers = new int [numbers.Length];

Console.WriteLine("Даны числа: ");
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine("Числа больше 8: ");
SortArray(numbers, evenNumbers);
PrintArray(evenNumbers);