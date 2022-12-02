using Lab13Main;

namespace TestProject;
public class Tests
{
     [Test]
    public void SplitUpWords()
    {
        var actualWords = Dictionary.BreakUpLine("there are three words");
        var expectedWords = new[]{"there", "are", "three", "words"};

        checkArraysAreSame(actualWords, expectedWords);
    }

    private void checkArraysAreSame(string[] actual, string[] expected)
    {
        Assert.AreEqual(expected.Length, actual.Length);
        for(int i = 0; i < Math.Min(actual.Length, expected.Length); i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }

    [Test]
    public void HandlePunctuation()
    {
        var actualWords = Dictionary.BreakUpLine("test this.  really-please: (do) that!, won't you?!");
        var expectedWords = new[]{"test", "this", "really", "please", "do", "that", "won't", "you"};

        checkArraysAreSame(actualWords, expectedWords);
    }
}