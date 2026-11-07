using System;
using System.Text;
using Il2CppDummyDll;

namespace Rewired.Utils.Interfaces
{
	[Token(Token = "0x2000398")]
	internal interface IExportToJson
	{
		[Token(Token = "0x6001B9F")]
		void WriteJson(StringBuilder stringBuilder, Action<StringBuilder, object> appendValueDelegate);
	}
}
