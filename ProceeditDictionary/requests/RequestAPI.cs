using Newtonsoft.Json;
using ProceeditDictionary.services.Entries;
using ProceeditDictionary.services.Translation;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace ProceeditDictionary.requests
{
    class RequestAPI
    {
        public static void GetJson(object[] preliminaryValues, object[] serviceValues)
        {
            string app_id = "f470fc73";
            string app_key = "98290224670ee09a7789a2af4dd3a2a9";
            string URL = GenerateURL.createURL(preliminaryValues, serviceValues);
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.ContentType = "application/json; charset=utf-8";
            request.Method = "GET";
            request.Headers["app_id"] = app_id;
            request.Headers["app_key"] = app_key;
            request.PreAuthenticate = true;

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                var newJson = reader.ReadToEnd();
                switch (preliminaryValues[2])
                {
                    case "Entries":
                        Entries entries;
                        entries = JsonConvert.DeserializeObject<Entries>(newJson);
                        break;
                    case "Translation":
                        Translation translation;
                        translation = JsonConvert.DeserializeObject<Translation>(newJson);
                        break;
                    case "Thesaurus":
                        break;
                        //...
                }
                //Console.WriteLine(entries.id);
            }

        }
    }
}
