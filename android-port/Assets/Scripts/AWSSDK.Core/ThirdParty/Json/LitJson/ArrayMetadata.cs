using System;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x200001C")]
	internal struct ArrayMetadata
	{
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x8")]
		private bool is_array;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x9")]
		private bool is_list;

		[Token(Token = "0x17000042")]
		public Type ElementType
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x11CF588", Offset = "0x11CF588", VA = "0x11CF588")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x11CF660", Offset = "0x11CF660", VA = "0x11CF660")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool IsArray
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x11CF668", Offset = "0x11CF668", VA = "0x11CF668")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x11CF670", Offset = "0x11CF670", VA = "0x11CF670")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool IsList
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x11CF678", Offset = "0x11CF678", VA = "0x11CF678")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x11CF680", Offset = "0x11CF680", VA = "0x11CF680")]
			set
			{
			}
		}
	}
}
