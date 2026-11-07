using System.Xml;
using Il2CppDummyDll;

namespace Rewired.Utils.Interfaces
{
	[Token(Token = "0x2000397")]
	internal interface IExportToXml
	{
		[Token(Token = "0x17000734")]
		bool writesOwnElementTag
		{
			[Token(Token = "0x6001B9D")]
			get;
		}

		[Token(Token = "0x6001B9E")]
		void WriteXml(XmlWriter writer);
	}
}
