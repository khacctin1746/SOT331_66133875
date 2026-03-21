using System;
namespace Bai2_5
{
    public class Stack
    {
        private int top;
        private int max;
        private int[] stack;

        public Stack()
        {
            this.top = -1;
            this.max = 10;
            this.stack = new int[max];
        }

        public void Push(int x)
        {
            top++;
            stack[top] = x;
        }

        public void Xuat()
        {
            for (int i = 0; i < stack.Length; i++)
            {
                Console.Write(stack[i] + " * ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.Write("Vui long nhap mot so: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int dem = 2;
            for (int i = 0; i < 10; i++)
            {
                if (n % 2 == 0 && n != 0)
                {
                    n /= 2;
                    stack.Push(2);
                }
                else if (n % dem == 0 && n != 0)
                {
                    stack.Push(dem);
                    n /= dem;
                }
                else
                {
                    dem++;
                }
            }
        }
    }
}