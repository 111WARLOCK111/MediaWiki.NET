# MediaWiki.NET - An implementation of the full text search API of Media Wiki's search api.

This project is forked from Wikipedia.NET (https://github.com/Genbox/Wikipedia.NET).

### Features

* Based on RestSharp (http://restsharp.org) to deserialize the Media Wiki XML into objects
* Full support for all search parameters

### Examples

Here is the simplest form of getting data from Minecraft Wiki:

```csharp
static void Main(string[] args)
{
	MediaWiki wiki = new MediaWiki("URL TO BE ADDED AFTER TESTING");
	wiki.Limit = 5;
	
	QueryResult results = wiki.Search("Crafting Table");

	Console.WriteLine("Found " + results.Search.Count + " results!");

	foreach (Search s in results.Search)
	{
		Console.WriteLine(s.Url);
	}
}
```

Output:
```
~ TO BE ADDED.
```

For more examples, take a look at the MediaWiki.NET Client included in the project.
