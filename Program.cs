﻿int GetCheckedNumber (string info, string allowedCharacters)
{
    Console.WriteLine (info);
    string? numberToBeChecked = Console.ReadLine();
    while (IsThereText(numberToBeChecked!, allowedCharacters!) | TestForNullOrEmpty(numberToBeChecked!))
    {
        Console.WriteLine ("Условие не выполнено или строка пуста, попробуйте ввести иначе");
        Console.WriteLine (info);
        numberToBeChecked = Console.ReadLine ();
    }
    int numberOk = Convert.ToInt32(numberToBeChecked);
    return numberOk;
}

bool TestForNullOrEmpty(string s)
{
    bool result;
    result = s == null || s == string.Empty;
    return result;
}

bool IsThereText (string typedNumber, string okChars)
{
    char characterToBeChecked = ' ';
    int checkedChars = 0;
    for (int i = 0; i < typedNumber.Length; i++)
    {
        characterToBeChecked = typedNumber [i];
        for (int j = 0; j < okChars.Length; j++)
        {
            if (characterToBeChecked == okChars [j])
            {
                checkedChars++;
                break;
            }           
        }
    }
    if (checkedChars == typedNumber.Length)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int [,] FillIntMatrix (int [,] matrixToBeFilled)
{
    for (int i = 0; i < matrixToBeFilled.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToBeFilled.GetLength(1); j++)
        {
            matrixToBeFilled [i, j] = new Random().Next(1, 10);
            Console.Write (matrixToBeFilled[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrixToBeFilled;
}
// Task1____________________________________________
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int row = GetCheckedNumber ("Введите количество строк от 1", "123456789");
int column = GetCheckedNumber ("Введите количество столбцов от 1", "123456789");
Console.WriteLine();

double [,] matrixDouble = new double [row, column];

for (int i = 0; i < matrixDouble.GetLength(0); i++)
{
    for (int j = 0; j < matrixDouble.GetLength(1); j++)
    {
        matrixDouble [i, j] = new Random().Next(0, 100) / 10.0;
        if (matrixDouble [i, j] % 1 == 0) // чтобы столбцы выводились ровными, если выпадет целое число
        {
            Console.Write (matrixDouble[i, j] + "    ");
        }
        else
        {
            Console.Write (matrixDouble[i, j] + "  ");
        }
        
    }
    Console.WriteLine();
}
//__________________________________________________

// Task2____________________________________________
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int wishedRow = GetCheckedNumber ("Введите строку элемента", "123456789");
int wishedColumn = GetCheckedNumber ("Введите столбец элемента", "123456789");
int maxRowOfMatrix = new Random().Next(3, 6);
int maxColumnOfMatrix = new Random().Next(4, 7);
while (wishedRow > maxRowOfMatrix | wishedColumn > maxColumnOfMatrix)
{
    Console.WriteLine (@$"Такого числа в массиве нет.
Максимальная строчка нашего массива: {maxRowOfMatrix} и столбец: {maxColumnOfMatrix}");
    wishedRow = GetCheckedNumber ("Введите строку в верном диапазоне", "123456789");
    wishedColumn = GetCheckedNumber ("Введите столбец в верном диапазоне", "123456789");
}
int [,] emptyMatrix = new int [maxRowOfMatrix, maxColumnOfMatrix];
Console.WriteLine("Наш двухмерный массив:");
int [,] filledMatrix = FillIntMatrix (emptyMatrix);
int wishedRowIndex = wishedRow - 1;
int wishedColumnIndex = wishedColumn - 1;
Console.WriteLine (@$"Запрашиваемый элемент (строчка {wishedRow}, столбец {wishedColumn}):
{filledMatrix[wishedRowIndex, wishedColumnIndex]}");
//__________________________________________________

// Task3____________________________________________
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Массив задания 3:");
int maxRowOfMatrix2 = new Random().Next(4, 7);
int maxColumnOfMatrix2 = new Random().Next(5, 8);
int [,] newEmptyMatrix = new int [maxRowOfMatrix2, maxColumnOfMatrix2];
int [,] newFilledMatrix = FillIntMatrix (newEmptyMatrix);
double arithmeticMean = 0;
for (int i = 0; i < newFilledMatrix.GetLength(1); i++)
{
    for (int j = 0; j < newFilledMatrix.GetLength(0); j++)
    {
        arithmeticMean += newFilledMatrix [j, i];
    }
    Console.WriteLine($"Среднее арифметическое в столбце {i+1} равно {arithmeticMean}");
    arithmeticMean = 0;
}

// Здравствуйте, видео по семинару "Урок 7. Двумерные массивы" 
// за 10е июня где-то на 01:43:30 перестает работать
