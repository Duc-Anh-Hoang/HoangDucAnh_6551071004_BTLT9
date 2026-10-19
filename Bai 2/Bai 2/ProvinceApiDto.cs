using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Bai_2;

public class ProvinceDto
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("wards")]
    public List<WardDto>? Wards { get; set; }

    public override string ToString() => Name;
}

public class WardDto
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    public override string ToString() => Name;
}
