﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6
{
    class Program
    {
        public class BinaryToHexadecimalConverter
        {
            // Метод для проверки, является ли строка двоичным дробным числом
            private bool IsBinaryFraction(string input)
            {
                foreach (char c in input)
                {
                    if (c != '0' && c != '1' && c != '.')
                    {
                        return false;
                    }
                }
                return true;
            }

            // Метод для преобразования целой части двоичного числа в десятичное
            private double ConvertBinaryToDecimal(string binary)
            {
                double decimalValue = 0;
                for (int i = 0; i < binary.Length; i++)
                {
                    if (binary[binary.Length - 1 - i] == '1')
                    {
                        decimalValue += Math.Pow(2, i);
                    }
                }
                return decimalValue;
            }

            // Метод для преобразования дробной части двоичного числа в десятичное
            private double ConvertBinaryFractionToDecimal(string binaryFraction)
            {
                double decimalValue = 0;
                for (int i = 0; i < binaryFraction.Length; i++)
                {
                    if (binaryFraction[i] == '1')
                    {
                        decimalValue += Math.Pow(2, -(i + 1));
                    }
                }
                return decimalValue;
            }

            // Метод для преобразования десятичного числа в шестнадцатеричное
            private string ConvertDecimalToHexadecimal(double decimalValue)
            {
                // Разделяем число на целую и дробную части
                long integerPart = (long)decimalValue;
                double fractionalPart = decimalValue - integerPart;

                // Преобразуем целую часть в шестнадцатеричное число
                string hexIntegerPart = Convert.ToString(integerPart, 16).ToUpper();

                // Преобразуем дробную часть в шестнадцатеричное число
                string hexFractionalPart = "";
                while (fractionalPart > 0)
                {
                    fractionalPart *= 16;
                    int digit = (int)fractionalPart;
                    hexFractionalPart += digit.ToString("X");
                    fractionalPart -= digit;
                }

                // Возвращаем результат, объединяя целую и дробную части
                return hexFractionalPart.Length > 0 ? $"{hexIntegerPart}.{hexFractionalPart}" : hexIntegerPart;
            }

            // Основной метод для преобразования двоичного дробного числа в шестнадцатеричное
            public string Convert(string binaryInput)
            {
                // Проверяем, является ли введенная строка двоичным дробным числом
                if (!IsBinaryFraction(binaryInput))
                {
                    throw new FormatException("Ошибка: введено некорректное двоичное дробное число.");
                }

                // Разделяем число на целую и дробную части
                string[] parts = binaryInput.Split('.');
                string integerPart = parts[0];
                string fractionalPart = parts.Length > 1 ? parts[1] : "0";

                // Преобразуем целую часть в десятичное число
                double decimalValue = ConvertBinaryToDecimal(integerPart);

                // Преобразуем дробную часть в десятичное число и добавляем к результату
                decimalValue += ConvertBinaryFractionToDecimal(fractionalPart);

                // Преобразуем десятичное число в шестнадцатеричное
                return ConvertDecimalToHexadecimal(decimalValue);
            }
        }

        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса BinaryToHexadecimalConverter
                BinaryToHexadecimalConverter converter = new BinaryToHexadecimalConverter();

                // Запрашиваем у пользователя ввод двоичного дробного числа
                Console.Write("Введите двоичное дробное число (например, 101.101): ");
                string binaryInput = Console.ReadLine();

                try
                {
                    // Преобразуем двоичное дробное число в шестнадцатеричное
                    string hexValue = converter.Convert(binaryInput);
                    // Выводим результат
                    Console.WriteLine($"Шестнадцатеричное представление: {hexValue}");
                }
                catch (FormatException ex)
                {
                    // Обрабатываем ошибку, если введено некорректное двоичное дробное число
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
