namespace SongTransShared.Models.Spotify;

public record LinkedFrom(
    ExternalUrls ExternalUrls,
    string Href,
    string Id,
    string Type,
    string Uri);