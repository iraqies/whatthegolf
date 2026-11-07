using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184304", Offset = "0x184304")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184304", Offset = "0x184304")]
	public class JPropertyDescriptor : PropertyDescriptor
	{
		[Token(Token = "0x17000124")]
		public override Type ComponentType
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x22D2FF8", Offset = "0x22D2FF8", VA = "0x22D2FF8", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000125")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x22D3080", Offset = "0x22D3080", VA = "0x22D3080", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000126")]
		public override Type PropertyType
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x22D3088", Offset = "0x22D3088", VA = "0x22D3088", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		protected override int NameHashCode
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x22D3110", Offset = "0x22D3110", VA = "0x22D3110", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x22D1F1C", Offset = "0x22D1F1C", VA = "0x22D1F1C")]
		public JPropertyDescriptor(string name)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x22D2D38", Offset = "0x22D2D38", VA = "0x22D2D38", Slot = "23")]
		public override bool CanResetValue(object component)
		{
			return default;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x22D2D40", Offset = "0x22D2D40", VA = "0x22D2D40", Slot = "26")]
		public override object GetValue(object component)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x22D2E48", Offset = "0x22D2E48", VA = "0x22D2E48", Slot = "29")]
		public override void ResetValue(object component)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x22D2E4C", Offset = "0x22D2E4C", VA = "0x22D2E4C", Slot = "30")]
		public override void SetValue(object component, object value)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x22D2FF0", Offset = "0x22D2FF0", VA = "0x22D2FF0", Slot = "31")]
		public override bool ShouldSerializeValue(object component)
		{
			return default;
		}
	}
}
