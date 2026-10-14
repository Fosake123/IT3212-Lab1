
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập bán kính r = ");
        double r;

        if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
        {
            Console.WriteLine("Bán kính phải là số lớn hơn 0.");
            return;
        }

        Console.Write("Nhập chiều cao h = ");
        double h;

        if (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
        {
            Console.WriteLine("Chiều cao phải là số lớn hơn 0.");
            return;
        }

        double dienTichXQ = 2 * Math.PI * r * h;
        double theTich = Math.PI * r * r * h;

        Console.WriteLine($"Diện tích xung quanh = {dienTichXQ:N2}");
        Console.WriteLine($"Thể tích = {theTich:N2}");
    }
}
