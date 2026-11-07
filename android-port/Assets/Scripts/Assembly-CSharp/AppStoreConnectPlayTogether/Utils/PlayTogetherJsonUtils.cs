using System;
using AppStoreConnectPlayTogether.Config;
using AppStoreConnectPlayTogether.Models;
using Il2CppDummyDll;

namespace AppStoreConnectPlayTogether.Utils
{
	[Token(Token = "0x200147E")]
	public static class PlayTogetherJsonUtils
	{
		[Serializable]
		[Token(Token = "0x200147F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4918C", Offset = "0x4918C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4007138")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4007139")]
			[FieldOffset(Offset = "0x8")]
			public static Func<PlayTogetherChallengeConfiguration.EAttemptLimit, string> _003C_003E9__0_0;

			[Token(Token = "0x400713A")]
			[FieldOffset(Offset = "0x10")]
			public static Func<PlayTogetherChallengeConfiguration.EDuration, string> _003C_003E9__0_1;

			[Token(Token = "0x600607D")]
			[Address(RVA = "0x1828D74", Offset = "0x1828D74", VA = "0x1828D74")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600607E")]
			[Address(RVA = "0x1828D7C", Offset = "0x1828D7C", VA = "0x1828D7C")]
			internal string _003CToJsonModel_003Eb__0_0(PlayTogetherChallengeConfiguration.EAttemptLimit l)
			{
				return null;
			}

			[Token(Token = "0x600607F")]
			[Address(RVA = "0x1828D88", Offset = "0x1828D88", VA = "0x1828D88")]
			internal string _003CToJsonModel_003Eb__0_1(PlayTogetherChallengeConfiguration.EDuration d)
			{
				return null;
			}
		}

		[Token(Token = "0x600607A")]
		[Address(RVA = "0x15F59F8", Offset = "0x15F59F8", VA = "0x15F59F8")]
		public static ChallengeJson ToJsonModel(PlayTogetherChallengeConfiguration value)
		{
			return null;
		}

		[Token(Token = "0x600607B")]
		[Address(RVA = "0x15F5DE4", Offset = "0x15F5DE4", VA = "0x15F5DE4")]
		public static ChallengeLocalizationJson ToJsonModel(PlayTogetherChallengeConfigurationLocalizationEntry value)
		{
			return null;
		}
	}
}
