using System;
using Il2CppDummyDll;

namespace AppStoreConnectPlayTogether.Config
{
	[Serializable]
	[Token(Token = "0x2001488")]
	public class PlayTogetherChallengeConfigurationLocalizationEntry
	{
		[Token(Token = "0x400715E")]
		[FieldOffset(Offset = "0x10")]
		public string locale;

		[Token(Token = "0x400715F")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		[Token(Token = "0x4007160")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		[Token(Token = "0x60060A8")]
		[Address(RVA = "0x15F57F4", Offset = "0x15F57F4", VA = "0x15F57F4")]
		public PlayTogetherChallengeConfigurationLocalizationEntry()
		{
		}
	}
}
