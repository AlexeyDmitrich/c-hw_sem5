/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

using MyMethods;
MyMethod my = new MyMethod();

double[] array = my.ArrayGenD();
double result = Spread(FindMin(array), FindMax(array));

double FindMax (double[] usersArray){
    double max = 0;
// todo: make realisation 
    return max;
}

double FindMin (double[] usersArray){
    double min = 0;
// todo: make realisation
    return min;
}

double Spread (double min, double max){
    return max - min;
}