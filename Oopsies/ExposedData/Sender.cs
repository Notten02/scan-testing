namespace ExposedData
{
    internal static class Sender
    {
        public static void SendSensitiveData(string data)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://example.com");
                var content = new StringContent(data);
                client.PostAsync("/api/sensitive", content);
            }
        }
    }
}