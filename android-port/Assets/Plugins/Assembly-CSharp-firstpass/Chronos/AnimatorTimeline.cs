using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002AF")]
	public class AnimatorTimeline : ComponentTimeline<Animator>
	{
		[Token(Token = "0x400117D")]
		[FieldOffset(Offset = "0x20")]
		private float _speed;

		[Token(Token = "0x17000242")]
		public float speed
		{
			[Token(Token = "0x6001206")]
			[Address(RVA = "0x12EFB4C", Offset = "0x12EFB4C", VA = "0x12EFB4C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000243")]
		private int recordedFrames
		{
			[Token(Token = "0x6001207")]
			[Address(RVA = "0x12EFB54", Offset = "0x12EFB54", VA = "0x12EFB54")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001205")]
		[Address(RVA = "0x12EFADC", Offset = "0x12EFADC", VA = "0x12EFADC")]
		public AnimatorTimeline(Timeline timeline, Animator component)
		{
		}

		[Token(Token = "0x6001208")]
		[Address(RVA = "0x12EFBCC", Offset = "0x12EFBCC", VA = "0x12EFBCC", Slot = "16")]
		public override void CopyProperties(Animator source)
		{
		}

		[Token(Token = "0x6001209")]
		[Address(RVA = "0x12EFC00", Offset = "0x12EFC00", VA = "0x12EFC00", Slot = "17")]
		public override void AdjustProperties(float timeScale)
		{
		}

		[Token(Token = "0x600120A")]
		[Address(RVA = "0x12EFC74", Offset = "0x12EFC74", VA = "0x12EFC74", Slot = "12")]
		public override void OnStartOrReEnable()
		{
		}

		[Token(Token = "0x600120B")]
		[Address(RVA = "0x12EFD5C", Offset = "0x12EFD5C", VA = "0x12EFD5C", Slot = "15")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x600120C")]
		[Address(RVA = "0x12EFDD4", Offset = "0x12EFDD4", VA = "0x12EFDD4", Slot = "13")]
		public override void Update()
		{
		}
	}
}
