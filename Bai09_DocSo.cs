
using System;

class Program
{
    static string DocHangDonVi(int n)
    {
        switch (n)
        {
            case 0: return "không";
            case 1: return "một";
            case 2: return "hai";
            case 3: return "ba";
            case 4: return "bốn";
            case 5: return "năm";
            case 6: return "sáu";
            case 7: return "bảy";
            case 8: return "tám";
            case 9: return "chín";
            default: return "";
        }
    }

    static string DocSo(int n)
    {
        if (n < 10)
            return DocHangDonVi(n);

        int chuc = n / 10;
        int donVi = n % 10;

        if (chuc == 1)
        {
            switch (donVi)
            {
                case 0: return "mười";
                case 1: return "mười một";
                case 4: return "mười bốn";
                case 5: return "mười lăm";
                default: return "mười " + DocHangDonVi(donVi);
            }
        }

        string ketQua = DocHangDonVi(chuc) + " mươi";

        if (donVi == 0)
            return ketQua;

        if (donVi == 1)
            return ketQua + " mốt";

        if (donVi == 4)
            return ketQua + " tư";

        if (donVi == 5)
            return ketQua + " lăm";

        return ketQua + " " + DocHangDonVi(donVi);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên từ 0 đến 99: ");
        int n;

        if (!int.TryParse(Console.ReadLine(), out n)
            || n < 0 || n > 99)
        {
            Console.WriteLine("Số phải nằm trong khoảng từ 0 đến 99.");
            return;
        }

        Console.WriteLine($"Cách đọc: {DocSo(n)}");
    }
}
