namespace EasyMicroservices.Domain.Contracts.Common;
/// <summary>
/// language contract
/// </summary>
public class LanguageContract
{
    /// <summary>
    /// Language short name like : fa-IR, en-US
    /// </summary>
    public string ShortName { get; set; }
    /// <summary>
    /// value of language
    /// </summary>
    public string Value { get; set; }
}
