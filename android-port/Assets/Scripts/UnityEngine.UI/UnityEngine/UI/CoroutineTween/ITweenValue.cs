using Il2CppDummyDll;

namespace UnityEngine.UI.CoroutineTween
{
	[Token(Token = "0x200007C")]
	internal interface ITweenValue
	{
		[Token(Token = "0x17000158")]
		bool ignoreTimeScale
		{
			[Token(Token = "0x600051F")]
			get;
		}

		[Token(Token = "0x17000159")]
		float duration
		{
			[Token(Token = "0x6000520")]
			get;
		}

		[Token(Token = "0x600051E")]
		void TweenValue(float floatPercentage);

		[Token(Token = "0x6000521")]
		bool ValidTarget();
	}
}
