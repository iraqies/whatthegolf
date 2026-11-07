using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace PlayFab.Json
{
	[Token(Token = "0x20011A0")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x48184", Offset = "0x48184")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x48184", Offset = "0x48184")]
	public class JsonObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		[Token(Token = "0x4005F06")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, object> _members;

		[Token(Token = "0x170008AC")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x600505D")]
			[Address(RVA = "0x14F82B0", Offset = "0x14F82B0", VA = "0x14F82B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008AD")]
		public ICollection<object> Values
		{
			[Token(Token = "0x6005060")]
			[Address(RVA = "0x14F83D4", Offset = "0x14F83D4", VA = "0x14F83D4", Slot = "7")]
			get
			{
				return null;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170008AE")]
		[Token(Token = "0x6005061")]
		[Address(RVA = "0x14F8428", Offset = "0x14F8428", VA = "0x14F8428", Slot = "4")]
		public object get_Item(string key)
		{
			return null;
		}

		[Token(Token = "0x6005062")]
		[Address(RVA = "0x14F848C", Offset = "0x14F848C", VA = "0x14F848C", Slot = "5")]
		public void set_Item(string key, object value)
		{
		}

		[Token(Token = "0x170008AF")]
		public int Count
		{
			[Token(Token = "0x6005067")]
			[Address(RVA = "0x14F887C", Offset = "0x14F887C", VA = "0x14F887C", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170008B0")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6005068")]
			[Address(RVA = "0x14F88D0", Offset = "0x14F88D0", VA = "0x14F88D0", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600505A")]
		[Address(RVA = "0x14F8158", Offset = "0x14F8158", VA = "0x14F8158")]
		public JsonObject()
		{
		}

		[Token(Token = "0x600505B")]
		[Address(RVA = "0x14F81E0", Offset = "0x14F81E0", VA = "0x14F81E0", Slot = "9")]
		public void Add(string key, object value)
		{
		}

		[Token(Token = "0x600505C")]
		[Address(RVA = "0x14F824C", Offset = "0x14F824C", VA = "0x14F824C", Slot = "8")]
		public bool ContainsKey(string key)
		{
			return default;
		}

		[Token(Token = "0x600505E")]
		[Address(RVA = "0x14F8304", Offset = "0x14F8304", VA = "0x14F8304", Slot = "10")]
		public bool Remove(string key)
		{
			return default;
		}

		[Token(Token = "0x600505F")]
		[Address(RVA = "0x14F8368", Offset = "0x14F8368", VA = "0x14F8368", Slot = "11")]
		public bool TryGetValue(string key, out object value)
		{
			return default;
		}

		[Token(Token = "0x6005063")]
		[Address(RVA = "0x14F84F8", Offset = "0x14F84F8", VA = "0x14F84F8", Slot = "14")]
		public void Add(KeyValuePair<string, object> item)
		{
		}

		[Token(Token = "0x6005064")]
		[Address(RVA = "0x14F857C", Offset = "0x14F857C", VA = "0x14F857C", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x6005065")]
		[Address(RVA = "0x14F85D0", Offset = "0x14F85D0", VA = "0x14F85D0", Slot = "16")]
		public bool Contains(KeyValuePair<string, object> item)
		{
			return default;
		}

		[Token(Token = "0x6005066")]
		[Address(RVA = "0x14F8670", Offset = "0x14F8670", VA = "0x14F8670", Slot = "17")]
		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6005069")]
		[Address(RVA = "0x14F88D8", Offset = "0x14F88D8", VA = "0x14F88D8", Slot = "18")]
		public bool Remove(KeyValuePair<string, object> item)
		{
			return default;
		}

		[Token(Token = "0x600506A")]
		[Address(RVA = "0x14F8948", Offset = "0x14F8948", VA = "0x14F8948", Slot = "19")]
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600506B")]
		[Address(RVA = "0x14F89CC", Offset = "0x14F89CC", VA = "0x14F89CC", Slot = "20")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600506C")]
		[Address(RVA = "0x14F8A50", Offset = "0x14F8A50", VA = "0x14F8A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
