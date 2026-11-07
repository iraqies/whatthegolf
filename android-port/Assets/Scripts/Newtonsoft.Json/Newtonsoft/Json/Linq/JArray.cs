using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000CB")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184004", Offset = "0x184004")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x184004", Offset = "0x184004")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184004", Offset = "0x184004")]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<JToken> _values;

		[Token(Token = "0x170000F7")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x22CA2DC", Offset = "0x22CA2DC", VA = "0x22CA2DC", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F8")]
		public override JTokenType Type
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x22CA2E4", Offset = "0x22CA2E4", VA = "0x22CA2E4", Slot = "12")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170000F9")]
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x22CB084", Offset = "0x22CB084", VA = "0x22CB084", Slot = "19")]
		public JToken get_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x22CB094", Offset = "0x22CB094", VA = "0x22CB094", Slot = "20")]
		public void set_Item(int index, JToken value)
		{
		}

		[Token(Token = "0x170000FA")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x22CB20C", Offset = "0x22CB20C", VA = "0x22CB20C", Slot = "25")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x22CA2EC", Offset = "0x22CA2EC", VA = "0x22CA2EC")]
		public JArray()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x22CA428", Offset = "0x22CA428", VA = "0x22CA428")]
		public JArray(JArray other)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x22CA858", Offset = "0x22CA858", VA = "0x22CA858")]
		public JArray(object content)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x22CA93C", Offset = "0x22CA93C", VA = "0x22CA93C", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x22CAA00", Offset = "0x22CAA00", VA = "0x22CAA00")]
		public static JArray Load(JsonReader reader, [Attribute(Name = "NullableAttribute", RVA = "0x18DCE0", Offset = "0x18DCE0")] JsonLoadSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x22CAFA8", Offset = "0x22CAFA8", VA = "0x22CAFA8", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x22CB0A4", Offset = "0x22CB0A4", VA = "0x22CB0A4", Slot = "69")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18A4E4", Offset = "0x18A4E4")]
		internal override int IndexOfItem(JToken item)
		{
			return default;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x22CB118", Offset = "0x22CB118", VA = "0x22CB118", Slot = "21")]
		public int IndexOf(JToken item)
		{
			return default;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x22CB128", Offset = "0x22CB128", VA = "0x22CB128", Slot = "22")]
		public void Insert(int index, JToken item)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x22CB13C", Offset = "0x22CB13C", VA = "0x22CB13C", Slot = "23")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x22CB14C", Offset = "0x22CB14C", VA = "0x22CB14C", Slot = "4")]
		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x22CB1CC", Offset = "0x22CB1CC", VA = "0x22CB1CC", Slot = "26")]
		public void Add(JToken item)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x22CB1DC", Offset = "0x22CB1DC", VA = "0x22CB1DC", Slot = "27")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x22CB1EC", Offset = "0x22CB1EC", VA = "0x22CB1EC", Slot = "28")]
		public bool Contains(JToken item)
		{
			return default;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x22CB1FC", Offset = "0x22CB1FC", VA = "0x22CB1FC", Slot = "29")]
		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x22CB214", Offset = "0x22CB214", VA = "0x22CB214", Slot = "30")]
		public bool Remove(JToken item)
		{
			return default;
		}
	}
}
