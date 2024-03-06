using Xunit;

public class Program
{
public static void Main(string[] args)
    {}
}
namespace MyUtilities {

 
    public class Tests
    {
        [Fact]
        public void TestToUpper()
        {
            Assert.Equal("A",StringUtils.ToUpper("a"));
        }

        [Fact]
        public void TestToLower()
        {
            Assert.Equal("a",StringUtils.ToLower("A"));
        }

        [Fact]
        public void TestLength()
        {
            Assert.Equal(4,StringUtils.length("five"));
        }
        
        [Fact]
        public void TestReverse()
        {
            Assert.Equal("evif",StringUtils.Reverse("five"));
        }

        [Fact]
        public void TestCountVowels()
        {
            Assert.Equal(2,StringUtils.CountVowels("five"));
        }

        [Fact]
        public void TestCountConsonants()
        {
            Assert.Equal(2,StringUtils.CountConsonants("five"));
        }

        [Fact]
        public void TestHasLetter()
        {
            
            Assert.True(StringUtils.HasLetter("five", 'e' ));
        }

        [Fact]
        public void TestToCharArray()
        {
            char[] array = {'f','i','v','e'};
            Assert.Equal(array,StringUtils.ToCharArray("five"));
        }

        [Fact]
        public void TestTrim()
        {
            Assert.Equal("five",StringUtils.Trim("five      "));
        }

        [Fact]
        public void TestAppend()
        {
            Assert.Equal("not five",StringUtils.append("not ", "five"));
        }

        [Fact]
        public void TestGetCharNum()
        {
            Assert.Equal(6,StringUtils.GetCharNum('f'));
        }

        [Fact]
        public void TestGetNumChar()
        {
            Assert.Equal('f',StringUtils.GetNumChar(6));
        }

        [Fact]
        public void TestEncode()
        {
            int[] array = {21,24,37,20};
            Assert.Equal(array,StringUtils.Encode("five"));
        }

        [Fact]
        public void TestDecode()
        {
            int[] array = {21,24,37,20};
            Assert.Equal("five",StringUtils.Decode(array));
        }


    }
}