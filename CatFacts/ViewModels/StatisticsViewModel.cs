namespace CatFacts.ViewModels;

public class StatisticsViewModel
{
    public int TotalFacts { get; set; }

    public int AverageLength { get; set; }

    public int ShortestLength { get; set; }

    public string ShortestFact { get; set; } = string.Empty;

    public int LongestLength { get; set; }

    public string LongestFact { get; set; } = string.Empty;

    public List<LengthBucketViewModel> Distribution { get; set; } = new();
}

public class LengthBucketViewModel
{
    public string Label { get; set; } = string.Empty;

    public int Count { get; set; }
}