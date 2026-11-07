using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000002")]
	internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback
	{
		[Token(Token = "0x2000003")]
		private struct WeightInfo
		{
			[Token(Token = "0x4000003")]
			[FieldOffset(Offset = "0x0")]
			public Playable mixer;

			[Token(Token = "0x4000004")]
			[FieldOffset(Offset = "0x10")]
			public Playable parentMixer;

			[Token(Token = "0x4000005")]
			[FieldOffset(Offset = "0x20")]
			public int port;
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private AnimationPlayableOutput m_Output;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<WeightInfo> m_Mixers;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2AE07C4", Offset = "0x2AE07C4", VA = "0x2AE07C4")]
		public AnimationOutputWeightProcessor(AnimationPlayableOutput output)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2AE0890", Offset = "0x2AE0890", VA = "0x2AE0890")]
		private void FindMixers()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2AE0984", Offset = "0x2AE0984", VA = "0x2AE0984")]
		private void FindMixers(Playable parent, int port, Playable node)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2AE0C0C", Offset = "0x2AE0C0C", VA = "0x2AE0C0C", Slot = "4")]
		public void Evaluate()
		{
		}
	}
}
