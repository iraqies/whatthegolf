using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x25B4C", Offset = "0x25B4C")]
	public static class FallbackEndpointDiscoveryEnabledFactory
	{
		[Token(Token = "0x20000D5")]
		private delegate bool ConfigGenerator();

		[Serializable]
		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25B84", Offset = "0x25B84")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40003A1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40003A2")]
			[FieldOffset(Offset = "0x8")]
			public static ConfigGenerator _003C_003E9__8_0;

			[Token(Token = "0x40003A3")]
			[FieldOffset(Offset = "0x10")]
			public static ConfigGenerator _003C_003E9__8_1;

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x128BD7C", Offset = "0x128BD7C", VA = "0x128BD7C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x128BD84", Offset = "0x128BD84", VA = "0x128BD84")]
			internal bool _003CReset_003Eb__8_0()
			{
				return default;
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x128BDE4", Offset = "0x128BDE4", VA = "0x128BDE4")]
			internal bool _003CReset_003Eb__8_1()
			{
				return default;
			}
		}

		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x0")]
		private static CredentialProfileStoreChain credentialProfileChain;

		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x8")]
		private static object _lock;

		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B68", Offset = "0x26B68")]
		private static List<ConfigGenerator> EnabledGenerators__BackingField;

		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x18")]
		private static bool? endpointDiscoveryEnabled;

		[Token(Token = "0x170001E6")]
		private static List<ConfigGenerator> EnabledGenerators
		{
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1208B00", Offset = "0x1208B00", VA = "0x1208B00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x293DC", Offset = "0x293DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1208B64", Offset = "0x1208B64", VA = "0x1208B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x293EC", Offset = "0x293EC")]
			set
			{
			}
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x12087A8", Offset = "0x12087A8", VA = "0x12087A8")]
		static FallbackEndpointDiscoveryEnabledFactory()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1208858", Offset = "0x1208858", VA = "0x1208858")]
		public static void Reset()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1208BD4", Offset = "0x1208BD4", VA = "0x1208BD4")]
		public static bool? GetEnabled()
		{
			return null;
		}
	}
}
