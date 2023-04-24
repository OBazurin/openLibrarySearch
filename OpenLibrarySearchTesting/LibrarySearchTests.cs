using System.Text.Json;
using OpenLibrarySearchTesting.DAL;
using OpenLibrarySearchTesting.DTOs;
using OpenLibrarySearchTesting.TestData;
using FluentAssertions;

namespace OpenLibrarySearchTesting;

public class LibrarySearchTests
{
	//Calls the API to search for any book having [Goodnight Moon] in its title, deserializes Json and
	//Prints out the total number of books with the title matching exactly [Goodnight Moon] (case sensitive)
    [Test]
    public void GetAmountOfBooksWithTitleTest()
    {
        var title = "Goodnight Moon";
        var count = Books.GetCountOfBooksWithTitle(title);
        TestContext.WriteLine($"Amount of books with {title} in titile: {count}");
    }

    //Prints out the list of [key] of books that were published since 2000
    [Test]
    public void GetBooksPublishedAfterDateTest()
    {
	    var year = "2000";
		var books = Books.GetBooksPublishedSinceYear(year);
		books.Docs.ForEach(x => TestContext.WriteLine(x.Key));
    }

	//"Calls the API to search for any book having [Goodnight Moon Base] in its title,
	//deserializes Json and Validates whether the response matches the below expected response.
	//If not matched, print out the difference
    [Test]
    public void CompareResponceForBooksWithTitleTest()
    {
        var title = "Goodnight Moon Base";
        var books = Books.GetBooksByTitle(title);
        var expected = JsonSerializer.Deserialize<SearchResult>(JsonDataProvider.ExpectedGoodnightMoonBaseResponse);

        books.Should().BeEquivalentTo(expected);
    }
}