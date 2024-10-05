namespace HomeworkAlgorithm1
{
    internal class Program
    {
        // Task 1
        //    static void Main()
        //    {
        //        int[] array = { 17, 10, 21, 3, 7 };
        //        InsertionSortRecursive(array, array.Length);
        //        Console.WriteLine("Sorted array: ");
        //        PrintArray(array);
        //    }

        //    static void InsertionSortRecursive(int[] array, int n)
        //    {
        //        if (n <= 1)
        //            return;

        //        InsertionSortRecursive(array, n - 1);

        //        int last = array[n - 1];
        //        int j = n - 2;

        //        while (j >= 0 && array[j] > last)
        //        {
        //            array[j + 1] = array[j];
        //            j--;
        //        }
        //        array[j + 1] = last;
        //    }

        //    static void PrintArray(int[] array)
        //    {
        //        foreach (int element in array)
        //        {
        //            Console.Write(element + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}


        // Task 2
        static void Main()
        {
            CustomQueue<int> queue = new CustomQueue<int>(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Is Queue Empty: " + queue.IsEmpty());
            Console.WriteLine("Is Queue Full: " + queue.IsFull());
            Console.WriteLine("Queue Count: " + queue.Count());
        }
    }
    public class CustomQueue<T>
    {
        private T[] _elements;
        private int _front;
        private int _rear;
        private int _max;
        private int _count;

        public CustomQueue(int size)
        {
            _elements = new T[size];
            _front = 0;
            _rear = -1;
            _max = size;
            _count = 0;
        }

        public void Enqueue(T item)
        {
            if (_count == _max)
            {
                Console.WriteLine("Queue is full!");
                return;
            }
            _rear = (_rear + 1) % _max;
            _elements[_rear] = item;
            _count++;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue is empty!");
                throw new InvalidOperationException("Queue is empty");
            }
            T item = _elements[_front];
            _front = (_front + 1) % _max;
            _count--;
            return item;
        }

        public T Peek()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue is empty!");
                throw new InvalidOperationException("Queue is empty");
            }
            return _elements[_front];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _max;
        }

        public int Count()
        {
            return _count;
        }
    }
}
