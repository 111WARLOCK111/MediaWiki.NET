using RestSharp.Deserializers;

namespace MediaWikiNET.Objects
{
    public class SearchInfo
    {
        [DeserializeAs(Name = "totalhits")]
        public int TotalHits { get; set; }

        [DeserializeAs(Name = "suggestion")]
        public string Suggestion { get; set; }
    }
}