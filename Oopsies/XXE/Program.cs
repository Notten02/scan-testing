//Xml External Entity (XXE) Injection vurnarable


using XXE;

string xml = Environment.GetCommandLineArgs()[1];
XmlParser.ParseXml(xml);