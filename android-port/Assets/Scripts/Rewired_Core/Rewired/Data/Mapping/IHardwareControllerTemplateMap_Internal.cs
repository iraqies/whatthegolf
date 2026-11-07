using System;
using Il2CppDummyDll;
using Rewired.Interfaces;

namespace Rewired.Data.Mapping
{
	[Token(Token = "0x20002B5")]
	internal interface IHardwareControllerTemplateMap_Internal
	{
		[Token(Token = "0x1700055F")]
		string name
		{
			[Token(Token = "0x60013AB")]
			get;
		}

		[Token(Token = "0x17000560")]
		Guid typeGuid
		{
			[Token(Token = "0x60013AC")]
			get;
		}

		[Token(Token = "0x60013AD")]
		int GetElementIdentifierCount();

		[Token(Token = "0x60013AE")]
		IControllerTemplateElementIdentifier GetTemplateElementIdentifier(int index);

		[Token(Token = "0x60013AF")]
		IControllerTemplateElementIdentifier GetTemplateElementIdentifierById(int elementIdentifierId);

		[Token(Token = "0x60013B0")]
		IControllerTemplateMapSpecialElement_Internal GetSpecialTemplateElementByElementIdentifierId(int id);

		[Token(Token = "0x60013B1")]
		HxKJTjnYRTlXmgqyhXzejFNHdCai GetAxisTarget(Controller controller, int elementIdentifierId);

		[Token(Token = "0x60013B2")]
		HxKJTjnYRTlXmgqyhXzejFNHdCai GetButtonTarget(Controller controller, int elementIdentifierId);
	}
}
