﻿// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int[] numbers = { 1, 8, 3, 10, 4, 9 };
int[] evenNumbers = new int [numbers.Length];


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 8) evenNumbers[i] = numbers[i];
}
