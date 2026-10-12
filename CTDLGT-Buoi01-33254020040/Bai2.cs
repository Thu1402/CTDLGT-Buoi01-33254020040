using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi01_33254020040
{
    public class Bai2
    {
        static void Main444(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập số thứ {i + 1}: ");
                int x = int.Parse(Console.ReadLine());
                if (x > max1)
                {
                    max2 = max1;
                    max1 = x;
                }
                else if (x > max2 && x != max1)
                {
                    max2 = x;
                }
            }
            Console.WriteLine($"Số lớn nhất là: {max1}");
            if (max2 == int.MinValue)
            {
                Console.WriteLine("No");
            }

            else
            {
                Console.WriteLine($"Số lớn thứ 2 là: {max2}");
            }
        }
        
    }
}
