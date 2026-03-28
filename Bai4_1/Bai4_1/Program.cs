namespace Bai4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.WriteLine("Vui long nhap n: "); 
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    stack.Push(i);
                    n /= i;
                }
            }

            if (n > 1)
            {
                stack.Push(n);
            }
            
            // stack.Peek();
            // stack.isEmpty();
            stack.PrintStack();
        }
    }
}