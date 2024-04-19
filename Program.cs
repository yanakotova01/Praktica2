﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите функцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Возведение в степень");
        Console.WriteLine("6. Вычисление квадратного корня");
        Console.WriteLine("7. Вычисление синуса");
        Console.WriteLine("8. Вычисление косинуса");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Addition();
                break;
            case 2:
                Subtraction();
                break;
            case 3:
                Multiplication();
                break;
            case 4:
                Division();
                break;
            case 5:
                Power();
                break;
            case 6:
                SquareRoot();
                break;
            case 7:
                Sin();
                break;
            case 8:
                Cos();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }

    static void Addition()
    {
        double a = 5;
        double b = 3;
        double result = a + b;
        Console.WriteLine($"Сумма: {result}");
    }

    static void Subtraction()
    {
        double a = 5;
        double b = 3;
        double result = a - b;
        Console.WriteLine($"Разность: {result}");
    }

    static void Multiplication()
    {
        double a = 5;
        double b = 3;
        double result = a * b;
        Console.WriteLine($"Произведение: {result}");
    }

    static void Division()
    {
        double a = 6;
        double b = 3;
        double result = a / b;
        Console.WriteLine($"Частное: {result}");
    }