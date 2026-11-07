using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000063")]
	public interface IControllerTemplate
	{
		[Token(Token = "0x1700010A")]
		string name
		{
			[Token(Token = "0x60002DB")]
			get;
		}

		[Token(Token = "0x1700010B")]
		Guid typeGuid
		{
			[Token(Token = "0x60002DC")]
			get;
		}

		[Token(Token = "0x1700010C")]
		IList<IControllerTemplateElement> elements
		{
			[Token(Token = "0x60002DD")]
			get;
		}

		[Token(Token = "0x1700010D")]
		int elementCount
		{
			[Token(Token = "0x60002DE")]
			get;
		}

		[Token(Token = "0x60002DF")]
		IControllerTemplateElement GetElement(int id);

		[Token(Token = "0x60002E0")]
		int GetElementTargets(ControllerElementTarget target, IList<ControllerTemplateElementTarget> results);
	}
}
