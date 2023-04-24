using System.Text.Json;
using OpenLibrarySearchTesting.DTOs;

namespace OpenLibrarySearchTesting.DAL;

public class Books
{
    internal static string GetBooksJsonByTitle(string title)
    {
        using (var client = new RestClient("https://openlibrary.org/"))
        {
            var query = $"search.json?title={title.Replace(" ", "+")}";
            return client.HttpGet(query);
        }
    }

    internal static SearchResult GetBooksByTitle(string title)
    {
        var jsonResponse = GetBooksJsonByTitle(title);
        return JsonSerializer.Deserialize<SearchResult>(jsonResponse)!;
    }

    internal static int GetCountOfBooksWithTitle(string title)
    {
        var books = Books.GetBooksByTitle(title);
        return books.Docs.FindAll(x => x.Title.Equals(title)).Count;
    }

    public static SearchResult GetBooksPublishedSinceYear(string year)
    {
        var query = $"search.json?q=first_publish_year%3A[{year}+TO+{DateTime.Now:yyyy}]";
        using (var client = new RestClient("https://openlibrary.org/"))
        {
            var jsonResponse = client.HttpGet(query);
            return JsonSerializer.Deserialize<SearchResult>(jsonResponse)!;
        }
    }
}