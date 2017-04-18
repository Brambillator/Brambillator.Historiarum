namespace Historiarum.Data.Lookups
{
    public enum TimeScale : byte
    {
	    DateTime = 0,       // Ticks
	    YearsBC = 1 ,       // Before Christ
	    YearsAD = 2,        // Anno Domini
        YearsBefore = 3,    // Years before a reference Momentum
        YearsAfter = 4      // Years after a reference Momentum

        // Other types could be added here like chinese or jewish calendar references
    }
}
