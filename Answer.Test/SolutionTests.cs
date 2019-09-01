using NUnit.Framework;
using Answer;

namespace Tests
{
    public class SolutionTests
    {
        [Test]
        public void GetSum(
            [Random(int.MinValue, int.MaxValue, 100)]int a,
            [Random(int.MinValue, int.MaxValue, 100)]int b)
        {
            int expectedResult = a + b;

            var sut = new Solution();

            int result = sut.GetSum(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}