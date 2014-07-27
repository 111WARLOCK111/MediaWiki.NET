# MediaWiki.NET - An implementation of the full text search API of Media Wiki's search api.

This project is forked from Wikipedia.NET (https://github.com/Genbox/Wikipedia.NET).

### Features

* Based on RestSharp (http://restsharp.org) to deserialize the Media Wiki XML into objects.
* Full support for all search parameters.
* Works with the latest Media Wiki's api.

### Examples

Here is the simplest form of getting data from Minecraft Wiki:

```csharp
static void Main(string[] args)
{
    // Create our wiki searching.
    MediaWiki wiki = new MediaWiki("wiki.garrysmod.com");
		
    // Use HTTPS instead of HTTP.
    wiki.UseTLS = false;

    // We would like 5 results.
    wiki.Limit = 5;

    // We would like to search the titles.
    wiki.What = What.Title;
			
	// Print the user that We're gonna start :)
    Console.WriteLine("Please enter a valid text to search at " + wiki.Wiki);
			
    // Read our searching text.
    string searchText = Console.ReadLine();

    // Start the searching
    QueryResult results = wiki.Search(searchText);

    Console.WriteLine("Searching for {0}:{1}", searchText, Environment.NewLine);
    Console.WriteLine("Found " + results.Search.Count + " results!");

    foreach (Search s in results.Search)
    {
        Console.WriteLine(s.Title);
    }
	
    // Read something so the output remains :)
    Console.ReadLine();
}
```

Output:
```
Please enter a valid text to search at wiki.garrysmod.com
Angle
Searching for Angle:

Found 5 results!
Global/Angle
umsg/Angle
Angle/Forward
Angle/IsZero
Angle/Normalize
```

For more examples, take a look at the MediaWiki.NET Client included in the project.
