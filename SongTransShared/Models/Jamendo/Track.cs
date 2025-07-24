namespace SongTransShared.Models.Jamendo;

public record Track(
    string Id,
    string Name,
    int Duration,
    string ArtistId,
    string ArtistName,
    string ArtistIdstr,
    string AlbumName,
    string AlbumId,
    string LicenseCcUrl,
    int Position,
    DateTime ReleaseDate,
    string AlbumImage,
    string Audio,
    string AudioDownload,
    string ProUrl,
    string ShortUrl,
    string ShareUrl,
    Waveform Waveform,
    string Image,
    MusicInfo MusicInfo,
    bool AudioDownloadAllowed);