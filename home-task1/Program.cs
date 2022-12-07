/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using MyMethods;
MyMethod my = new MyMethod();
Random rnd = new Random();

int[] usersArray = ArrayGen();
int quantOfEvens = QuantityOfEvenNums(usersArray);
my.PrintArr(usersArray);
my.Print($"В полученном массиве {quantOfEvens} четных чисел");

// метод для генерации массива 
int[] ArrayGen()
{
    int length = my.IntInput("длина массива");
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);  // [100; 1000)
    }
    // отладка:
    // my.PrintArr(array);

    return array;
}

// метод подсчета четных чисел
int QuantityOfEvenNums(int[] userArray)
{
    int counter = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] % 2 == 0) counter++;
    }
    return counter;
}