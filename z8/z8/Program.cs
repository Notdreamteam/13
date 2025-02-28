using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z8
{
    class Program
    {
        // Класс для работы с восьмеричными числами
        public class OctalConverter
        {
            // Метод для перевода восьмеричного числа в десятичное
            public int ConvertOctalToDecimal(int octalNumber)
            {
                int decimalValue = 0;
                int baseValue = 1;

                while (octalNumber > 0)
                {
                    int lastDigit = octalNumber % 10;
                    if (lastDigit >= 8)
                    {
                        throw new ArgumentException("Некорректное восьмеричное число.");
                    }

                    decimalValue += lastDigit * baseValue;
                    octalNumber /= 10;
                    baseValue *= 8;
                }

                return decimalValue;
            }
        }

        // Класс для работы с массивами
        public class ArrayProcessor
        {
            private OctalConverter _octalConverter;

            public ArrayProcessor()
            {
                _octalConverter = new OctalConverter();
            }

            // Метод для перевода массива восьмеричных чисел в десятичные
            public int[] ConvertOctalArrayToDecimal(int[] octalArray)
            {
                int[] decimalArray = new int[octalArray.Length];
                for (int i = 0; i < octalArray.Length; i++)
                {
                    decimalArray[i] = _octalConverter.ConvertOctalToDecimal(octalArray[i]);
                }
                return decimalArray;
            }
        }

        // Основной класс программы
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса ArrayProcessor
                ArrayProcessor arrayProcessor = new ArrayProcessor();

                // Ввод массива из 9 двузначных восьмеричных чисел
                int[] octalArray = new int[9];
                Console.WriteLine("Введите 9 двузначных чисел в восьмеричной системе счисления:");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    octalArray[i] = int.Parse(Console.ReadLine());
                }

                try
                {
                    // Перевод массива восьмеричных чисел в десятичные
                    int[] decimalArray = arrayProcessor.ConvertOctalArrayToDecimal(octalArray);

                    // Вывод нового массива
                    Console.WriteLine("Новый массив (в десятичной системе счисления):");
                    for (int i = 0; i < decimalArray.Length; i++)
                    {
                        Console.Write($"{decimalArray[i]} ");
                    }
                }
                catch (ArgumentException ex)
                {
                    // Обрабатываем ошибку, если введено некорректное восьмеричное число
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
