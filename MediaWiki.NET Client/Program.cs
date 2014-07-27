using System;
using MediaWikiNET;
using MediaWikiNET.Enums;
using MediaWikiNET.Objects;

namespace MediaWikiNETClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create our wiki searching.
            MediaWiki wiki = new MediaWiki("wiki.garrysmod.com");
			
            // Use HTTPS instead of HTTP.
            wiki.UseTLS = false;

            //We would like 5 results.
            wiki.Limit = 5;

            //We would like to search the titles.
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

            Console.WriteLine();
            Console.WriteLine();

            // Read something so the output remains :)
            Console.ReadLine();
        }
    }
}
