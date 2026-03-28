namespace Bai4_1;

public class PrimeStack : Stack
{
    public PrimeStack()
    {
        
    }
    public PrimeStack(int top, int max) : base(top, max)
    {
        
    }

    public void push(int data)
    {
        base.Push(data);
    }

    public void pop()
    {
        base.Pop();
    }

    public override void PrintStack()
    {
        for (int i = 0; i < stack.Count; i++)
        {
            Console.Write(stack[i] + " ");
        }
    }
}