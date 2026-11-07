using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1839FC", Offset = "0x1839FC")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1839FC", Offset = "0x1839FC")]
	public class JsonContainerContract : JsonContract
	{
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x90")]
		private JsonContract _itemContract;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x98")]
		private JsonContract _finalItemContract;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186ECC", Offset = "0x186ECC")]
		private JsonConverter ItemConverter__BackingField;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186EDC", Offset = "0x186EDC")]
		private bool? ItemIsReference__BackingField;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186EEC", Offset = "0x186EEC")]
		private ReferenceLoopHandling? ItemReferenceLoopHandling__BackingField;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186EFC", Offset = "0x186EFC")]
		private TypeNameHandling? ItemTypeNameHandling__BackingField;

		[Token(Token = "0x1700008F")]
		internal JsonContract ItemContract
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x22E65B8", Offset = "0x22E65B8", VA = "0x22E65B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x22E65C0", Offset = "0x22E65C0", VA = "0x22E65C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		internal JsonContract FinalItemContract
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x22E660C", Offset = "0x22E660C", VA = "0x22E660C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public JsonConverter ItemConverter
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x22E6614", Offset = "0x22E6614", VA = "0x22E6614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189824", Offset = "0x189824")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x22E661C", Offset = "0x22E661C", VA = "0x22E661C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189834", Offset = "0x189834")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool? ItemIsReference
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x22E6624", Offset = "0x22E6624", VA = "0x22E6624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189844", Offset = "0x189844")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x22E662C", Offset = "0x22E662C", VA = "0x22E662C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189854", Offset = "0x189854")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x22E6634", Offset = "0x22E6634", VA = "0x22E6634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189864", Offset = "0x189864")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x22E663C", Offset = "0x22E663C", VA = "0x22E663C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189874", Offset = "0x189874")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x22E6644", Offset = "0x22E6644", VA = "0x22E6644")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189884", Offset = "0x189884")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x22E664C", Offset = "0x22E664C", VA = "0x22E664C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189894", Offset = "0x189894")]
			set
			{
			}
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x22E5B54", Offset = "0x22E5B54", VA = "0x22E5B54")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1898A4", Offset = "0x1898A4")]
		internal JsonContainerContract(Type underlyingType)
		{
		}
	}
}
