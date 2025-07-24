namespace SongTransShared.Models.Jamendo;

public record MusicInfo(
    string VocalInstrumental,
    string Lang,
    string Gender,
    string AcousticElectric,
    string Speed,
    Tags Tags);