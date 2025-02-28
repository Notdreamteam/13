using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z15
{
    class Program
    {
        
        public class BinaryNumberProcessor
        {
           
            public int BinaryToInt(string binary)
            {
                return Convert.ToInt32(binary, 2);
            }

            
            public string IntToBinary(int number)
            {
                return Convert.ToString(number, 2);
            }

           
            public string[] SortBinaryArrayAscending(string[] binaryArray)
            {
              
                int[] intArray = binaryArray.Select(b => BinaryToInt(b)).ToArray();

             
                Array.Sort(intArray);

                return intArray.Select(i => IntToBinary(i)).ToArray();
            }

           
            public double AverageBinaryArray(string[] binaryArray)
            {
                return binaryArray.Average(b => BinaryToInt(b));
            }
        }

       
        public class MainClass
        {
            public static void Main(string[] args)
            {
           
                BinaryNumberProcessor binaryProcessor = new BinaryNumberProcessor();

              
                string[] binaryArray = new string[5]; 
                Console.WriteLine("Введите 5 двоичных чисел:");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    binaryArray[i] = Console.ReadLine();
                }

                
                string[] sortedArray = binaryProcessor.SortBinaryArrayAscending(binaryArray);

               
                double average = binaryProcessor.AverageBinaryArray(binaryArray);

               
                Console.WriteLine("Отсортированный массив по возрастанию:");
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    Console.Write($"{sortedArray[i]} ");
                }

               
                Console.WriteLine($"\nСреднее значение чисел: {average}");
            }
        }
    }
}
