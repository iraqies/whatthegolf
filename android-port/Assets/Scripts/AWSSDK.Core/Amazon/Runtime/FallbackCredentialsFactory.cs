using System;
using System.Collections.Generic;
using System.Net;
using Amazon.Runtime.CredentialManagement;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000B3")]
	public static class FallbackCredentialsFactory
	{
		[Token(Token = "0x20000B4")]
		public delegate AWSCredentials CredentialsGenerator();

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25A0C", Offset = "0x25A0C")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4000317")]
			[FieldOffset(Offset = "0x10")]
			public IWebProxy proxy;

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x128B9B0", Offset = "0x128B9B0", VA = "0x128B9B0")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x128B9B8", Offset = "0x128B9B8", VA = "0x128B9B8")]
			internal AWSCredentials _003CReset_003Eb__3()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25A1C", Offset = "0x25A1C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000318")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000319")]
			[FieldOffset(Offset = "0x8")]
			public static CredentialsGenerator _003C_003E9__10_0;

			[Token(Token = "0x400031A")]
			[FieldOffset(Offset = "0x10")]
			public static CredentialsGenerator _003C_003E9__10_1;

			[Token(Token = "0x400031B")]
			[FieldOffset(Offset = "0x18")]
			public static CredentialsGenerator _003C_003E9__10_2;

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x128B88C", Offset = "0x128B88C", VA = "0x128B88C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x128B894", Offset = "0x128B894", VA = "0x128B894")]
			internal AWSCredentials _003CReset_003Eb__10_0()
			{
				return null;
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x128B8F0", Offset = "0x128B8F0", VA = "0x128B8F0")]
			internal AWSCredentials _003CReset_003Eb__10_1()
			{
				return null;
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x128B958", Offset = "0x128B958", VA = "0x128B958")]
			internal AWSCredentials _003CReset_003Eb__10_2()
			{
				return null;
			}
		}

		[Token(Token = "0x4000312")]
		internal const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";

		[Token(Token = "0x4000313")]
		internal const string DefaultProfileName = "default";

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CredentialProfileStoreChain credentialProfileChain;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x268F8", Offset = "0x268F8")]
		private static List<CredentialsGenerator> CredentialsGenerators__BackingField;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x10")]
		private static AWSCredentials cachedCredentials;

		[Token(Token = "0x170001AF")]
		public static List<CredentialsGenerator> CredentialsGenerators
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x12076B4", Offset = "0x12076B4", VA = "0x12076B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28ECC", Offset = "0x28ECC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1207718", Offset = "0x1207718", VA = "0x1207718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28EDC", Offset = "0x28EDC")]
			set
			{
			}
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x12075A0", Offset = "0x12075A0", VA = "0x12075A0")]
		static FallbackCredentialsFactory()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1207658", Offset = "0x1207658", VA = "0x1207658")]
		public static void Reset()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1207788", Offset = "0x1207788", VA = "0x1207788")]
		public static void Reset(IWebProxy proxy)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1207B50", Offset = "0x1207B50", VA = "0x1207B50")]
		private static AWSCredentials GetAWSCredentials(ICredentialProfileSource source)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1207CE8", Offset = "0x1207CE8", VA = "0x1207CE8")]
		private static AWSCredentials ECSEC2CredentialsWrapper()
		{
			return null;
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1207D44", Offset = "0x1207D44", VA = "0x1207D44")]
		private static AWSCredentials ECSEC2CredentialsWrapper(IWebProxy proxy)
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1207FB4", Offset = "0x1207FB4", VA = "0x1207FB4")]
		public static AWSCredentials GetCredentials()
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1208010", Offset = "0x1208010", VA = "0x1208010")]
		public static AWSCredentials GetCredentials(bool fallbackToAnonymous)
		{
			return null;
		}
	}
}
