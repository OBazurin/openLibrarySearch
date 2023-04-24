using System.Text.Json.Serialization;

namespace OpenLibrarySearchTesting.DTOs;

public class SearchResult
{
    [JsonPropertyName("numFound")] public int NumFound { get; set; }

    [JsonPropertyName("start")] public int Start { get; set; }

    [JsonPropertyName("numFoundExact")] public bool NumFoundExact { get; set; }

    [JsonPropertyName("docs")] public List<Document> Docs { get; set; }

    [JsonPropertyName("offset")] public object Offset { get; set; }
}