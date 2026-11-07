using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000A6")]
	public static class FallbackRegionFactory
	{
		[Token(Token = "0x20000A7")]
		private delegate AWSRegion RegionGenerator();

		[Serializable]
		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x259FC", Offset = "0x259FC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x8")]
			public static RegionGenerator _003C_003E9__12_0;

			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x10")]
			public static RegionGenerator _003C_003E9__12_1;

			[Token(Token = "0x40002CB")]
			[FieldOffset(Offset = "0x18")]
			public static RegionGenerator _003C_003E9__12_2;

			[Token(Token = "0x40002CC")]
			[FieldOffset(Offset = "0x20")]
			public static RegionGenerator _003C_003E9__12_3;

			[Token(Token = "0x40002CD")]
			[FieldOffset(Offset = "0x28")]
			public static RegionGenerator _003C_003E9__12_4;

			[Token(Token = "0x40002CE")]
			[FieldOffset(Offset = "0x30")]
			public static RegionGenerator _003C_003E9__12_5;

			[Token(Token = "0x40002CF")]
			[FieldOffset(Offset = "0x38")]
			public static RegionGenerator _003C_003E9__12_6;

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x128C5A8", Offset = "0x128C5A8", VA = "0x128C5A8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x128C5B0", Offset = "0x128C5B0", VA = "0x128C5B0")]
			internal AWSRegion _003CReset_003Eb__12_0()
			{
				return null;
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x128C608", Offset = "0x128C608", VA = "0x128C608")]
			internal AWSRegion _003CReset_003Eb__12_1()
			{
				return null;
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x128C660", Offset = "0x128C660", VA = "0x128C660")]
			internal AWSRegion _003CReset_003Eb__12_2()
			{
				return null;
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x128C6F4", Offset = "0x128C6F4", VA = "0x128C6F4")]
			internal AWSRegion _003CReset_003Eb__12_3()
			{
				return null;
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x128C74C", Offset = "0x128C74C", VA = "0x128C74C")]
			internal AWSRegion _003CReset_003Eb__12_4()
			{
				return null;
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x128C7A4", Offset = "0x128C7A4", VA = "0x128C7A4")]
			internal AWSRegion _003CReset_003Eb__12_5()
			{
				return null;
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x128C7FC", Offset = "0x128C7FC", VA = "0x128C7FC")]
			internal AWSRegion _003CReset_003Eb__12_6()
			{
				return null;
			}
		}

		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x0")]
		private static CredentialProfileStoreChain credentialProfileChain;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x8")]
		private static object _lock;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x267E8", Offset = "0x267E8")]
		private static List<RegionGenerator> AllGenerators__BackingField;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x267F8", Offset = "0x267F8")]
		private static List<RegionGenerator> NonMetadataGenerators__BackingField;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x20")]
		private static AWSRegion cachedRegion;

		[Token(Token = "0x17000178")]
		private static List<RegionGenerator> AllGenerators
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1209FCC", Offset = "0x1209FCC", VA = "0x1209FCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28CAC", Offset = "0x28CAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x120A030", Offset = "0x120A030", VA = "0x120A030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28CBC", Offset = "0x28CBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000179")]
		private static List<RegionGenerator> NonMetadataGenerators
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x120A0A0", Offset = "0x120A0A0", VA = "0x120A0A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28CCC", Offset = "0x28CCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x120A104", Offset = "0x120A104", VA = "0x120A104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28CDC", Offset = "0x28CDC")]
			set
			{
			}
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1209878", Offset = "0x1209878", VA = "0x1209878")]
		static FallbackRegionFactory()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1209928", Offset = "0x1209928", VA = "0x1209928")]
		public static void Reset()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x120A174", Offset = "0x120A174", VA = "0x120A174")]
		public static RegionEndpoint GetRegionEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x120A1D0", Offset = "0x120A1D0", VA = "0x120A1D0")]
		public static RegionEndpoint GetRegionEndpoint(bool includeInstanceMetadata)
		{
			return null;
		}
	}
}
