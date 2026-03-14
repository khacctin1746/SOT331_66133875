namespace caculator
{
    class calculator
    {
        static void Main(string[] args)
        {
            int a, b;
            char phepToan;
            double ketqua = 0;
            
            Console.Write("Nhap a: "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap phep toan (+,-,*,/): "); phepToan = Convert.ToChar(Console.ReadLine());
            if (phepToan == '+')
            {
                ketqua = a + b;
            } else if (phepToan == '-')
            {
                ketqua = a - b;
            } else if (phepToan == '*')
            {
                ketqua = a * b;
            } else if (phepToan == '/')
            {
                ketqua = a / b;
            }
            
            Console.WriteLine(ketqua);
        }
    }
}