namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            int lastInt;
            int secondLastInt;

            Stack<int> ints = new Stack<int>();
            foreach (char item in data)
            {
                if (char.IsDigit(item))
                {
                    ints.Push(item - '0');
                }
                else
                {                    
                    lastInt = ints.Pop();
                    secondLastInt = ints.Pop();
                    if (item == '+')
                    {
                        ints.Push(secondLastInt - '0' + lastInt - '0');
                    }
                    else if (item == '-')
                    {
                        ints.Push(secondLastInt - '0' - lastInt - '0');
                    }
                    if (item == '*')
                    {
                        ints.Push(secondLastInt - '0' * lastInt - '0');
                    }
                }
            }
            Console.WriteLine(ints.Peek);
        }
    }

    public class StackOnArray
    {
        private int[] items;
        private int size = 0;

        public StackOnArray()
        {
            items = new int[0];
        }

        public void IncreaseArray()
        {
            int newCount = size * 2;
            if (size == 0)
            {
                newCount = 4;
            }
            int[] newArray = new int[newCount];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }

        public string Print()
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                result = items[i] + " " + result;
            }

            return result;
        }
        public bool Empty()
        {
            return size == 0;
        }

        public void Push(int item)
        {
            if (size == items.Length)
            {
                IncreaseArray();
            }

            items[size] = item;
            size++;
        }

        public int Pop()
        {
            if (size == 0)
            {
                throw new Exception("Стек пустой.");
            }

            int lastItem = items[size - 1];
            size--;
            return lastItem;
        }

        public int Peek()
        {
            if (size == 0)
            {
                throw new Exception("Стек пустой.");
            }

            return items[size - 1];
        }

        public void Clear()
        {
            size = 0;
        }
    }
    public class StackOnLinkedList
    {
        private LinkedList<int> items;

        public StackOnLinkedList()
        {
            items = new LinkedList<int>();
        }

        public string Print()
        {
            string result = "";
            foreach (var item in items)
            {
                result = item + " " + result;
            }

            return result;
        }

        public bool Empty()
        {
            return items.Count == 0;
        }

        public void Push(int item)
        {
            items.AddLast(item);
        }
        public int Pop()
        {
            if (items.Count == 0)
            {
                throw new Exception("Стек пустой.");
            }

            int lastItem = items.Last.Value;
            items.RemoveLast();
            return lastItem;
        }

        public int Peek()
        {
            if (items.Count == 0)
            {
                throw new Exception("Стек пустой.");
            }

            return items.Last.Value;
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}
