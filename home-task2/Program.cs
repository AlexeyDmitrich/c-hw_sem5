/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using MyMethods;
MyMethod my = new MyMethod();

int[] array = my.ArrayGen();

int result = SumUnevenElements(array);
my.Print("Сумма элементов, стоящих на нечётных позициях массива");
my.PrintArr(array);
my.Print($"равна {result}");

//TestSumUnevenElements();

void TestSumUnevenElements (){
    int [] request1 = new int[]{3, 7, 23, 12};
    int responce1 = 19;
    int [] request2 = new int[]{-4, -6, 89, 6};
    int responce2 = 0;
    if (SumUnevenElements(request1)==responce1 && SumUnevenElements(request2)==responce2){
        my.Print("Тестирование прошло успешно");
    } else {
        my.Print($"Тест 1. Ожидается: {responce1} фактический результат: {SumUnevenElements(request1)}");
        my.Print($"Тест 2. Ожидается: {responce2} фактический результат: {SumUnevenElements(request2)}");
    }
}

int SumUnevenElements (int[] usersArray){
    int length = usersArray.Length;
    int[] arr = usersArray;
    int sum = 0;
    for (int i = 1; i < length; i+=2)    // нулевой индекс считаю первой позицией, соответственно, нечетной.
    {
        sum += arr[i];
    }
    return sum;
}