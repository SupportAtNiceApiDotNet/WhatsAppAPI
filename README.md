# WhatsAppAPI
Let your application send you WhatsApp messages.

This code works in connection with a [NiceAPI.net](https://niceapi.net) account.
Many languages are supported. Here an Example in C#

### Example

```cs
using System;
using System.Net;
using System.Net.Http;
using System.IO;

namespace CS_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourId = "<Your unique X-APIId>";
            string yourMobile = "<Mobile number>";
            string yourMessage = "What a great day.";

            try
            {
                string url = "https://NiceApi.net/API";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers.Add("X-APIId", yourId);
                request.Headers.Add("X-APIMobile", yourMobile);
                using (StreamWriter streamOut = new StreamWriter(request.GetRequestStream()))
                {
                    streamOut.Write(yourMessage);
                }
                using (StreamReader streamIn = new StreamReader(request.GetResponse().GetResponseStream()))
                {
                    Console.WriteLine(streamIn.ReadToEnd());
                }
            }
            catch (SystemException se)
            {
                Console.WriteLine(se.Message);
            }
            Console.ReadLine();
        }
    }
}
```

Please read more on our [Wiki page](../../wiki).
