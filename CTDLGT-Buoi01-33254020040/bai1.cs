using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi01_33254020040
{
    public class bai1
    {


        static void Main444(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập c: ");
            int c = int.Parse(Console.ReadLine());


            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));
            Console.WriteLine($"Số lớn nhất là: {max}");
            Console.WriteLine($"Số nhỏ nhất là: {min}");
            Console.WriteLine($"Tổng là: {a + b + c}");
            Console.WriteLine($"Trung bình là: {(a + b + c) / 3.0}");
        }
        
    }
}

