using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002AE")]
	public class AnimationTimeline : ComponentTimeline<Animation>
	{
		[Token(Token = "0x400117C")]
		[FieldOffset(Offset = "0x20")]
		private float _speed;

		[Token(Token = "0x17000241")]
		public float speed
		{
			[Token(Token = "0x6001202")]
			[Address(RVA = "0x12EDE78", Offset = "0x12EDE78", VA = "0x12EDE78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001201")]
		[Address(RVA = "0x12EDE08", Offset = "0x12EDE08", VA = "0x12EDE08")]
		public AnimationTimeline(Timeline timeline, Animation component)
		{
		}

		[Token(Token = "0x6001203")]
		[Address(RVA = "0x12EDE80", Offset = "0x12EDE80", VA = "0x12EDE80", Slot = "16")]
		public override void CopyProperties(Animation source)
		{
		}

		[Token(Token = "0x6001204")]
		[Address(RVA = "0x12EE1EC", Offset = "0x12EE1EC", VA = "0x12EE1EC", Slot = "17")]
		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
