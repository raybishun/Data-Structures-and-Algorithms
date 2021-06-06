using System;
using static System.Console;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Stack 
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void Push(string m)
        {
            if (IsFull())
            {
                WriteLine("Stack is full.");
            }
            else 
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                WriteLine("Stack is full.");
                return "--";
            }
            else 
            {
                int old_top = top;
                top--;
                return stackArray[old_top];
            }
        }

        private bool IsFull()
        {
            return maxSize - 1 == top;
        }

        private bool IsEmpty()
        {
            return top == -1;
        }
    }
}
