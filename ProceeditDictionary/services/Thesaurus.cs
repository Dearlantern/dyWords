using System.Collections.Generic;

namespace ProceeditDictionary.services.Thesaurus
{
    public class Metadata
    {
        public string operation { get; set; }
        public string provider { get; set; }
        public string schema { get; set; }
    }

    public class Antonym
    {
        public string id { get; set; }
        public string language { get; set; }
        public string text { get; set; }
    }

    public class Example
    {
        public string text { get; set; }
    }

    public class Register
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Synonym
    {
        public string language { get; set; }
        public string text { get; set; }
        public string id { get; set; }
    }

    public class Register2
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Region
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Subsens
    {
        public string id { get; set; }
        public List<Synonym> synonyms { get; set; }
        public List<Register2> registers { get; set; }
        public List<Region> regions { get; set; }
    }

    public class Synonym2
    {
        public string id { get; set; }
        public string language { get; set; }
        public string text { get; set; }
    }

    public class Sens
    {
        public List<Antonym> antonyms { get; set; }
        public List<Example> examples { get; set; }
        public string id { get; set; }
        public List<Register> registers { get; set; }
        public List<Subsens> subsenses { get; set; }
        public List<Synonym2> synonyms { get; set; }
    }

    public class Entry
    {
        public List<Sens> senses { get; set; }
    }

    public class LexicalCategory
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class LexicalEntry
    {
        public List<Entry> entries { get; set; }
        public string language { get; set; }
        public LexicalCategory lexicalCategory { get; set; }
        public string text { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string language { get; set; }
        public List<LexicalEntry> lexicalEntries { get; set; }
        public string type { get; set; }
        public string word { get; set; }
    }

    public class RootObject
    {
        public string id { get; set; }
        public Metadata metadata { get; set; }
        public List<Result> results { get; set; }
        public string word { get; set; }
    }
}
