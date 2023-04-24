using System.Text.Json.Serialization;

namespace OpenLibrarySearchTesting.DTOs;

public class Document
{
    [JsonPropertyName("key")] public string Key { get; set; }

    [JsonPropertyName("type")] public string Type { get; set; }

    [JsonPropertyName("seed")] public List<string> Seed { get; set; }

    [JsonPropertyName("title")] public string Title { get; set; }

    [JsonPropertyName("title_suggest")] public string TitleSuggest { get; set; }

    [JsonPropertyName("title_sort")] public string TitleSort { get; set; }

    [JsonPropertyName("edition_count")] public int EditionCount { get; set; }

    [JsonPropertyName("edition_key")] public List<string> EditionKey { get; set; }

    [JsonPropertyName("publish_date")] public List<string> PublishDate { get; set; }

    [JsonPropertyName("publish_year")] public List<int> PublishYear { get; set; }

    [JsonPropertyName("first_publish_year")]
    public int FirstPublishYear { get; set; }

    [JsonPropertyName("number_of_pages_median")]
    public int NumberOfPagesMedian { get; set; }

    [JsonPropertyName("lccn")] public List<string> Lccn { get; set; }

    [JsonPropertyName("publish_place")] public List<string> PublishPlace { get; set; }

    [JsonPropertyName("oclc")] public List<string> Oclc { get; set; }

    [JsonPropertyName("contributor")] public List<string> Contributor { get; set; }

    [JsonPropertyName("lcc")] public List<string> Lcc { get; set; }

    [JsonPropertyName("ddc")] public List<string> Ddc { get; set; }

    [JsonPropertyName("isbn")] public List<string> Isbn { get; set; }

    [JsonPropertyName("last_modified_i")] public int LastModifiedI { get; set; }

    [JsonPropertyName("ebook_count_i")] public int EbookCountI { get; set; }

    [JsonPropertyName("ebook_access")] public string EbookAccess { get; set; }

    [JsonPropertyName("has_fulltext")] public bool HasFulltext { get; set; }

    [JsonPropertyName("public_scan_b")] public bool PublicScanB { get; set; }

    [JsonPropertyName("ia")] public List<string> Ia { get; set; }

    [JsonPropertyName("ia_collection")] public List<string> IaCollection { get; set; }

    [JsonPropertyName("ia_collection_s")] public string IaCollectionS { get; set; }

    [JsonPropertyName("lending_edition_s")]
    public string LendingEditionS { get; set; }

    [JsonPropertyName("lending_identifier_s")]
    public string LendingIdentifierS { get; set; }

    [JsonPropertyName("printdisabled_s")] public string PrintdisabledS { get; set; }

    [JsonPropertyName("ratings_average")] public double RatingsAverage { get; set; }

    [JsonPropertyName("ratings_sortable")] public double RatingsSortable { get; set; }

    [JsonPropertyName("ratings_count")] public int RatingsCount { get; set; }

    [JsonPropertyName("ratings_count_1")] public int RatingsCount1 { get; set; }

    [JsonPropertyName("ratings_count_2")] public int RatingsCount2 { get; set; }

    [JsonPropertyName("ratings_count_3")] public int RatingsCount3 { get; set; }

    [JsonPropertyName("ratings_count_4")] public int RatingsCount4 { get; set; }

    [JsonPropertyName("ratings_count_5")] public int RatingsCount5 { get; set; }

    [JsonPropertyName("readinglog_count")] public int ReadinglogCount { get; set; }

    [JsonPropertyName("want_to_read_count")]
    public int WantToReadCount { get; set; }

    [JsonPropertyName("currently_reading_count")]
    public int CurrentlyReadingCount { get; set; }

    [JsonPropertyName("already_read_count")]
    public int AlreadyReadCount { get; set; }

    [JsonPropertyName("cover_edition_key")]
    public string CoverEditionKey { get; set; }

    [JsonPropertyName("cover_i")] public int CoverI { get; set; }

    [JsonPropertyName("first_sentence")] public List<string> FirstSentence { get; set; }

    [JsonPropertyName("publisher")] public List<string> Publisher { get; set; }

    [JsonPropertyName("language")] public List<string> Language { get; set; }

    [JsonPropertyName("author_key")] public List<string> AuthorKey { get; set; }

    [JsonPropertyName("author_name")] public List<string> AuthorName { get; set; }

    [JsonPropertyName("author_alternative_name")]
    public List<string> AuthorAlternativeName { get; set; }

    [JsonPropertyName("place")] public List<string> Place { get; set; }

    [JsonPropertyName("subject")] public List<string> Subject { get; set; }

    [JsonPropertyName("id_amazon")] public List<string> IdAmazon { get; set; }

    [JsonPropertyName("id_goodreads")] public List<string> IdGoodreads { get; set; }

    [JsonPropertyName("id_librarything")] public List<string> IdLibrarything { get; set; }

    [JsonPropertyName("ia_loaded_id")] public List<string> IaLoadedId { get; set; }

    [JsonPropertyName("ia_box_id")] public List<string> IaBoxId { get; set; }

    [JsonPropertyName("publisher_facet")] public List<string> PublisherFacet { get; set; }

    [JsonPropertyName("place_key")] public List<string> PlaceKey { get; set; }

    [JsonPropertyName("subject_facet")] public List<string> SubjectFacet { get; set; }

    [JsonPropertyName("_version_")] public object Version { get; set; }

    [JsonPropertyName("place_facet")] public List<string> PlaceFacet { get; set; }

    [JsonPropertyName("lcc_sort")] public string LccSort { get; set; }

    [JsonPropertyName("author_facet")] public List<string> AuthorFacet { get; set; }

    [JsonPropertyName("subject_key")] public List<string> SubjectKey { get; set; }

    [JsonPropertyName("ddc_sort")] public string DdcSort { get; set; }

    [JsonPropertyName("subtitle")] public string Subtitle { get; set; }

    [JsonPropertyName("id_better_world_books")]
    public List<string> IdBetterWorldBooks { get; set; }
}