internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap he so a tu ban phim: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gia tri a ban nhap vao la: "+ a);    
        Console.WriteLine("Nhap he so b tu ban phim: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gia tri b ban nhap vao la: "+ b);    
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem.");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Nghiem cua phuong trinh nay la: " + x);
        }

        Console.ReadLine();
    }
}