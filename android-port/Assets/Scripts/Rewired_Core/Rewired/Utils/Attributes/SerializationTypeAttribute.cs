using System;
using Il2CppDummyDll;

namespace Rewired.Utils.Attributes
{
	[Token(Token = "0x200039C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x192304", Offset = "0x192304")]
	public class SerializationTypeAttribute : Attribute
	{
		[Token(Token = "0x200039D")]
		public enum SerializationType
		{
			[Token(Token = "0x400123A")]
			Default = 0,
			[Token(Token = "0x400123B")]
			Object = 1
		}

		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0x10")]
		private SerializationType _serializationType;

		[Token(Token = "0x17000735")]
		public SerializationType serializationType
		{
			[Token(Token = "0x6001BA3")]
			[Address(RVA = "0x240DB74", Offset = "0x240DB74", VA = "0x240DB74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x240DB7C", Offset = "0x240DB7C", VA = "0x240DB7C")]
		public SerializationTypeAttribute(SerializationType P_0)
		{
		}
	}
}
