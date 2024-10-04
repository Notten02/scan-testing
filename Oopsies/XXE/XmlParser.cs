using System.Xml;

namespace XXE
{
    internal static class XmlParser
    {
        public static void ParseXml(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            // do xml stuff here
        }
    }
}
