using Stack;

namespace TestProject1
{
    public class StackOnArrayTests
    {
        [Test]
        public void Print_Empty_EmptyString()
        {
            // arrage 
            StackOnArray emptyList = new StackOnArray();
            string stringEmpty = string.Empty;

            //act
            string actualResult = emptyList.Print();

            //assert
            Assert.That(actualResult,Is.EqualTo(stringEmpty));
        }

        [Test]
        public void Pop_Empty_Exception()
        {
            StackOnArray stackOnArray = new StackOnArray();
                        
            Assert.Catch<Exception>(() => stackOnArray.Pop());
        }

        [Test]
        public void Pop_NotEmpty_ElementsExceptOne()
        {
            StackOnArray list = new StackOnArray();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            string expectedList = "2 1 ";

            list.Pop();
            string actualList = list.Print();

            Assert.That(actualList, Is.EqualTo(expectedList));
        }

        [Test]
        public void Push_Empty_AddedElement()
        {
            StackOnArray list = new StackOnArray();
            string expectedList = "1 ";

            list.Push(1);
            string actualList = list.Print();

            Assert.That(actualList, Is.EqualTo(expectedList));
        }

        [Test]
        public void Push_NotEmpty_AddedElement()
        {
            StackOnArray list = new StackOnArray();
            list.Push(7);
            list.Push(4);
            list.Push(2);
            string expectedList = "1 2 4 7 ";

            list.Push(1);
            string actualList = list.Print();

            Assert.That(actualList, Is.EqualTo(expectedList));
        }

        [Test]
        public void Peek_Empty_Exception()
        {
            StackOnArray list = new StackOnArray();

            Assert.Catch<Exception>(() => list.Peek());
        }

        [Test]
        public void Peek_NotEmpty_lastItem()
        {
            StackOnArray list = new StackOnArray();
            list.Push(1);
            list.Push(2);
            int lastItem = 2;

            int actealResult = list.Peek();

            Assert.That(actealResult, Is.EqualTo(lastItem));
        }
    }
}
