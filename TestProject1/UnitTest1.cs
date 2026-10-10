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
    }
}
