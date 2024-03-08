internal class Program
{
    private static void Main(string[] args)
    {
        Queue<int> queueOne = new(5);
        queueOne.EnQueue(15);
        queueOne.EnQueue(1);
        queueOne.EnQueue(9);
        queueOne.EnQueue(6);
        Console.WriteLine(queueOne.Peek());
    }
}

public class Queue<T>
{
    private T[] staticArray;
    private int maxSize;
    private int currentSize;
    private int frontPointer;
    private int rearPointer;
    public Queue(int maxSize)
    {
        this.maxSize = maxSize;
        staticArray = new T[maxSize];
        frontPointer = 0;
        rearPointer = -1;
    }

    public bool IsFull()
    {
        return rearPointer == maxSize - 1;
    }

    public bool IsEmpty()
    {
        return currentSize == 0;
    }

    public void EnQueue(T item)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("Queue is full");
        }
        else
        {
            rearPointer++;
            currentSize++;
            staticArray[rearPointer] = item;
        }
    }

    public T DeQueue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }
        else
        {
            T item = staticArray[frontPointer];
            staticArray[frontPointer] = default;
            frontPointer++;
            currentSize--;
            return item;
        }
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }
        else
        {
            return staticArray[frontPointer];
        }
    }
}