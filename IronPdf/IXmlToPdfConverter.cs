namespace IronPdf.Extension;

/// <summary>
/// Install IronPdf.Extension nuget package to get the implementation of this
/// interface
/// </summary>
public interface IXmlToPdfConverter
{
	public string Property { get; set; }

	void Convert();
}

