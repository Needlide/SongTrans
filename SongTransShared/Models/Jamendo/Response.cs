namespace SongTransShared.Models.Jamendo;

public record Response(Headers Headers, List<Track> Results);