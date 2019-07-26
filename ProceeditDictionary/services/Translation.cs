using System.Collections.Generic;

namespace ProceeditDictionary.services.Translation
{
    public class Translation
    {
        public string language { get; set; }
        public Metadata metadata { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata
    {
        public string operation { get; set; }
        public string provider { get; set; }
        public string schema { get; set; }
    }

    public class Example
    {
        public string text { get; set; }
        public List<Translation> translations { get; set; }
    }

    public class Note
    {
        public string text { get; set; }
        public string type { get; set; }
    }

    public class GrammaticalFeature
    {
        public string id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Collocation
    {
        public string id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Register
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Region
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Translation2
    {
        public List<GrammaticalFeature> grammaticalFeatures { get; set; }
        public string language { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public List<Collocation> collocations { get; set; }
        public List<Register> registers { get; set; }
        public List<Region> regions { get; set; }
    }

    public class Register2
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Region2
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Sens
    {
        public List<Example> examples { get; set; }
        public string id { get; set; }
        public List<Note> notes { get; set; }
        public List<Translation2> translations { get; set; }
        public List<Register2> registers { get; set; }
        public List<Region2> regions { get; set; }
    }

    public class GrammaticalFeature2
    {
        public string id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Entry
    {
        public List<Sens> senses { get; set; }
        public List<GrammaticalFeature2> grammaticalFeatures { get; set; }
    }

    public class LexicalCategory
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Pronunciation
    {
        public string audioFile { get; set; }
        public List<string> dialects { get; set; }
        public string phoneticNotation { get; set; }
        public string phoneticSpelling { get; set; }
    }

    public class LexicalEntry
    {
        public List<Entry> entries { get; set; }
        public string language { get; set; }
        public LexicalCategory lexicalCategory { get; set; }
        public List<Pronunciation> pronunciations { get; set; }
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
