using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000D7")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x184344", Offset = "0x184344")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184344", Offset = "0x184344")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184344", Offset = "0x184344")]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IEqualityComparer<string> Comparer;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "NullableAttribute", RVA = "0x188288", Offset = "0x188288")]
		private Dictionary<string, JToken> _dictionary;

		[Token(Token = "0x17000128")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x22D1068", Offset = "0x22D1068", VA = "0x22D1068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x22CFF2C", Offset = "0x22CFF2C", VA = "0x22CFF2C")]
		public JPropertyKeyedCollection()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x22D3118", Offset = "0x22D3118", VA = "0x22D3118")]
		private void AddKey(string key, JToken item)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x22D3248", Offset = "0x22D3248", VA = "0x22D3248", Slot = "35")]
		protected override void ClearItems()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x22D0F4C", Offset = "0x22D0F4C", VA = "0x22D0F4C")]
		public bool Contains(string key)
		{
			return default;
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x22D318C", Offset = "0x22D318C", VA = "0x22D318C")]
		private void EnsureDictionary()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x22D32D0", Offset = "0x22D32D0", VA = "0x22D32D0")]
		private string GetKeyForItem(JToken item)
		{
			return null;
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x22D3354", Offset = "0x22D3354", VA = "0x22D3354", Slot = "36")]
		protected override void InsertItem(int index, JToken item)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x22D3418", Offset = "0x22D3418", VA = "0x22D3418", Slot = "37")]
		protected override void RemoveItem(int index)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x22D3554", Offset = "0x22D3554", VA = "0x22D3554")]
		private void RemoveKey(string key)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x22D35C4", Offset = "0x22D35C4", VA = "0x22D35C4", Slot = "38")]
		protected override void SetItem(int index, JToken item)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x22D04E4", Offset = "0x22D04E4", VA = "0x22D04E4")]
		public bool TryGetValue(string key, [Attribute(Name = "NullableAttribute", RVA = "0x18E0C0", Offset = "0x18E0C0")] out JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x22D00D8", Offset = "0x22D00D8", VA = "0x22D00D8")]
		public int IndexOfReference(JToken t)
		{
			return default;
		}
	}
}
