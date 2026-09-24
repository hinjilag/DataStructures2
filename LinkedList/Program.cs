namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            SinglyLinkedListWithTail singlyLinkedListWithTail = new SinglyLinkedListWithTail();
            singlyLinkedListWithTail.PushFront(9);
            singlyLinkedListWithTail.PushFront(4);
            singlyLinkedListWithTail.PushFront(2);

            Node node = new Node(4);
            singlyLinkedListWithTail.AddAfter(node, 1);

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
        class SinglyLinkedListWithTail
        {
            public Node Head;
            public Node Tail;

            private int count = 0; // количество элементов в спискпе

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

            public void PushFront(int item)
            {
                Node newNode = new Node(item);

                if (count != 0)
                {
                    newNode.Next = Head;
                }
                else
                {
                    Tail = newNode;
                }

                Head = newNode;
                count++;
            }

            public void PushBack(int item)
            {
                Node newNode = new Node(item);
                if (count == 0)
                {
                    Head = newNode;
                }
                else
                {
                    Tail.Next = newNode;
                }

                count++;
                Tail = newNode;
            }

            public void AddAfter(Node node, int item)
            {
                if (node == null)
                {
                    return;
                }
                Node newNode = new Node(item);

                newNode.Next = node.Next;
                node.Next = newNode;
                if (node == Tail)
                {
                    Tail = newNode;
                }

                count++;
            }

            public void RemoveFirst()
            {
                if (count == 0)
                {
                    throw new Exception("Список пуст");
                }

                if (count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Next;
                }

                count--;
            }
            public void RemoveNode(Node node)
            {
                if (node == Head)
                {
                    RemoveFirst();
                }
                else
                {
                    Node current = Head;
                    while (current.Next != null)
                    {
                        if (current.Next == node)
                        {
                            break;
                        }

                        current = current.Next;
                    }

                    current.Next = node.Next;

                    if (node == Tail)
                    {
                        Tail = current;
                    }

                    count--;
                }
            }
        }
    }
}
