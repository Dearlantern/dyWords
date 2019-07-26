namespace ProceeditDictionary.requests
{
    class GenerateURL
    {
        public static string createURL(object[] preliminaryValues, object[] serviceValues)
        {
            string URL = "https://od-api.oxforddictionaries.com/api/v2/";
            serviceValues[0] = serviceValues[0].ToString().Substring(0, serviceValues[0].ToString().IndexOf("/"));
            switch (preliminaryValues[2])
            {
                case "Entries":
                    URL += "entries/" + serviceValues[0] + "/"
                        + preliminaryValues[0] + "?strictMatch=" + preliminaryValues[1];
                    break;
                case "Translation":
                    serviceValues[1] = serviceValues[1].ToString().Substring(0, serviceValues[1].ToString().IndexOf("/"));
                    URL += "translations/" + serviceValues[0] + "/" + serviceValues[1] + "/"
                        + preliminaryValues[0] + "?strictMatch=" + preliminaryValues[1];
                    break;
                case "Thesaurus":
                    URL += "thesaurus/" + serviceValues[0] + "/"
                       + preliminaryValues[0] + "?strictMatch=" + preliminaryValues[1];
                    break;
                case "Sentences":
                    URL += "sentences/" + serviceValues[0] + "/"
                       + preliminaryValues[0] + "?strictMatch=" + preliminaryValues[1];
                    break;
                case "LexiStats":
                    /*Under Construction*/
                    break;
                case "Utility":
                    /*Under Construction*/
                    break;
                case "Search":
                    URL += "search/" + serviceValues[0] + "?q="
                       + preliminaryValues[0];
                    break;
                case "Lemmatron":
                    URL += "lemmas/" + serviceValues[0] + "/"
                       + preliminaryValues[0];
                    break;
            }
            return URL;
        }
    }
}
