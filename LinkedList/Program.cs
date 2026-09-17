namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();

            //Node count = singlyLinkedList.FindByIndex(2);
            singlyLinkedList.AddFirst(1);
            singlyLinkedList.AddFirst(3);
            singlyLinkedList.AddFirst(7);
            singlyLinkedList.AddFirst(9);

            Console.WriteLine("сам список:" + singlyLinkedList.Print());
            Console.WriteLine(singlyLinkedList.FindByIndex(2).Value);
        }


        public class Node // узел один, чисто значение и ссылка на следующий узел 
        {
            public int Value;
            public Node Next;

            public Node(int value)
            {
                Value = value;
            }
        }

        public class SinglyLinkedList // уже сам список,  
        {
            public Node Head;
            private int count = 0; // количество элементов в спискпе  

            public void AddFirst(int value)
            {
                Node newNode = new Node(value);
                newNode.Next = Head;
                Head = newNode;
                count++;
            }

            public int GetCount()
            {
                return count;
            }

            public string Print()
            {
                string result = "";
                Node current = Head;
                while (current != null)
                {
                    result += current.Value;
                    current = current.Next;
                }

                return result;
            }
            public Node Find(int key)
            {
                if (count == 0)
                {
                    return null;
                }

                Node current = Head;
                while (current.Value != key)
                {
                    current = current.Next;
                    if (current == null)
                    {
                        return null;
                    }
                }

                return current;
            }

            public Node FindByIndex(int index)
            {
                if (index < 0 || index >= count || Head == null) // проверка от всех бед 
                {
                    return null;
                }

                int currentIndex = 0;

                Node current = Head;

                while (currentIndex != index)
                {
                    current = current.Next;
                    currentIndex++;
                }
                return current;
            }
        }
    }
}
