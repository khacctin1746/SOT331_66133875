namespace Bai4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new PrimeStack();
            Stack stack1 = new HexaStack();

            Console.WriteLine("Vui long nhap n: "); 
            int n = Convert.ToInt32(Console.ReadLine());
            int nguyento = n;
            int hexa = n;
            for (int i = 2; i * i <= nguyento; i++)
            {
                while (nguyento % i == 0)
                {
                    stack.Push(i);
                    nguyento /= i;
                }
            }

            if (nguyento > 1)
            {
                stack.Push(nguyento);
            }

            while (hexa > 0)
            {
                stack1.Push(hexa % 16);
                hexa /= 16;
            }
            
            // stack.Peek();
            // stack.isEmpty();
            //stack.PrintStack();
            stack.PrintStack();
            stack1.PrintStack();
            //primeStack.PrintStack();
            //hexaStack.PrintStack();
        }
    }
}