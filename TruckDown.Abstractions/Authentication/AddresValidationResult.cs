namespace TruckDown.Client.Authentication;

public class AddresValidationResult
{
    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;

    [MemberNotNullWhen(true, nameof(Expires))]
    [MemberNotNullWhen(true, nameof(ValidationToken))]
    [JsonPropertyName("isValid")]
    public bool IsValid { get; set; }

    [JsonPropertyName("expires")]
    public DateTime? Expires { get; set; }

    [JsonPropertyName("validationToken")]
    public string? ValidationToken { get; set; }
}
