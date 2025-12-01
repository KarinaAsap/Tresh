namespace Solution
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class SolutionTest
    {
        [Test, Order(1)]
        public void _1_Example()
        {
            Assert.That(Solution.StringToArray("Robin Singh"), Is.EqualTo(new string[] { "Robin", "Singh" }));
        }
        [Test, Order(2)]
        public void _2_Example()
        {
            Assert.That(Solution.StringToArray("I love arrays they are my favorite"), Is.EqualTo(new string[] { "I", "love", "arrays", "they", "are", "my", "favorite" }));
        }
    }
}