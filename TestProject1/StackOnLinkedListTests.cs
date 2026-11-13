using Stack;

namespace TestProject1
{
    public class StackOnLinkedListTests
    {
        [Test]
        public void Print_Empty_EmptyString()
        {
            StackOnLinkedList list = new StackOnLinkedList();
            string EmptyList = string.Empty;

            string actualList = list.Print();

            Assert.That(actualList, Is.EqualTo(EmptyList));
        }

        [Test]
        public void Print_NotEmpty_ActualList()
        {
            StackOnLinkedList list = new StackOnLinkedList();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            string expectedList = "3 2 1 ";

            string actualList = list.Print();

            Assert.That(actualList, Is.EqualTo(expectedList));
        }

        [Test]

    }
}
