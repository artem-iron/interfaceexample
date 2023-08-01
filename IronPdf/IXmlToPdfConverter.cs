namespace IronPdf.Extension;

[System.ComponentModel.DesignOnly(true)]
public interface IXmlToPdfConverter
{
	public string Property { get; set; }

	void Convert();
}

