using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000CC")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x184068", Offset = "0x184068")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184068", Offset = "0x184068")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184068", Offset = "0x184068")]
	public class JConstructor : JContainer
	{
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "NullableAttribute", RVA = "0x187FF0", Offset = "0x187FF0")]
		private string _name;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<JToken> _values;

		[Token(Token = "0x170000FB")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x22CB224", Offset = "0x22CB224", VA = "0x22CB224", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F700", Offset = "0x18F700")]
		public string Name
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x22CB2A0", Offset = "0x22CB2A0", VA = "0x22CB2A0")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18A50C", Offset = "0x18A50C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		public override JTokenType Type
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x22CB2A8", Offset = "0x22CB2A8", VA = "0x22CB2A8", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x22CB22C", Offset = "0x22CB22C", VA = "0x22CB22C", Slot = "69")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18A4F8", Offset = "0x18A4F8")]
		internal override int IndexOfItem(JToken item)
		{
			return default;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x22CB2B0", Offset = "0x22CB2B0", VA = "0x22CB2B0")]
		public JConstructor(JConstructor other)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x22CB350", Offset = "0x22CB350", VA = "0x22CB350")]
		public JConstructor(string name)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x22CB4C0", Offset = "0x22CB4C0", VA = "0x22CB4C0", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x22CB524", Offset = "0x22CB524", VA = "0x22CB524", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x22CB614", Offset = "0x22CB614", VA = "0x22CB614")]
		public static JConstructor Load(JsonReader reader, [Attribute(Name = "NullableAttribute", RVA = "0x18DD14", Offset = "0x18DD14")] JsonLoadSettings settings)
		{
			return null;
		}
	}
}
