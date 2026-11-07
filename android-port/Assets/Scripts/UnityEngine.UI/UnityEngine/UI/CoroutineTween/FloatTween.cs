using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	[Token(Token = "0x2000080")]
	internal struct FloatTween : ITweenValue
	{
		[Token(Token = "0x2000081")]
		public class FloatTweenCallback : UnityEvent<float>
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x2C45058", Offset = "0x2C45058", VA = "0x2C45058")]
			public FloatTweenCallback()
			{
			}
		}

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x0")]
		private FloatTweenCallback m_Target;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x8")]
		private float m_StartValue;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0xC")]
		private float m_TargetValue;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x10")]
		private float m_Duration;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x14")]
		private bool m_IgnoreTimeScale;

		[Token(Token = "0x1700015F")]
		public float startValue
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x2C044FC", Offset = "0x2C044FC", VA = "0x2C044FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public float targetValue
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x2C04504", Offset = "0x2C04504", VA = "0x2C04504")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public float duration
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x2C0450C", Offset = "0x2C0450C", VA = "0x2C0450C", Slot = "6")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x2C04514", Offset = "0x2C04514", VA = "0x2C04514")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public bool ignoreTimeScale
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x2C0451C", Offset = "0x2C0451C", VA = "0x2C0451C", Slot = "5")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x2C04524", Offset = "0x2C04524", VA = "0x2C04524")]
			set
			{
			}
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2C0452C", Offset = "0x2C0452C", VA = "0x2C0452C", Slot = "4")]
		public void TweenValue(float floatPercentage)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2C006E8", Offset = "0x2C006E8", VA = "0x2C006E8")]
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2C045B4", Offset = "0x2C045B4", VA = "0x2C045B4", Slot = "7")]
		public bool ValidTarget()
		{
			return default;
		}
	}
}
