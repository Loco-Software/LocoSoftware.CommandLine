namespace LocoSoftware.CommandLine.Core.Testing;

public class Tests
{
    #region Default Parameters
    [Test]
    public void TestWithNoValueDefaultParameters() {
        const String inputValue = "command -parameter";

        List<Token> tokens = Parser.Parser.Tokenize(inputValue);
        
        // Length
        Assert.That(tokens.Count, Is.EqualTo(2));
        
        // "Command"
        Assert.That(tokens[0].TokenName, Is.EqualTo("command"));
        Assert.That(tokens[0].Type, Is.EqualTo(TokenType.Command));
        Assert.Null(tokens[0].Value);
        Assert.False(tokens[0].HasValue);
        
        // "-parameter"
        Assert.That(tokens[1].TokenName, Is.EqualTo("-parameter"));
        Assert.That(tokens[1].Type, Is.EqualTo(TokenType.Argument));
        Assert.Null(tokens[1].Value);
        Assert.False(tokens[1].HasValue);
    }

    [Test]
    public void TestWithValueDefaultParameters() {
        const String inputValue = "command -parameter:Hello,World!";

        List<Token> tokens = Parser.Parser.Tokenize(inputValue);
        
        // Length
        Assert.That(tokens.Count, Is.EqualTo(2));
        
        // "Command"
        Assert.That(tokens[0].TokenName, Is.EqualTo("command"));
        Assert.That(tokens[0].Type, Is.EqualTo(TokenType.Command));
        Assert.Null(tokens[0].Value);
        Assert.False(tokens[0].HasValue);
        
        // "-parameter:Hello, World!"
        Assert.That(tokens[1].TokenName, Is.EqualTo("-parameter"));
        Assert.That(tokens[1].Type, Is.EqualTo(TokenType.Argument));
        Assert.NotNull(tokens[1].Value);
        Assert.True(tokens[1].HasValue);
        Assert.That(tokens[1].Value, Is.EqualTo("Hello,World!"));
    }
    #endregion
}