using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x2000019")]
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

		[Token(Token = "0x1700003E")]
		public object Current
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1244F90", Offset = "0x1244F90", VA = "0x1244F90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public DictionaryEntry Entry
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1245000", Offset = "0x1245000", VA = "0x1245000", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000040")]
		public object Key
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x12450FC", Offset = "0x12450FC", VA = "0x12450FC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public object Value
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x12451BC", Offset = "0x12451BC", VA = "0x12451BC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1245284", Offset = "0x1245284", VA = "0x1245284")]
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x12452B0", Offset = "0x12452B0", VA = "0x12452B0", Slot = "7")]
		public bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1245364", Offset = "0x1245364", VA = "0x1245364", Slot = "9")]
		public void Reset()
		{
		}
	}
}
