namespace SongTransShared.Models.Jamendo;

public record Headers(
    string Status,
    int Code,
    string ErrorMessage,
    string Warnings,
    int ResultsCount);