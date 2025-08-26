using System.Text.Json.Serialization;

namespace ConfSpeakersMaui.Models;

public class Speaker
{
    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("company")]
    public string Company { get; set; } = string.Empty;

    [JsonPropertyName("bio")]
    public string Bio { get; set; } = string.Empty;

    [JsonPropertyName("sessions")]
    public List<Session> Sessions { get; set; } = [];
}

public class Session
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("abstract")]
    public string Abstract { get; set; } = string.Empty;

    [JsonPropertyName("room")]
    public string Room { get; set; } = string.Empty;

    [JsonPropertyName("startsAt")]
    public DateTime StartsAt { get; set; }

    [JsonPropertyName("endsAt")]
    public DateTime EndsAt { get; set; }
}

public class SpeakersResponse
{
    [JsonPropertyName("speakers")]
    public List<Speaker> Speakers { get; set; } = [];

    [JsonPropertyName("count")]
    public int Count { get; set; }
}
