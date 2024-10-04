namespace InsecureDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deserializer deserializer = new Deserializer();
            deserializer.DeserializeData(new byte[] { 0x00, 0x01, 0x02 });
            deserializer.DeserializeObject(new byte[] { 0x04, 0x05, 0x06 });
        }
    }
}
