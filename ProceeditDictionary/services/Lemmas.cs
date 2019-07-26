using System.Collections.Generic;

namespace ProceeditDictionary.services.Lemmas
{
    public class Metadata
    {
        public string provider { get; set; }
    }

    public class InflectionOf
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class LexicalCategory
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class GrammaticalFeature
    {
        public string id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class LexicalEntry
    {
        public List<InflectionOf> inflectionOf { get; set; }
        public string language { get; set; }
        public LexicalCategory lexicalCategory { get; set; }
        public string text { get; set; }
        public List<GrammaticalFeature> grammaticalFeatures { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string language { get; set; }
        public List<LexicalEntry> lexicalEntries { get; set; }
        public string word { get; set; }
    }

    public class RootObject
    {
        public Metadata metadata { get; set; }
        public List<Result> results { get; set; }
    }
}
