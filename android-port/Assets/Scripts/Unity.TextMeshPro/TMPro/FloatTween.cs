using Il2CppDummyDll;
using UnityEngine.Events;

namespace TMPro
{
	[Token(Token = "0x2000013")]
	internal struct FloatTween : ITweenValue
	{
		[Token(Token = "0x2000014")]
		public class FloatTweenCallback : UnityEvent<float>
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2ADE688", Offset = "0x2ADE688", VA = "0x2ADE688")]
			public FloatTweenCallback()
			{
			}
		}

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		private FloatTweenCallback m_Target;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x8")]
		private float m_StartValue;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xC")]
		private float m_TargetValue;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x10")]
		private float m_Duration;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x14")]
		private bool m_IgnoreTimeScale;

		[Token(Token = "0x1700000A")]
		public float startValue
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2A7A398", Offset = "0x2A7A398", VA = "0x2A7A398")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public float targetValue
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2A7A3A0", Offset = "0x2A7A3A0", VA = "0x2A7A3A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public float duration
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2A7A3A8", Offset = "0x2A7A3A8", VA = "0x2A7A3A8", Slot = "6")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2A7A3B0", Offset = "0x2A7A3B0", VA = "0x2A7A3B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2A7A3B8", Offset = "0x2A7A3B8", VA = "0x2A7A3B8", Slot = "5")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2A7A3C0", Offset = "0x2A7A3C0", VA = "0x2A7A3C0")]
			set
			{
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2A7A3C8", Offset = "0x2A7A3C8", VA = "0x2A7A3C8", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2A7A460", Offset = "0x2A7A460", VA = "0x2A7A460")]
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2A7A450", Offset = "0x2A7A450", VA = "0x2A7A450", Slot = "7")]
		public bool ValidTarget()
		{
			return default;
		}
	}
}
