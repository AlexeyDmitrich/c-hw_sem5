/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
using MyMethods;
MyMethod my = new MyMethod();
Random rnd = new Random();

int len = my.IntInput("Длина массива");
int min = my.IntInput("минимальное значение");
int max = my.IntInput("максимальное значение");
double[] arr = ArrayGen(len, min, max);
my.Print(arr);
arr = ArrReverse(arr);
my.Print(arr);

double [] ArrayGen (int arrayLength, int min, int max){
    double [] arr = new double [arrayLength];
        for (int i = 0; i < arrayLength; i++){
            arr[i] = rnd.Next(min, max);
        }
    return arr;
}

double [] ArrReverse (double [] array){
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}