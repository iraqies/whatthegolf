using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	[Token(Token = "0x200007D")]
	internal struct ColorTween : ITweenValue
	{
		[Token(Token = "0x200007E")]
		public enum ColorTweenMode
		{
			[Token(Token = "0x4000254")]
			All = 0,
			[Token(Token = "0x4000255")]
			RGB = 1,
			[Token(Token = "0x4000256")]
			Alpha = 2
		}

		[Token(Token = "0x200007F")]
		public class ColorTweenCallback : UnityEvent<Color>
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x2C449DC", Offset = "0x2C449DC", VA = "0x2C449DC")]
			public ColorTweenCallback()
			{
			}
		}

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x0")]
		private ColorTweenCallback m_Target;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x8")]
		private Color m_StartColor;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x18")]
		private Color m_TargetColor;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x28")]
		private ColorTweenMode m_TweenMode;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x2C")]
		private float m_Duration;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IgnoreTimeScale;

		[Token(Token = "0x1700015A")]
		public Color startColor
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x2BFCEB4", Offset = "0x2BFCEB4", VA = "0x2BFCEB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public Color targetColor
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x2BFCEC0", Offset = "0x2BFCEC0", VA = "0x2BFCEC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public ColorTweenMode tweenMode
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x2BFCECC", Offset = "0x2BFCECC", VA = "0x2BFCECC")]
			set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public float duration
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x2BFCED4", Offset = "0x2BFCED4", VA = "0x2BFCED4", Slot = "6")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x2BFCEDC", Offset = "0x2BFCEDC", VA = "0x2BFCEDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x2BFCEE4", Offset = "0x2BFCEE4", VA = "0x2BFCEE4", Slot = "5")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x2BFCEEC", Offset = "0x2BFCEEC", VA = "0x2BFCEEC")]
			set
			{
			}
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x2BFCEF4", Offset = "0x2BFCEF4", VA = "0x2BFCEF4", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2BFCFC8", Offset = "0x2BFCFC8", VA = "0x2BFCFC8")]
		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2BFCFB8", Offset = "0x2BFCFB8", VA = "0x2BFCFB8", Slot = "7")]
		public bool ValidTarget()
		{
			return default;
		}
	}
}
