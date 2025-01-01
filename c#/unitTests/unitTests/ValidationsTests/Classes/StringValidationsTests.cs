using ValidationsConsole.Classes;
using Xunit;

namespace ValidationsTests.Classes
{
    public class StringValidationsTests
    {
        private readonly StringValidations _validations = new StringValidations();

        [Fact]
        public void ShouldReturn6ForMatrixCharacterCount()
        {
            Assert.Equal(6, _validations.GetCharacterCount("Matrix"));
        }

        [Fact]
        public void ShouldContainSubstringSampleInText()
        {
            var text = "This is a sample text";
            Assert.True(_validations.ContainsSubstring(text, "sample"));
        }

        [Fact]
        public void ShouldNotContainSubstringTestInText()
        {
            var text = "This is a sample text";
            Assert.False(_validations.ContainsSubstring(text, "test"));
        }

        [Fact]
        public void ShouldEndWithSubstringFound()
        {
            var text = "Start, middle, and end of the text found";
            Assert.True(_validations.EndsWithSubstring(text, "found"));
        }
    }
}
