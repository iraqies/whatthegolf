using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000008")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x1824B8", Offset = "0x1824B8")]
	[Attribute(Name = "NullableAttribute", RVA = "0x1824B8", Offset = "0x1824B8")]
	public class DefaultJsonNameTable : JsonNameTable
	{
		[Token(Token = "0x2000009")]
		[Attribute(Name = "NullableAttribute", RVA = "0x1824F8", Offset = "0x1824F8")]
		private class Entry
		{
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x10")]
			internal readonly string Value;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x18")]
			internal readonly int HashCode;

			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x20")]
			internal Entry Next;

			[Token(Token = "0x600000B")]
			[Address(RVA = "0x233730C", Offset = "0x233730C", VA = "0x233730C")]
			internal Entry(string value, int hashCode, Entry next)
			{
			}
		}

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HashCodeRandomizer;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		private int _count;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		private Entry[] _entries;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		private int _mask;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x22C1770", Offset = "0x22C1770", VA = "0x22C1770")]
		static DefaultJsonNameTable()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x22B9600", Offset = "0x22B9600", VA = "0x22B9600")]
		public DefaultJsonNameTable()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x22C17C4", Offset = "0x22C17C4", VA = "0x22C17C4", Slot = "4")]
		public override string Get(char[] key, int start, int length)
		{
			return null;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x22C0834", Offset = "0x22C0834", VA = "0x22C0834")]
		public string Add(string key)
		{
			return null;
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x22C1A54", Offset = "0x22C1A54", VA = "0x22C1A54")]
		private string AddEntry(string str, int hashCode)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x22C1B78", Offset = "0x22C1B78", VA = "0x22C1B78")]
		private void Grow()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x22C1984", Offset = "0x22C1984", VA = "0x22C1984")]
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			return default;
		}
	}
}
