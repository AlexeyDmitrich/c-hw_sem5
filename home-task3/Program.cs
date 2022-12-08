/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

using MyMethods;
MyMethod my = new MyMethod();

double[] array = my.ArrayGenD();
double min = FindMin(array);
double max = FindMax(array);
double result = Spread(min, max);

my.Print($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива");
my.Print(array);
my.Print($"равна {result}");

double FindMax (double[] usersArray){
    double max = double.NegativeInfinity; 
    for (int i =0; i<usersArray.Length; i++){
        if (usersArray[i]>max){
            max=usersArray[i];
        }
    }
    return max;
}

double FindMin (double[] usersArray){
    double min = usersArray[0]; // double.PositiveInfinity; // с бесконечностью получилось интересней, 
                                                            // но так на один элемент короче
    for (int i =1; i<usersArray.Length; i++){
        if (usersArray[i]<min){
            min=usersArray[i];
        }
    }
    return min;
}

double Spread (double min, double max){
    return max - min;
}