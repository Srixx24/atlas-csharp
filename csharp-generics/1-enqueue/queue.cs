using System;

class Queue<T>
{
    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    public void Enqueue(T item)
    {
        Node newNode = new Node(item);

        if (tail == null)
        {
            head = tail;
            tail = newNode;
        }

        count++;
    }

    public int Count()
    {
        return count;
    }
}