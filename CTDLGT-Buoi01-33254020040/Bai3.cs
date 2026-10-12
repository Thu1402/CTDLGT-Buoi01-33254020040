using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CTDLGT_Buoi01_33254020040
{
    public class Bai3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập số thứ {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Stopwatch stopwatchA = Stopwatch.StartNew();

            long resultA = MaxSubarrayA(array);
            stopwatchA.Stop();

            Stopwatch stopwatchB = Stopwatch.StartNew();

            long resultB = MaxSubarrayB(array);
            stopwatchB.Stop();

            Console.WriteLine("\n--- kết quả ---");

            Console.WriteLine($"\nPhiên bản A (Θ(n²)):");
            Console.WriteLine($"  - Tổng lớn nhất: {resultA}");

           
            Console.WriteLine($"  - Thời gian: {stopwatchA.Elapsed.TotalMilliseconds:F4} ms");

            Console.WriteLine($"\nPhiên bản B (Kadane Θ(n)):");
            Console.WriteLine($"  - Tổng lớn nhất: {resultB}");
            
            Console.WriteLine($"  - Thời gian: {stopwatchB.Elapsed.TotalMilliseconds:F4} ms");

        }
        static long MaxSubarrayA(int[] array)
        {
            long maxSum = long.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                long currentSum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }
        static long MaxSubarrayB(int[] array)
        {
            long maxSum = long.MinValue;
            long currentSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                currentSum += array[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }
            return maxSum;
        }
    }
}
