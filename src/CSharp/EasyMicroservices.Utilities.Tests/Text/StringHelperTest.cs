using System.Text;
using Xunit;

namespace EasyMicroservices.Utilities.Tests.Text
{
    public class StringHelperTest
    {
        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(3, "3")]
        [InlineData(4, "4")]
        [InlineData(5, "5")]
        [InlineData(6, "6")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "9")]
        [InlineData(10, "a")]
        [InlineData(11, "b")]
        [InlineData(12, "c")]
        [InlineData(13, "d")]
        [InlineData(14, "e")]
        [InlineData(15, "f")]
        [InlineData(16, "g")]
        [InlineData(17, "h")]
        [InlineData(18, "i")]
        [InlineData(19, "j")]
        [InlineData(20, "k")]
        [InlineData(21, "l")]
        [InlineData(22, "m")]
        [InlineData(23, "n")]
        [InlineData(24, "o")]
        [InlineData(25, "p")]
        [InlineData(26, "q")]
        [InlineData(27, "r")]
        [InlineData(28, "s")]
        [InlineData(29, "t")]
        [InlineData(30, "u")]
        [InlineData(31, "v")]
        [InlineData(32, "w")]
        [InlineData(33, "x")]
        [InlineData(34, "y")]
        [InlineData(35, "z")]
        [InlineData(36, "A")]
        [InlineData(37, "B")]
        [InlineData(38, "C")]
        [InlineData(39, "D")]
        [InlineData(40, "E")]
        [InlineData(41, "F")]
        [InlineData(42, "G")]
        [InlineData(43, "H")]
        [InlineData(44, "I")]
        [InlineData(45, "J")]
        [InlineData(46, "K")]
        [InlineData(47, "L")]
        [InlineData(48, "M")]
        [InlineData(49, "N")]
        [InlineData(50, "O")]
        [InlineData(51, "P")]
        [InlineData(52, "Q")]
        [InlineData(53, "R")]
        [InlineData(54, "S")]
        [InlineData(55, "T")]
        [InlineData(56, "U")]
        [InlineData(57, "V")]
        [InlineData(58, "W")]
        [InlineData(59, "X")]
        [InlineData(60, "Y")]
        [InlineData(61, "Z")]
        [InlineData(62, "10")]
        public void TestHash(long input, string expect)
        {
            var encoded = StringHelper.EncodeByKey(input);
            Assert.Equal(encoded, expect);
            Assert.Equal(StringHelper.DecodeByKey(encoded), input);
        }

        [Theory]
        [InlineData("", true)]
        [InlineData(null, true)]
        [InlineData(" ", false)]
        [InlineData("a", false)]
        public void IsNullOrEmpty(string value, bool expect)
        {
            Assert.Equal(value.IsNullOrEmpty(), expect);
        }

        [Theory]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData(" ", true)]
        [InlineData("a", true)]
        public void HasValue(string value, bool expect)
        {
            Assert.Equal(value.HasValue(), expect);
        }
    }
}
