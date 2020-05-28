using System;
using System.Xml;

namespace Exercise_3_1
{
    public class ReadXmlFile
    {
        public void ReadXmlF()
        {
            XmlTextReader xmlReader = new XmlTextReader("..\\Exercise 3-1\\File.xml");
            Console.WriteLine("Read XML File and return the price based on the name");
            while (xmlReader.Read()) 
            {
                switch(xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (xmlReader.Name == "name" || xmlReader.Name == "price")
                        {
                            Console.WriteLine(xmlReader.ReadString().ToString());
                        }    
                    break; 
                }
            }
        }
    }
}