using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200015D")]
	public static class FallbackInternalConfigurationFactory
	{
		[Token(Token = "0x200015E")]
		private delegate InternalConfiguration ConfigGenerator();

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25C98", Offset = "0x25C98")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x400056F")]
			[FieldOffset(Offset = "0x10")]
			public InternalConfiguration environmentVariablesConfiguration;

			[Token(Token = "0x4000570")]
			[FieldOffset(Offset = "0x18")]
			public InternalConfiguration profileConfiguration;

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x128C244", Offset = "0x128C244", VA = "0x128C244")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x128C24C", Offset = "0x128C24C", VA = "0x128C24C")]
			internal InternalConfiguration _003CReset_003Eb__3()
			{
				return null;
			}

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x128C254", Offset = "0x128C254", VA = "0x128C254")]
			internal InternalConfiguration _003CReset_003Eb__4()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25CA8", Offset = "0x25CA8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000571")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000572")]
			[FieldOffset(Offset = "0x8")]
			public static Func<InternalConfiguration, bool?> _003C_003E9__4_0;

			[Token(Token = "0x4000573")]
			[FieldOffset(Offset = "0x10")]
			public static Func<InternalConfiguration, RequestRetryMode?> _003C_003E9__4_1;

			[Token(Token = "0x4000574")]
			[FieldOffset(Offset = "0x18")]
			public static Func<InternalConfiguration, int?> _003C_003E9__4_2;

			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x128C1F4", Offset = "0x128C1F4", VA = "0x128C1F4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x128C1FC", Offset = "0x128C1FC", VA = "0x128C1FC")]
			internal bool? _003CReset_003Eb__4_0(InternalConfiguration c)
			{
				return null;
			}

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x128C214", Offset = "0x128C214", VA = "0x128C214")]
			internal RequestRetryMode? _003CReset_003Eb__4_1(InternalConfiguration c)
			{
				return null;
			}

			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x128C22C", Offset = "0x128C22C", VA = "0x128C22C")]
			internal int? _003CReset_003Eb__4_2(InternalConfiguration c)
			{
				return null;
			}
		}

		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x0")]
		private static CredentialProfileStoreChain _credentialProfileChain;

		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x8")]
		private static InternalConfiguration _cachedConfiguration;

		[Token(Token = "0x170002E6")]
		public static bool? EndpointDiscoveryEnabled
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x1209728", Offset = "0x1209728", VA = "0x1209728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E7")]
		public static RequestRetryMode? RetryMode
		{
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x1209798", Offset = "0x1209798", VA = "0x1209798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E8")]
		public static int? MaxAttempts
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x1209808", Offset = "0x1209808", VA = "0x1209808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x120910C", Offset = "0x120910C", VA = "0x120910C")]
		static FallbackInternalConfigurationFactory()
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x1209188", Offset = "0x1209188", VA = "0x1209188")]
		public static void Reset()
		{
		}

		[Token(Token = "0x6000B16")]
		private static T? SeekValue<T>(List<ConfigGenerator> generators, Func<InternalConfiguration, T?> getValue) where T : struct
		{
			return null;
		}
	}
}
