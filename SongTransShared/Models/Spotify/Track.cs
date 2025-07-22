namespace SongTransShared.Models.Spotify;

public record Track(
    Album Album,
    List<Artist> Artists,
    List<string> AvailableMarkets,
    int DiscNumber,
    int DurationMs,
    bool Explicit,
    ExternalIds ExternalIds,
    ExternalUrls ExternalUrls,
    string Href,
    string Id,
    bool IsPlayable,
    LinkedFrom LinkedFrom,
    Restrictions Restrictions,
    string Name,
    ushort Popularity,
    string PreviewUrl,
    int TrackNumber,
    string Type,
    string Uri,
    bool IsLocal);