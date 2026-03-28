using System.Collections;

namespace Bai4_1;

public class HexaStack : Stack
{
    public HexaStack()
    {
        
    }
    
    public HexaStack(int top, int max) : base(top, max)
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
            int value = (int)stack[i];
            if (value < 10)
            {
                Console.Write(value);
            } else
            {
                Console.Write((char)(value - 10 + 'a'));
            }
        }
    }
}