using IronPdf.Extension;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IXmlToPdfConverter converter = new XmlToPdfConverter();

converter.Convert();

Console.ReadKey();