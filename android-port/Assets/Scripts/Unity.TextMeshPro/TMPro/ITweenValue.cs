using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x2000012")]
	internal interface ITweenValue
	{
		[Token(Token = "0x17000008")]
		bool ignoreTimeScale
		{
			[Token(Token = "0x6000039")]
			get;
		}

		[Token(Token = "0x17000009")]
		float duration
		{
			[Token(Token = "0x600003A")]
			get;
		}

		[Token(Token = "0x6000038")]
		void TweenValue(float floatPercentage);

		[Token(Token = "0x600003B")]
		bool ValidTarget();
	}
}
