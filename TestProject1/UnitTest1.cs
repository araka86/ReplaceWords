using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{

    public class UnitTest1
    {

        [Theory]
        [Trait("answer", "Your/your client")]
        [InlineData("You should begin on Monday", 
            "Your client should begin on Monday")]
        [InlineData("Hope to see u there!", 
            "Hope to see your client there!")]
        [InlineData("We have sent the deliverables to you.",
            "We have sent the deliverables to your client.")]
        [InlineData("you = so close",
            "your client = so close")]
        [InlineData("You = so close",
            "Your client = so close")]
        [InlineData("youtube",
            "youtube")]
        [InlineData("Our team is excited to finish this with you.",
            "Our team is excited to finish this with your client.")]
        [InlineData("and he wants to build a website called youwin with youuu",
            "and he wants to build a website called youwin with your client")]
        [InlineData("You. should begin on Monday",
            "Your client. should begin on Monday")]
        [InlineData("YOU. should BegiN on Monday",
            "Your client. should BegiN on Monday")]
        [InlineData("youuuuuuuuuuuuuuuuuuuu.",
            "your client.")]
        public void Test_Autocorrect_ReturnOK(string name,string expect)
        {
            //act
            var result = Challenge.Autocorrect(name);

            //assert
            result.Should().Be(expect);

            //the same
         //Assert.Equal(expect,Challenge.Autocorrect(name));
         
        }
    }
}