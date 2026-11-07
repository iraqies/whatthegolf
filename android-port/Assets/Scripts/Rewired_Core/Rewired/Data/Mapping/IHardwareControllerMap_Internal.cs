using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Interfaces;

namespace Rewired.Data.Mapping
{
	[Token(Token = "0x20002B4")]
	internal interface IHardwareControllerMap_Internal
	{
		[Token(Token = "0x1700055E")]
		IEnumerable<IControllerElementIdentifierCommon_Internal> ElementIdentifiers
		{
			[Token(Token = "0x60013A9")]
			get;
		}

		[Token(Token = "0x60013AA")]
		IControllerElementIdentifierCommon_Internal GetElementIdentifier(int id);
	}
}
