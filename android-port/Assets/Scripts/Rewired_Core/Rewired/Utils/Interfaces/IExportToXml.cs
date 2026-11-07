using System.Xml;

namespace Rewired.Utils.Interfaces
{
	internal interface IExportToXml
	{
		bool writesOwnElementTag { get; }

		void WriteXml(XmlWriter writer);
	}
}
