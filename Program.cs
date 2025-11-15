using System;
class GiaiPTBac1
{
    protected double a, b;
    public GiaiPTBac1(double a, double b)
    {
        this.a = a;
        this.b = b;
    }
    public virtual void Giai()
    {
        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("Phương trình vô số nghiệm.");
            else
                Console.WriteLine("Phương trình vô nghiệm.");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Nghiệm của phương trình bậc 1: x = " + x);
        }
    }
}
class GiaiPTBac2 : GiaiPTBac1
{
    private double c;
   public GiaiPTBac2(double a, double b, double c) : base(a, b)
    {
        this.c = c;
    }
    public override void Giai()
    {
        if (a == 0)
        {
            Console.WriteLine("a = 0 → trở thành phương trình bậc 1:");
            base.Giai();
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phương trình có nghiệm kép: x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm thực:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine())
        Console.Write("Nhập c: ");
        double c = double.Parse(Console.ReadLine());
        GiaiPTBac2 pt = new GiaiPTBac2(a, b, c);
        Console.WriteLine("\nKết quả:");
        pt.Giai()
        Console.ReadLine();
    }
}
