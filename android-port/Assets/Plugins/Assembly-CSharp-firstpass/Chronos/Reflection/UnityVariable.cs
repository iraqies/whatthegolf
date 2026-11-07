using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Chronos.Reflection
{
	[Serializable]
	[Token(Token = "0x20002C5")]
	public class UnityVariable : UnityMember
	{
		[Token(Token = "0x20002C6")]
		private enum SourceType
		{
			[Token(Token = "0x40011C8")]
			Unknown = 0,
			[Token(Token = "0x40011C9")]
			Field = 1,
			[Token(Token = "0x40011CA")]
			Property = 2
		}

		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x38")]
		private SourceType sourceType;

		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x375B0", Offset = "0x375B0")]
		private FieldInfo fieldInfo__BackingField;

		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x375C0", Offset = "0x375C0")]
		private PropertyInfo propertyInfo__BackingField;

		[Token(Token = "0x17000277")]
		public FieldInfo fieldInfo
		{
			[Token(Token = "0x600129E")]
			[Address(RVA = "0x132656C", Offset = "0x132656C", VA = "0x132656C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BC0C", Offset = "0x3BC0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600129F")]
			[Address(RVA = "0x1326574", Offset = "0x1326574", VA = "0x1326574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BC1C", Offset = "0x3BC1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000278")]
		public PropertyInfo propertyInfo
		{
			[Token(Token = "0x60012A0")]
			[Address(RVA = "0x132657C", Offset = "0x132657C", VA = "0x132657C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BC2C", Offset = "0x3BC2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012A1")]
			[Address(RVA = "0x1326584", Offset = "0x1326584", VA = "0x1326584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BC3C", Offset = "0x3BC3C")]
			private set
			{
			}
		}

		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x132658C", Offset = "0x132658C", VA = "0x132658C")]
		public UnityVariable()
		{
		}

		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x1326594", Offset = "0x1326594", VA = "0x1326594", Slot = "4")]
		public override void Reflect()
		{
		}

		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x1326714", Offset = "0x1326714", VA = "0x1326714")]
		public object Get()
		{
			return null;
		}

		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x13267D0", Offset = "0x13267D0", VA = "0x13267D0")]
		public void Set(object value)
		{
		}
	}
}
