
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số lượng phần tử n = ");
        int n;

        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("n phải là số nguyên dương.");
            return;
        }

        int[] a = new int[n];
        long tong = 0;
        int lonNhat, nhoNhat;
        int demChan = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập a[{i}] = ");

            if (!int.TryParse(Console.ReadLine(), out a[i]))
            {
                Console.WriteLine("Vui lòng nhập số nguyên.");
                return;
            }
        }

        lonNhat = a[0];
        nhoNhat = a[0];

        for (int i = 0; i < n; i++)
        {
            tong += a[i];

            if (a[i] > lonNhat)
                lonNhat = a[i];

            if (a[i] < nhoNhat)
                nhoNhat = a[i];

            if (a[i] % 2 == 0)
                demChan++;
        }

        double trungBinh = (double)tong / n;

        Console.WriteLine("\n===== KẾT QUẢ THỐNG KÊ =====");
        Console.WriteLine($"Tổng = {tong}");
        Console.WriteLine($"Trung bình = {trungBinh:F2}");
        Console.WriteLine($"Số lớn nhất = {lonNhat}");
        Console.WriteLine($"Số nhỏ nhất = {nhoNhat}");
        Console.WriteLine($"Số lượng số chẵn = {demChan}");
    }
}
