namespace ProceeditDictionary.services.Entries
{
    public class Entries
    {
        public string id { get; set; }
        public Metadata metadata { get; set; }
        public Result[] results { get; set; }
        public string word { get; set; }
    }

    public class Metadata
    {
        public string operation { get; set; }
        public string provider { get; set; }
        public string schema { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string language { get; set; }
        public Lexicalentry[] lexicalEntries { get; set; }
        public string type { get; set; }
        public string word { get; set; }
    }

    public class Lexicalentry
    {
        public Entry[] entries { get; set; }
        public string language { get; set; }
        public Lexicalcategory lexicalCategory { get; set; }
        public Pronunciation[] pronunciations { get; set; }
        public string text { get; set; }
    }

    public class Lexicalcategory
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Entry
    {
        public string[] etymologies { get; set; }
        public string homographNumber { get; set; }
        public Sens[] senses { get; set; }
        public Grammaticalfeature[] grammaticalFeatures { get; set; }
    }

    public class Sens
    {
        public string[] definitions { get; set; }
        public Domain[] domains { get; set; }
        public Example[] examples { get; set; }
        public string id { get; set; }
        public string[] shortDefinitions { get; set; }
        public Register1[] registers { get; set; }
        public Subsens[] subsenses { get; set; }
        public Thesauruslink[] thesaurusLinks { get; set; }
        public Region[] regions { get; set; }
    }

    public class Domain
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Example
    {
        public string text { get; set; }
        public Register[] registers { get; set; }
        public Note[] notes { get; set; }
    }

    public class Register
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Note
    {
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Register1
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Subsens
    {
        public string[] definitions { get; set; }
        public Domain1[] domains { get; set; }
        public Example1[] examples { get; set; }
        public string id { get; set; }
        public string[] shortDefinitions { get; set; }
        public Register2[] registers { get; set; }
        public Note1[] notes { get; set; }
    }

    public class Domain1
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Example1
    {
        public string text { get; set; }
    }

    public class Register2
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Note1
    {
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Thesauruslink
    {
        public string entry_id { get; set; }
        public string sense_id { get; set; }
    }

    public class Region
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Grammaticalfeature
    {
        public string id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Pronunciation
    {
        public string audioFile { get; set; }
        public string[] dialects { get; set; }
        public string phoneticNotation { get; set; }
        public string phoneticSpelling { get; set; }
    }
}
