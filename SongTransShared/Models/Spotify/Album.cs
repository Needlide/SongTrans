using SongTransShared.Enum.Spotify;

namespace SongTransShared.Models.Spotify;

public record Album(
    string AlbumType,
    int TotalTracks,
    List<string> AvailableMarkets,
    ExternalUrls ExternalUrls,
    string Href,
    string Id,
    List<Image> Images,
    string Name,
    string ReleaseDate,
    ReleaseDatePrecision ReleaseDatePrecision,
    Restrictions Restrictions,
    string Type,
    string Uri,
    List<Artist> Artists);