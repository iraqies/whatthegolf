using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos.Reflection.Internal
{
	[Token(Token = "0x20002C7")]
	internal static class UnityMemberHelper
	{
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x1326328", Offset = "0x1326328", VA = "0x1326328")]
		internal static bool TryReflectVariable(out MemberInfo variableInfo, out UnityReflectionException exception, Object reflectionTarget, string name)
		{
			return default;
		}

		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x1326494", Offset = "0x1326494", VA = "0x1326494")]
		internal static MemberInfo ReflectVariable(Object reflectionTarget, string name)
		{
			return null;
		}
	}
}
