using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200003B")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x182BF0", Offset = "0x182BF0")]
	[Attribute(Name = "NullableAttribute", RVA = "0x182BF0", Offset = "0x182BF0")]
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _duplicateFirstErrorMessage;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _duplicateSecondErrorMessage;

		[Token(Token = "0x60001C2")]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
		}

		[Token(Token = "0x60001C3")]
		public void Set(TFirst first, TSecond second)
		{
		}

		[Token(Token = "0x60001C4")]
		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			return default;
		}

		[Token(Token = "0x60001C5")]
		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			return default;
		}
	}
}
