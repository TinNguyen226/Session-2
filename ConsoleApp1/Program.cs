internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap so a:");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.Write("Nhap so b:");
        float b = Convert.ToSingle(Console.ReadLine());
        Console.Write($"Tong hai so a va b: = {a + b}");
    }
}