using Stack;

namespace TestsProject1
{
    public class StackOnArrayTests
    {
        
        
        [Test]
        public void Print_Empty_EmptyString()
        {
            // arrange
            StackOnArray emptyList = new StackOnArray();
            string expectedResult = string.Empty;
            
            // act
            string actualResult = emptyList.Print();

            // assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Print_NotEmpty_ElementsSeparetedSpaces()
        {
            // arrange
            StackOnArray list = new StackOnArray();
            list.Push(3);
            list.Push(7);

            string expectedResult = "7 3 ";

            // act
            string actualResult = list.Print();

            // assert
            Assert.That (actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Pop_Empty_Exception()
        {
            StackOnArray list = new StackOnArray();

            Assert.Catch<Exception>(() => list.Pop());
        }

        [Test]
        public void Pop_NotEmpty_ElementiBezOdnogo()
        {
            StackOnArray list = new StackOnArray();
            list.Push(3);
            list.Push(2);
            list.Push(1);
            list.Pop();
            string expectedResult = "2 3 ";

            string actualResult = list.Print();

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }       
    }
}
