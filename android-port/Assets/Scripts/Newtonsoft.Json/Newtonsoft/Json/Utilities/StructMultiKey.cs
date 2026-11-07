using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183680", Offset = "0x183680")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183680", Offset = "0x183680")]
	internal struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>>
	{
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x0")]
		public readonly T1 Value1;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x0")]
		public readonly T2 Value2;

		[Token(Token = "0x6000342")]
		public StructMultiKey(T1 v1, T2 v2)
		{
		}

		[Token(Token = "0x6000343")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000344")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000345")]
		public bool Equals([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C6AC", Offset = "0x18C6AC")] StructMultiKey<T1, T2> other)
		{
			return default;
		}
	}
}
