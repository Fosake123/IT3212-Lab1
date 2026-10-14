
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int chon;

        do
        {
            Console.WriteLine("\n===== MENU VẼ HÌNH =====");
            Console.WriteLine("1. Tam giác vuông đặc");
            Console.WriteLine("2. Tam giác vuông rỗng");
            Console.WriteLine("3. Hình vuông rỗng");
            Console.WriteLine("0. Thoát");
            Console.Write("Mời chọn: ");

            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
                chon = -1;
                continue;
            }

            if (chon >= 1 && chon <= 3)
            {
                Console.Write("Nhập kích thước n = ");
                int n;

                if (!int.TryParse(Console.ReadLine(), out n)
                    || n < 1 || n > 50)
                {
                    Console.WriteLine("n phải từ 1 đến 50.");
                    continue;
                }

                switch (chon)
                {
                    case 1:
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (j == 1 || j == i || i == n)
                                    Console.Write("* ");
                                else
                                    Console.Write("  ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= n; j++)
                            {
                                if (i == 1 || i == n
                                    || j == 1 || j == n)
                                    Console.Write("* ");
                                else
                                    Console.Write("  ");
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            }
            else if (chon != 0)
            {
                Console.WriteLine("Vui lòng chọn từ 0 đến 3.");
            }

        } while (chon != 0);

        Console.WriteLine("Đã kết thúc chương trình.");
    }
}
