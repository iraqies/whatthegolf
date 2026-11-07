using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000024")]
	internal class RuntimeClip : RuntimeClipBase
	{
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x18")]
		private TimelineClip m_Clip;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x20")]
		private Playable m_Playable;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x30")]
		private Playable m_ParentMixer;

		[Token(Token = "0x1700007B")]
		public override double start
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x2AEA1A8", Offset = "0x2AEA1A8", VA = "0x2AEA1A8", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007C")]
		public override double duration
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x2AEA1EC", Offset = "0x2AEA1EC", VA = "0x2AEA1EC", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007D")]
		public TimelineClip clip
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x2AEA37C", Offset = "0x2AEA37C", VA = "0x2AEA37C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public Playable mixer
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x2AEA384", Offset = "0x2AEA384", VA = "0x2AEA384")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007F")]
		public Playable playable
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x2AEA390", Offset = "0x2AEA390", VA = "0x2AEA390")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000080")]
		public override bool enable
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x2AEA39C", Offset = "0x2AEA39C", VA = "0x2AEA39C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2AE3784", Offset = "0x2AE3784", VA = "0x2AE3784")]
		public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2AEA2F4", Offset = "0x2AEA2F4", VA = "0x2AEA2F4")]
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2AEA540", Offset = "0x2AEA540", VA = "0x2AEA540")]
		public void SetTime(double time)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2AEA5A4", Offset = "0x2AEA5A4", VA = "0x2AEA5A4")]
		public void SetDuration(double duration)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2AEA608", Offset = "0x2AEA608", VA = "0x2AEA608", Slot = "9")]
		public override void EvaluateAt(double localTime, FrameData frameData)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2AEAE08", Offset = "0x2AEAE08", VA = "0x2AEAE08", Slot = "10")]
		public override void Reset()
		{
		}
	}
}
