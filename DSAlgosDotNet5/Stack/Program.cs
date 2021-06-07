using System;
using static System.Console;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack(4);
            theStack.Push("Star Wars");
            theStack.Push("Jaws");
            theStack.Push("Jaws2");
            theStack.Push("Titanic");
            theStack.Push("Rocky");

            WriteLine("=================== \nAbout to Peek:\n");
            WriteLine($"\'{theStack.Peek()}\' is at the top of the stack.\n");

            WriteLine("=================== \nThe Stack Contains:\n");
            while (!theStack.IsEmpty())
            {
                string movie = theStack.Pop();
                WriteLine(movie);
            }
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

        public string Peek()
        {
            return stackArray[top];        
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return maxSize - 1 == top;
        }
    }
}
