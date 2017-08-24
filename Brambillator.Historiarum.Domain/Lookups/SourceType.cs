namespace Brambillator.Historiarum.Domain.Lookups
{
    /// <summary>
    /// Indicates the type of source for a given Momentum.
    /// </summary>
    public enum SourceType : byte
    {
        Unspecified = 0,
        HistoricalFact = 1,
        Rumor = 2,
        Legend = 3,
        Fiction = 4,
        Theory = 5
    }
}
