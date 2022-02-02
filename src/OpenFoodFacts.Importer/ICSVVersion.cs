namespace OpenFoodFacts.Importer
{
    public interface ICSVVersion
    {
        int HeadingCount { get; }
        string[] Headings { get; }

        bool IncludesHeaderRow { get; }
    }
}