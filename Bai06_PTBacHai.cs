
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double a, b, c;

        Console.Write("Nhập a = ");
        if (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Hệ số a không hợp lệ.");
            return;
        }

        Console.Write("Nhập b = ");
        if (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Hệ số b không hợp lệ.");
            return;
        }

        Console.Write("Nhập c = ");
        if (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Hệ số c không hợp lệ.");
            return;
        }

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phương trình vô số nghiệm.");
                else
                    Console.WriteLine("Phương trình vô nghiệm.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phương trình có nghiệm x = {x:F2}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm thực.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Nghiệm kép x = {x:F2}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"Nghiệm x1 = {x1:F2}");
                Console.WriteLine($"Nghiệm x2 = {x2:F2}");
            }
        }
    }
}
