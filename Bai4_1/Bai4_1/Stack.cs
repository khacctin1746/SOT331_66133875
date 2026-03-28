using System.Collections;

namespace Bai4_1;

public class Stack
{
    private int top;
    private int max;
    ArrayList stack;

    public Stack()
    {
        top = -1;
        max = 0;
        stack = new ArrayList();
    }
    
    public Stack(int top, int max)
    {
        this.top = top;
        this.max = max;
        stack = new ArrayList();
    }

    public void Push(int data)
    {
        stack.Add(data);
    }

    public void Pop()
    {
        stack.RemoveAt(stack.Count - 1);
    }

    public void Peek()
    {
        top = (int)stack[stack.Count - 1];
        Console.WriteLine(top);
    }
    
    public void isEmpty()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Stack isn't empty");
        }
    }

    public void PrintStack()
    {
        for (int i = 0; i < stack.Count; i++)
        {
            Console.WriteLine(stack[i]);
        }
    }
}