using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace InsecureDeserialization
{
    internal class Deserializer
    {
        public object DeserializeData(byte[] data)
        {
            //modern versions of dotnet ban this, but net472 does still exist. Slapping mistery binary into executable memory is a bad idea
            using (MemoryStream ms = new MemoryStream(data))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(ms);
            }
        }
    }
}
