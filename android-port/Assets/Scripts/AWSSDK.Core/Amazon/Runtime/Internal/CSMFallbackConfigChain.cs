using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x20001A8")]
	public class CSMFallbackConfigChain
	{
		[Token(Token = "0x20001A9")]
		public delegate void ConfigurationSource();

		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x10")]
		private readonly ILogger LOGGER;

		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x0")]
		private static CredentialProfileStoreChain credentialProfileChain;

		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x275F8", Offset = "0x275F8")]
		private List<ConfigurationSource> AllGenerators__BackingField;

		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27608", Offset = "0x27608")]
		private bool IsConfigSet__BackingField;

		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27618", Offset = "0x27618")]
		private string ConfigSource__BackingField;

		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27628", Offset = "0x27628")]
		private CSMConfiguration CSMConfiguration__BackingField;

		[Token(Token = "0x1700035D")]
		public List<ConfigurationSource> AllGenerators
		{
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x11DA7C8", Offset = "0x11DA7C8", VA = "0x11DA7C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AF24", Offset = "0x2AF24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D35")]
			[Address(RVA = "0x11DA7D0", Offset = "0x11DA7D0", VA = "0x11DA7D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AF34", Offset = "0x2AF34")]
			set
			{
			}
		}

		[Token(Token = "0x1700035E")]
		internal bool IsConfigSet
		{
			[Token(Token = "0x6000D36")]
			[Address(RVA = "0x11DA7D8", Offset = "0x11DA7D8", VA = "0x11DA7D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AF44", Offset = "0x2AF44")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D37")]
			[Address(RVA = "0x11DA7E0", Offset = "0x11DA7E0", VA = "0x11DA7E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AF54", Offset = "0x2AF54")]
			set
			{
			}
		}

		[Token(Token = "0x1700035F")]
		public string ConfigSource
		{
			[Token(Token = "0x6000D38")]
			[Address(RVA = "0x11DA7E8", Offset = "0x11DA7E8", VA = "0x11DA7E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AF64", Offset = "0x2AF64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x11DA7F0", Offset = "0x11DA7F0", VA = "0x11DA7F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AF74", Offset = "0x2AF74")]
			set
			{
			}
		}

		[Token(Token = "0x17000360")]
		public CSMConfiguration CSMConfiguration
		{
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x11DA7F8", Offset = "0x11DA7F8", VA = "0x11DA7F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AF84", Offset = "0x2AF84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x11DA800", Offset = "0x11DA800", VA = "0x11DA800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AF94", Offset = "0x2AF94")]
			internal set
			{
			}
		}

		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x11DA808", Offset = "0x11DA808", VA = "0x11DA808")]
		public CSMFallbackConfigChain()
		{
		}

		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x11DAABC", Offset = "0x11DAABC", VA = "0x11DAABC")]
		public CSMConfiguration GetCSMConfig()
		{
			return null;
		}

		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x11DAE78", Offset = "0x11DAE78", VA = "0x11DAE78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AFA4", Offset = "0x2AFA4")]
		private void _003C_002Ector_003Eb__19_0()
		{
		}

		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x11DAED4", Offset = "0x11DAED4", VA = "0x11DAED4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AFB4", Offset = "0x2AFB4")]
		private void _003C_002Ector_003Eb__19_1()
		{
		}

		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x11DAF30", Offset = "0x11DAF30", VA = "0x11DAF30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AFC4", Offset = "0x2AFC4")]
		private void _003C_002Ector_003Eb__19_2()
		{
		}
	}
}
