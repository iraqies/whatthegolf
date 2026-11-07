using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183ADC", Offset = "0x183ADC")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183ADC", Offset = "0x183ADC")]
	public class JsonDynamicContract : JsonContainerContract
	{
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187524", Offset = "0x187524")]
		private readonly JsonPropertyCollection Properties__BackingField;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187534", Offset = "0x187534")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187534", Offset = "0x187534")]
		private Func<string, string> PropertyNameResolver__BackingField;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0xD0")]
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1875BC", Offset = "0x1875BC")]
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters;

		[Token(Token = "0x170000AA")]
		public JsonPropertyCollection Properties
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x22E9300", Offset = "0x22E9300", VA = "0x22E9300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189B34", Offset = "0x189B34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F26C", Offset = "0x18F26C")]
		public Func<string, string> PropertyNameResolver
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x22E9308", Offset = "0x22E9308", VA = "0x22E9308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189B44", Offset = "0x189B44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x22E9310", Offset = "0x22E9310", VA = "0x22E9310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189B54", Offset = "0x189B54")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CE4C", Offset = "0x18CE4C")]
			set
			{
			}
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x22E9318", Offset = "0x22E9318", VA = "0x22E9318")]
		private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x22E9464", Offset = "0x22E9464", VA = "0x22E9464")]
		private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name)
		{
			return null;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x22E95B0", Offset = "0x22E95B0", VA = "0x22E95B0")]
		public JsonDynamicContract(Type underlyingType)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x22E9784", Offset = "0x22E9784", VA = "0x22E9784")]
		internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CEC4", Offset = "0x18CEC4")] out object value)
		{
			return default;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x22E98A8", Offset = "0x22E98A8", VA = "0x22E98A8")]
		internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CED8", Offset = "0x18CED8")] object value)
		{
			return default;
		}
	}
}
