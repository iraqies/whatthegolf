using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x200000D")]
	public interface IClippable
	{
		[Token(Token = "0x17000013")]
		GameObject gameObject
		{
			[Token(Token = "0x6000048")]
			get;
		}

		[Token(Token = "0x6000049")]
		void RecalculateClipping();

		[Token(Token = "0x600004A")]
		void SetClipRect(Rect value, bool validRect);

		[Token(Token = "0x600004B")]
		void SetClipSoftness(Vector2 clipSoftness);
	}
}
