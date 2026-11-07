using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x25C44", Offset = "0x25C44")]
	public sealed class AWSPropertyAttribute : Attribute
	{
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x10")]
		private long min;

		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x18")]
		private long max;

		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x270F8", Offset = "0x270F8")]
		private bool Required__BackingField;

		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27108", Offset = "0x27108")]
		private bool IsMinSet__BackingField;

		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x22")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27118", Offset = "0x27118")]
		private bool IsMaxSet__BackingField;

		[Token(Token = "0x170002B0")]
		public bool Required
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x11C181C", Offset = "0x11C181C", VA = "0x11C181C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29FF4", Offset = "0x29FF4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x11C1824", Offset = "0x11C1824", VA = "0x11C1824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A004", Offset = "0x2A004")]
			set
			{
			}
		}

		[Token(Token = "0x170002B1")]
		public bool IsMinSet
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x11C182C", Offset = "0x11C182C", VA = "0x11C182C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A014", Offset = "0x2A014")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x11C1834", Offset = "0x11C1834", VA = "0x11C1834")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A024", Offset = "0x2A024")]
			private set
			{
			}
		}

		[Token(Token = "0x170002B2")]
		public long Min
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x11C183C", Offset = "0x11C183C", VA = "0x11C183C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x11C1858", Offset = "0x11C1858", VA = "0x11C1858")]
			set
			{
			}
		}

		[Token(Token = "0x170002B3")]
		public bool IsMaxSet
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x11C1868", Offset = "0x11C1868", VA = "0x11C1868")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A034", Offset = "0x2A034")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x11C1870", Offset = "0x11C1870", VA = "0x11C1870")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A044", Offset = "0x2A044")]
			private set
			{
			}
		}

		[Token(Token = "0x170002B4")]
		public long Max
		{
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x11C1878", Offset = "0x11C1878", VA = "0x11C1878")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x11C1894", Offset = "0x11C1894", VA = "0x11C1894")]
			set
			{
			}
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x11C18A4", Offset = "0x11C18A4", VA = "0x11C18A4")]
		public AWSPropertyAttribute()
		{
		}
	}
}
