using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x18410C", Offset = "0x18410C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18410C", Offset = "0x18410C")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18410C", Offset = "0x18410C")]
	public struct JEnumerable<T> : IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> where T : JToken
	{
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188054", Offset = "0x188054")]
		public static readonly JEnumerable<T> Empty;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x0")]
		private readonly IEnumerable<T> _enumerable;

		[Token(Token = "0x6000620")]
		public JEnumerable(IEnumerable<T> enumerable)
		{
		}

		[Token(Token = "0x6000621")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		public bool Equals([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DDC8", Offset = "0x18DDC8")] JEnumerable<T> other)
		{
			return default;
		}

		[Token(Token = "0x6000624")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000625")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
