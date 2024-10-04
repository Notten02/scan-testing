using System.Net;

namespace DisableSsl
{
    internal static class Requester
    {
        public static void MakeRequest()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; }; //bad idea
            using WebClient client = new(); //also depricated...but meh
            string response = client.DownloadString("https://example.com");
            File.WriteAllText("response.txt", response);
        }
    }
}
