using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.Common
{
	[Serializable]
	[Token(Token = "0x200006C")]
	public class EncodingOptions
	{
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F080", Offset = "0x21F080")]
		private IDictionary<EncodeHintType, object> Hints__BackingField;

		[Token(Token = "0x1700005E")]
		public IDictionary<EncodeHintType, object> Hints
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x2EB8508", Offset = "0x2EB8508", VA = "0x2EB8508")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F330", Offset = "0x21F330")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x2EB8510", Offset = "0x2EB8510", VA = "0x2EB8510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F340", Offset = "0x21F340")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public int Height
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2EB8518", Offset = "0x2EB8518", VA = "0x2EB8518")]
			get
			{
				return default;
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x2EB8694", Offset = "0x2EB8694", VA = "0x2EB8694")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public int Width
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x2EB8794", Offset = "0x2EB8794", VA = "0x2EB8794")]
			get
			{
				return default;
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x2EB8918", Offset = "0x2EB8918", VA = "0x2EB8918")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public int Margin
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x2EB8A18", Offset = "0x2EB8A18", VA = "0x2EB8A18")]
			set
			{
			}
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2EB8B18", Offset = "0x2EB8B18", VA = "0x2EB8B18")]
		public EncodingOptions()
		{
		}
	}
}
