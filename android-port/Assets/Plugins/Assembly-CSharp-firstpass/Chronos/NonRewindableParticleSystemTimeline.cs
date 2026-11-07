using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002B3")]
	public class NonRewindableParticleSystemTimeline : ComponentTimeline<ParticleSystem>, IParticleSystemTimeline, IComponentTimeline
	{
		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0x20")]
		private bool warnedRewind;

		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x24")]
		private float _playbackSpeed;

		[Token(Token = "0x17000247")]
		public float playbackSpeed
		{
			[Token(Token = "0x6001218")]
			[Address(RVA = "0x13BC878", Offset = "0x13BC878", VA = "0x13BC878", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001217")]
		[Address(RVA = "0x13BC808", Offset = "0x13BC808", VA = "0x13BC808")]
		public NonRewindableParticleSystemTimeline(Timeline timeline, ParticleSystem component)
		{
		}

		[Token(Token = "0x6001219")]
		[Address(RVA = "0x13BC880", Offset = "0x13BC880", VA = "0x13BC880", Slot = "16")]
		public override void CopyProperties(ParticleSystem source)
		{
		}

		[Token(Token = "0x600121A")]
		[Address(RVA = "0x13BC8D0", Offset = "0x13BC8D0", VA = "0x13BC8D0", Slot = "17")]
		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
