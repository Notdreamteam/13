using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z9
{
    class Class1
    {
        // Класс для работы с числами
        public class NumberProcessor
        {
            // Метод для извлечения старшего разряда (десятков) из двузначного числа
            public int ExtractTensDigit(int number)
            {
                if (number < 10 || number > 99)
                {
                    throw new ArgumentException("Число должно быть двузначным.");
                }

                return number / 10; // Возвращаем десятки
            }
        }

        // Класс для работы с массивами
        public class ArrayProcessor
        {
            private NumberProcessor _numberProcessor;

            public ArrayProcessor()
            {
                _numberProcessor = new NumberProcessor();
            }

            // Метод для получения массива из старших разрядов элементов исходного массива
            public int[] ExtractTensDigitsFromArray(int[] originalArray)
            {
                int[] newArray = new int[originalArray.Length];
                for (int i = 0; i < originalArray.Length; i++)
                {
                    newArray[i] = _numberProcessor.ExtractTensDigit(originalArray[i]);
                }
                return newArray;
            }
        }

        // Основной класс программы
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса ArrayProcessor
                ArrayProcessor arrayProcessor = new ArrayProcessor();

                // Ввод массива из 7 двузначных целых чисел
                int[] originalArray = new int[7];
                Console.WriteLine("Введите 7 двузначных целых чисел:");

                for (int i = 0; i < 7; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    originalArray[i] = int.Parse(Console.ReadLine());
                }

                try
                {
                    // Получение нового массива из старших разрядов
                    int[] newArray = arrayProcessor.ExtractTensDigitsFromArray(originalArray);

                    // Вывод нового массива
                    Console.WriteLine("Новый массив (старшие разряды):");
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        Console.Write($"{newArray[i]} ");
                    }
                }
                catch (ArgumentException ex)
                {
                    // Обрабатываем ошибку, если введено некорректное число
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
