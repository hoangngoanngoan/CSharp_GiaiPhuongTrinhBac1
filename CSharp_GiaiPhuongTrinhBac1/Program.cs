using System.ComponentModel;

internal class Program
{
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Chương trình giải phương trình bậc 1");
        double a, b;
        string ketqua;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        ketqua = gptb1(a, b);
        Console.WriteLine(ketqua);
    }

    private static string gptb1(double a, double b)
    {
        string ketqua;
        ketqua = "";

        if (a == 0 && b == 0)
        {
            ketqua = "Phương trình vô nghiệm";
        }else
        {
            ketqua = Convert.ToString($"Phương trình có 1 nghiệm là {-a / b}");
        }
        
        return ketqua;
        
    }
}
