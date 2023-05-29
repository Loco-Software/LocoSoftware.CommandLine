namespace LocoSoftware.CommandLine.Core.Parser; 

/// <summary>
/// Command Line Parser
/// </summary>
public static partial class Parser  {

    /// <summary>
    /// Tokenizes the Input String with the specified Parameters
    /// </summary>
    /// <param name="input"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public static List<Token> Tokenize(String input, TokenizeParameters? _parameters = null) {
        // if "parameters" equals null, create with default values

        TokenizeParameters parameters = _parameters ?? new TokenizeParameters {
            NameValueDelimiter = ':',
            Transform = TextCaseTransform.KeepDefault,
            ArgumentPrefix = '-'
        };
        
        // Space is default Delimiter between Commands/Args/Parameters
        // Parser
        List<Token> tokens = input.Split(" ").Select(e => {

            Token token = new Token();
            
            List<String> _nameValue = e.Split(parameters.NameValueDelimiter).ToList();
            if (e.Contains(parameters.NameValueDelimiter) && _nameValue.Count > 1) {
                token.TokenName = _nameValue[0];
                token.Value = _nameValue[1];
                token.HasValue = true;
            }
            else {
                token.TokenName = _nameValue[0];
                token.HasValue = false;
            }

            token.Type = e.StartsWith(parameters.ArgumentPrefix) ? TokenType.Argument : TokenType.Command;

            return token;
        }).ToList();

        return tokens;
    }
    
}