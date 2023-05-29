namespace LocoSoftware.CommandLine.Core;

/// <summary>
/// Type of the Token
/// </summary>
public enum TokenType {
    Command,
    Argument
}

/// <summary>
/// Represents a Input Token from a Command String
/// </summary>
public struct Token
{
    /// <summary>
    /// Name of the Token<para />
    /// e. g. Command Name
    /// </summary>
    public String TokenName { get; set; }
    
    /// <summary>
    /// Determines if Command has Value
    /// </summary>
    public Boolean HasValue { get; set; }
    
    /// <summary>
    /// Value, if HasValue is True
    /// </summary>
    public String? Value { get; set; }
    
    /// <summary>
    /// Type of the Token
    /// </summary>
    public TokenType Type { get; set; }
}
