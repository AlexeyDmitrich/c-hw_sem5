/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
*/

using MyMethods;
Random rnd = new Random();
MyMethod my = new MyMethod();

int len = my.IntInput("длина массива");
int min = my.IntInput("минимальное значение");
int max = my.IntInput("максимальное значение");

double[] useArray = ArrayGen(len,min,max);
my.Print(useArray);
double[] resArray = FindInRange(useArray);
my.Print(resArray);

double[] arr = ArrayGen(len, min, max);
double [] ArrayGen (int arrayLength, int min, int max){
    double [] arr = new double [arrayLength];
        for (int i = 0; i < arrayLength; i++){
            arr[i] = rnd.Next(min, max);
        }
    return arr;
}

double [] FindInRange (double[] array){
    double[] resArr = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; ) {
            if (array[i] < 99 && array[i] > 10){
                resArr[j] = array[i];
                j++;
            } 
        }
    }
    return resArr;
}