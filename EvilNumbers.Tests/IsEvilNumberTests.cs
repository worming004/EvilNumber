using System;
using Xunit;

namespace EvilNumbers.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(2, false)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, true)]
        [InlineData(7, false)]
        [InlineData(8, false)]
        [InlineData(9, true)]
        [InlineData(10, true)]
        [InlineData(11, false)]
        [InlineData(12, true)]
        [InlineData(13, false)]
        [InlineData(14, false)]
        [InlineData(15, true)]
        [InlineData(16, false)]
        [InlineData(17, true)]
        [InlineData(18, true)]
        [InlineData(19, false)]
        [InlineData(20, true)]
        [InlineData(21, false)]
        [InlineData(22, false)]
        [InlineData(23, true)]
        [InlineData(24, true)]
        [InlineData(25, false)]
        [InlineData(26, false)]
        [InlineData(27, true)]
        [InlineData(28, false)]
        [InlineData(29, true)]
        [InlineData(30, true)]
        [InlineData(250, true)]
        public void Test1(short value, bool result)
        {
            Assert.Equal(result, EvilThings.IsEvilNumberStatic(value));
        }
    }
}
