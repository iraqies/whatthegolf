using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1BBA6C", Offset = "0x1BBA6C")]
	internal class SupportsChildTracksAttribute : Attribute
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Type childType;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly int levels;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2AEAFC0", Offset = "0x2AEAFC0", VA = "0x2AEAFC0")]
		public SupportsChildTracksAttribute([Optional] Type childType, int levels = int.MaxValue)
		{
		}
	}
}
