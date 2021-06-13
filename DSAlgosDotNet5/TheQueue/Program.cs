using System;

namespace TheQueue
{
    // The Queue Data Structure in .NET 5.0
    //      FIFO
    //      Enqueue - Adding to the end of the queue
    //      Dequeue - Removing from the front of the queue

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MyQueue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public MyQueue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void Insert(long j)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }

                rear++;

                myQueue[rear] = j;
                items++;
            }
        }

        private long Remove()
        {
            long temp = myQueue[front];
            front++;
            if (front == maxSize)
            {
                front = 0;
            }
            return temp;
        }

        public long PeekFront()
        {
            return myQueue[front];
        }
        
        public bool IsEmpty()
        {
            return items == 0;
        }

        private bool IsFull()
        {
            return items == maxSize;
        }
    }
}
