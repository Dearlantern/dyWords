using System.Collections.Generic;

namespace ProceeditDictionary.services.Search
{
    public class Metadata
    {
        public string limit { get; set; }
        public string offset { get; set; }
        public string operation { get; set; }
        public string provider { get; set; }
        public string schema { get; set; }
        public string sourceLanguage { get; set; }
        public string total { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string inflection_id { get; set; }
        public string label { get; set; }
        public string matchString { get; set; }
        public string matchType { get; set; }
        public string region { get; set; }
        public double score { get; set; }
        public string word { get; set; }
    }

    public class RootObject
    {
        public Metadata metadata { get; set; }
        public List<Result> results { get; set; }
    }
}
