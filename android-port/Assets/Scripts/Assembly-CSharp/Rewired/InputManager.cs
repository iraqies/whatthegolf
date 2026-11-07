using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

namespace Rewired
{
	[Token(Token = "0x2001138")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x47C64", Offset = "0x47C64")]
	public sealed class InputManager : InputManager_Base
	{
		[Token(Token = "0x4005AF4")]
		[FieldOffset(Offset = "0x4E")]
		private bool ignoreRecompile;

		[Token(Token = "0x6004D88")]
		[Address(RVA = "0x14EF248", Offset = "0x14EF248", VA = "0x14EF248", Slot = "4")]
		protected override void OnInitialized()
		{
		}

		[Token(Token = "0x6004D89")]
		[Address(RVA = "0x14EF320", Offset = "0x14EF320", VA = "0x14EF320", Slot = "5")]
		protected override void OnDeinitialized()
		{
		}

		[Token(Token = "0x6004D8A")]
		[Address(RVA = "0x14EF3F0", Offset = "0x14EF3F0", VA = "0x14EF3F0", Slot = "6")]
		protected override void DetectPlatform()
		{
		}

		[Token(Token = "0x6004D8B")]
		[Address(RVA = "0x14EF458", Offset = "0x14EF458", VA = "0x14EF458", Slot = "7")]
		protected override void CheckRecompile()
		{
		}

		[Token(Token = "0x6004D8C")]
		[Address(RVA = "0x14EF45C", Offset = "0x14EF45C", VA = "0x14EF45C", Slot = "8")]
		protected override IExternalTools GetExternalTools()
		{
			return null;
		}

		[Token(Token = "0x6004D8D")]
		[Address(RVA = "0x14EF4B4", Offset = "0x14EF4B4", VA = "0x14EF4B4")]
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			return default;
		}

		[Token(Token = "0x6004D8E")]
		[Address(RVA = "0x14EF24C", Offset = "0x14EF24C", VA = "0x14EF24C")]
		private void SubscribeEvents()
		{
		}

		[Token(Token = "0x6004D8F")]
		[Address(RVA = "0x14EF324", Offset = "0x14EF324", VA = "0x14EF324")]
		private void UnsubscribeEvents()
		{
		}

		[Token(Token = "0x6004D90")]
		[Address(RVA = "0x14EF580", Offset = "0x14EF580", VA = "0x14EF580")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6004D91")]
		[Address(RVA = "0x14EF588", Offset = "0x14EF588", VA = "0x14EF588")]
		public InputManager()
		{
		}
	}
}
