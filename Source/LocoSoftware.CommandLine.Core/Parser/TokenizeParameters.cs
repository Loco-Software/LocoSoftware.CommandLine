namespace LocoSoftware.CommandLine.Core.Parser;


/// <summary>
/// Different Options on how the Text should be transformed
/// </summary>
public enum TextCaseTransform {
    UpperCase,
    LowerCase,
    CamelCase,
    UpperCamelCase,
    KeepDefault
}

/// <summary>
/// Parameters for the Tokenization Process
/// </summary>
public struct TokenizeParameters {
    
    /// <summary>
    /// Delimiter between Command and (optional) Value <para/>
    /// Defaults to ":" <para />
    /// Space is not allowed!
    /// </summary>
    public Char NameValueDelimiter { get; set; }
    
    /// <summary>
    /// Specify if Text should be transformed <para />
    /// Defaults to TextCaseTransform.KeepDefault
    /// </summary>
    public TextCaseTransform Transform { get; set; }
    
    /// <summary>
    /// Prefix to differentiate Arguments from Commands <para/>
    /// Defaults to "-"
    /// </summary>
    public Char ArgumentPrefix { get; set; }
}