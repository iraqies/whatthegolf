using System;
using System.Collections.Generic;
using System.Linq;
using AppStoreConnectPlayTogether.Models;
using Il2CppDummyDll;
using UnityEngine;

namespace AppStoreConnectPlayTogether.Config
{
	[Token(Token = "0x200148B")]
	public class PlayTogetherResourcesConfiguration : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200148C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x491AC", Offset = "0x491AC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4007162")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4007163")]
			[FieldOffset(Offset = "0x8")]
			public static Func<PlayTogetherChallengeConfiguration, bool> _003C_003E9__2_0;

			[Token(Token = "0x4007164")]
			[FieldOffset(Offset = "0x10")]
			public static Func<PlayTogetherChallengeConfiguration, PlayTogetherChallengeConfiguration> _003C_003E9__2_1;

			[Token(Token = "0x4007165")]
			[FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<PlayTogetherChallengeConfiguration, PlayTogetherChallengeConfiguration>, bool> _003C_003E9__2_2;

			[Token(Token = "0x60060B0")]
			[Address(RVA = "0x1828DF4", Offset = "0x1828DF4", VA = "0x1828DF4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60060B1")]
			[Address(RVA = "0x1828DFC", Offset = "0x1828DFC", VA = "0x1828DFC")]
			internal bool _003CValidateChallengeConfigs_003Eb__2_0(PlayTogetherChallengeConfiguration value)
			{
				return default;
			}

			[Token(Token = "0x60060B2")]
			[Address(RVA = "0x1828E6C", Offset = "0x1828E6C", VA = "0x1828E6C")]
			internal PlayTogetherChallengeConfiguration _003CValidateChallengeConfigs_003Eb__2_1(PlayTogetherChallengeConfiguration value)
			{
				return null;
			}

			[Token(Token = "0x60060B3")]
			[Address(RVA = "0x1828E74", Offset = "0x1828E74", VA = "0x1828E74")]
			internal bool _003CValidateChallengeConfigs_003Eb__2_2(IGrouping<PlayTogetherChallengeConfiguration, PlayTogetherChallengeConfiguration> duplicateGroup)
			{
				return default;
			}
		}

		[Token(Token = "0x4007161")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<PlayTogetherChallengeConfiguration> challengeConfigs;

		[Token(Token = "0x60060AC")]
		[Address(RVA = "0x15F5E64", Offset = "0x15F5E64", VA = "0x15F5E64")]
		public ResourcesFileJson CreateResourcesFile()
		{
			return null;
		}

		[Token(Token = "0x60060AD")]
		[Address(RVA = "0x15F6264", Offset = "0x15F6264", VA = "0x15F6264")]
		private static bool ValidateChallengeConfigs(List<PlayTogetherChallengeConfiguration> values)
		{
			return default;
		}

		[Token(Token = "0x60060AE")]
		[Address(RVA = "0x15F6598", Offset = "0x15F6598", VA = "0x15F6598")]
		public PlayTogetherResourcesConfiguration()
		{
		}
	}
}
