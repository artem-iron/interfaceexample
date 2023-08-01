using System;

namespace IronPdf.Extension
{
    public class XmlToPdfConverter : IXmlToPdfConverter
    {
        private string _field = "test";

        public string Property { get => _field; set => _field = value; }

        public void Convert()
        {
            Console.WriteLine("Converted");
        }
    }
}

