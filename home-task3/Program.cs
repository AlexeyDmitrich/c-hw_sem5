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
    double max = 0;  // нужно подставить что-то около минус бесконечности
    for (int i =0; i<usersArray; i++){
        if usersArray[i]>max{
            max=usersArray[i];
        }
    }
    return max;
}

double FindMin (double[] usersArray){
    double min = 0; // мне срочно нужна бесконечность
    for (int i =0; i<usersArray; i++){
        if usersArray[i]<min{
            min=usersArray[i];
        }
    }
    return min;
}

double Spread (double min, double max){
    return max - min;
}