using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Core
{
	[Token(Token = "0x2000010")]
	public class AnimationCurveScriptableObj : ScriptableObject
	{
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve value;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x29F79B0", Offset = "0x29F79B0", VA = "0x29F79B0")]
		public AnimationCurveScriptableObj()
		{
		}
	}
}
