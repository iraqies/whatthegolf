using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1BBA58", Offset = "0x1BBA58")]
	public class TrackBindingTypeAttribute : Attribute
	{
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x10")]
		public readonly Type type;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x18")]
		public readonly TrackBindingFlags flags;

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2AF9A90", Offset = "0x2AF9A90", VA = "0x2AF9A90")]
		public TrackBindingTypeAttribute(Type type)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2AF9AC4", Offset = "0x2AF9AC4", VA = "0x2AF9AC4")]
		public TrackBindingTypeAttribute(Type type, TrackBindingFlags flags)
		{
		}
	}
}
