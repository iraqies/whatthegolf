using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1BBA10", Offset = "0x1BBA10")]
	public class TrackClipTypeAttribute : Attribute
	{
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x10")]
		public readonly Type inspectedType;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool allowAutoCreate;

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2AF9B00", Offset = "0x2AF9B00", VA = "0x2AF9B00")]
		public TrackClipTypeAttribute(Type clipClass)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2AF9B34", Offset = "0x2AF9B34", VA = "0x2AF9B34")]
		public TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate)
		{
		}
	}
}
