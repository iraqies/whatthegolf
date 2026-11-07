using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000071")]
	internal interface IControllerTemplateElement_Internal
	{
		[Token(Token = "0x6000322")]
		int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);
	}
}
