using System;
using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x200118B")]
	internal class PlayFabSettingsRedirect : PlayFabApiSettings
	{
		[Token(Token = "0x4005EC4")]
		[FieldOffset(Offset = "0x48")]
		private readonly Func<PlayFabSharedSettings> GetSO;

		[Token(Token = "0x170008A2")]
		public override string ProductionEnvironmentUrl
		{
			[Token(Token = "0x600502E")]
			[Address(RVA = "0x15F0728", Offset = "0x15F0728", VA = "0x15F0728", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A3")]
		internal override string VerticalName
		{
			[Token(Token = "0x600502F")]
			[Address(RVA = "0x15F07E0", Offset = "0x15F07E0", VA = "0x15F07E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A4")]
		public override string TitleId
		{
			[Token(Token = "0x6005030")]
			[Address(RVA = "0x15F0898", Offset = "0x15F0898", VA = "0x15F0898", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A5")]
		public override bool DisableFocusTimeCollection
		{
			[Token(Token = "0x6005031")]
			[Address(RVA = "0x15F0950", Offset = "0x15F0950", VA = "0x15F0950", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600502D")]
		[Address(RVA = "0x15EFFCC", Offset = "0x15EFFCC", VA = "0x15EFFCC")]
		public PlayFabSettingsRedirect(Func<PlayFabSharedSettings> getSO)
		{
		}
	}
}
