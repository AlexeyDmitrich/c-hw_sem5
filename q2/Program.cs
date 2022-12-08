﻿/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да
*/
using MyMethods;
using System;
//{

/*cHwSem5.*/MyMethod my = new MyMethod();
Random rnd = new Random();

int len = my.IntInput("длина массива");
int min = my.IntInput("минимальное значение");
int max = my.IntInput("максимальное значение");
double[] arr = ArrayGen(len, min, max);
my.Print(arr);
double findNum = my.DoubleInput("искомое значение");
bool isNumberInArray = FindNumInArray(arr, findNum);
my.Print($"{isNumberInArray}");



double [] ArrayGen (int arrayLength, int min, int max){
    double [] arr = new double [arrayLength];
        for (int i = 0; i < arrayLength; i++){
            arr[i] = rnd.Next(min, max);
        }
    return arr;
}

bool FindNumInArray (double[] arr, double num){
    bool IsInAr = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num){
            return true;
        }
    }
    return IsInAr;
}
