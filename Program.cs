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

// Task1____________________________________________
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int row = GetCheckedNumber ("Введите количество строк", "123456789");
int column = GetCheckedNumber ("Введите количество столбцов", "123456789");
Console.WriteLine();

double [,] arrayDouble = new double [row, column];

for (int i = 0; i < arrayDouble.GetLength(0); i++)
{
    for (int j = 0; j < arrayDouble.GetLength(1); j++)
    {
        arrayDouble [i, j] = new Random().Next(0, 100) / 10.0;
        if (arrayDouble [i, j] % 1 == 0) // чтобы столбцы выводились ровными, если выпадет целое число
        {
            Console.Write (arrayDouble[i, j] + "    ");
        }
        else
        {
            Console.Write (arrayDouble[i, j] + "  ");
        }
        
    }
    Console.WriteLine();
}
//__________________________________________________
