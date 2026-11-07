using System;
using Il2CppDummyDll;

namespace UnityAsyncAwaitUtil
{
	[Token(Token = "0x20002E5")]
	public class TestButtonHandler
	{
		[Serializable]
		[Token(Token = "0x20002E6")]
		public class Settings
		{
			[Token(Token = "0x4001235")]
			[FieldOffset(Offset = "0x10")]
			public int NumPerColumn;

			[Token(Token = "0x4001236")]
			[FieldOffset(Offset = "0x14")]
			public float VerticalMargin;

			[Token(Token = "0x4001237")]
			[FieldOffset(Offset = "0x18")]
			public float VerticalSpacing;

			[Token(Token = "0x4001238")]
			[FieldOffset(Offset = "0x1C")]
			public float HorizontalSpacing;

			[Token(Token = "0x4001239")]
			[FieldOffset(Offset = "0x20")]
			public float HorizontalMargin;

			[Token(Token = "0x400123A")]
			[FieldOffset(Offset = "0x24")]
			public float ButtonWidth;

			[Token(Token = "0x400123B")]
			[FieldOffset(Offset = "0x28")]
			public float ButtonHeight;

			[Token(Token = "0x600131D")]
			[Address(RVA = "0x1356A6C", Offset = "0x1356A6C", VA = "0x1356A6C")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4001232")]
		[FieldOffset(Offset = "0x10")]
		private readonly Settings _settings;

		[Token(Token = "0x4001233")]
		[FieldOffset(Offset = "0x18")]
		private int _buttonVCount;

		[Token(Token = "0x4001234")]
		[FieldOffset(Offset = "0x1C")]
		private int _buttonHCount;

		[Token(Token = "0x600131A")]
		[Address(RVA = "0x131AC0C", Offset = "0x131AC0C", VA = "0x131AC0C")]
		public TestButtonHandler(Settings settings)
		{
		}

		[Token(Token = "0x600131B")]
		[Address(RVA = "0x131AC38", Offset = "0x131AC38", VA = "0x131AC38")]
		public void Restart()
		{
		}

		[Token(Token = "0x600131C")]
		[Address(RVA = "0x131AC40", Offset = "0x131AC40", VA = "0x131AC40")]
		public bool Display(string text)
		{
			return default;
		}
	}
}
