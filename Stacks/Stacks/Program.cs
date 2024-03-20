namespace StackImplementation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stack<string> books = new(10);
            books.Push("The C# Guide");
            books.Push("The Java Guide");
            books.Push("The Python Guide");
            books.Push("The C++ Guide");
            Console.WriteLine(books.IsFull());
            Console.WriteLine(books.Pop());
        }
    }

    public class Stack<T>
    {
        private List<T> staticStack = new();
        private int maxSize;
        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
        }

        public void Push(T item)
        {
            if (!IsFull())
            {
                staticStack.Add(item);
            }
            else
            {
                throw new StackOverflowException("Stack is full.");
            }
        }

        public bool IsFull()
        {
            return staticStack.Count == maxSize;
        }

        public bool IsEmpty()
        {
            return staticStack.Count == 0;
        }

        public int Size()
        {
            return staticStack.Count;
        }

        public T Peek()
        {
            return staticStack[^1];
        }

        public T Pop()
        {
            T temp = default;
            if (!IsEmpty())
            {
                temp = staticStack[^1];
                staticStack.RemoveAt(Size() - 1);
            }
            else
            {
                throw new IndexOutOfRangeException("Stack is empty.");
            }
            return temp;
        }
    }
}