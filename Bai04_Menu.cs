
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int chon;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Tính tổng từ 1 đến n");
            Console.WriteLine("2. In bảng cửu chương 7");
            Console.WriteLine("0. Thoát");
            Console.Write("Mời bạn chọn: ");

            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Vui lòng nhập số nguyên.");
                chon = -1;
                continue;
            }

            switch (chon)
            {
                case 1:
                    Console.Write("Nhập n = ");
                    int n;

                    if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
                    {
                        Console.WriteLine("n phải là số nguyên dương.");
                        break;
                    }

                    long tong = 0;

                    for (int i = 1; i <= n; i++)
                    {
                        tong += i;
                    }

                    Console.WriteLine($"Tổng từ 1 đến {n} = {tong}");
                    break;

                case 2:
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"7 x {i} = {7 * i}");
                    }
                    break;

                case 0:
                    Console.WriteLine("Đã thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }

        } while (chon != 0);
    }
}
