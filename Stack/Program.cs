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
}
