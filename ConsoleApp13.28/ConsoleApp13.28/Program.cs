using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] binaryNumbers = { 0, 1, 1, 0, 1, 0, 1 };
            Console.WriteLine("Введите число D");
            int D = Convert.ToInt32(Console.ReadLine());

            BinaryArray binaryArray = new BinaryArray(binaryNumbers);
            var result = binaryArray.FindFurthestFrom(D);

            Console.WriteLine($"Наиболее удаленный элемент: значение = {result.value}, индекс = {result.index}");
        }
    }
}
