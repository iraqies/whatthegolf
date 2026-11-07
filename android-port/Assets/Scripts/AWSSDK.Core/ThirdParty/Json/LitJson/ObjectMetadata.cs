using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x200001D")]
	internal struct ObjectMetadata
	{
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x8")]
		private bool is_dictionary;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, PropertyMetadata> properties;

		[Token(Token = "0x17000045")]
		public Type ElementType
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x124380C", Offset = "0x124380C", VA = "0x124380C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x12438E4", Offset = "0x12438E4", VA = "0x12438E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public bool IsDictionary
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x12438EC", Offset = "0x12438EC", VA = "0x12438EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x12438F4", Offset = "0x12438F4", VA = "0x12438F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public IDictionary<string, PropertyMetadata> Properties
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x12438FC", Offset = "0x12438FC", VA = "0x12438FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1243904", Offset = "0x1243904", VA = "0x1243904")]
			set
			{
			}
		}
	}
}
