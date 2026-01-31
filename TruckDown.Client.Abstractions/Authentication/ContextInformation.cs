namespace TruckDown.Client.Authentication;

public class ContextInformation
{
    [MemberNotNullWhen(true, nameof(Id))]
    [MemberNotNullWhen(true, nameof(AccountId))]
    [MemberNotNullWhen(true, nameof(AccountNumber))]
    [MemberNotNullWhen(true, nameof(Username))]
    [MemberNotNullWhen(true, nameof(Name))]
    [JsonPropertyName("isAuthenticated")]
    public bool IsAuthenticated { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    [JsonPropertyName("accountNumber")]
    public int? AccountNumber { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("settings")]
    public Dictionary<string, string> Settings { get; set; }
        = [];

    [JsonPropertyName("claims")]
    public string[] Claims { get; set; }
        = [];
}
