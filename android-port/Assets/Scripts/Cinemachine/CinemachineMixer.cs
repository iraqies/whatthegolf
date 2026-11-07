using Cinemachine;
using Il2CppDummyDll;
using UnityEngine.Playables;

[Token(Token = "0x2000004")]
internal sealed class CinemachineMixer : PlayableBehaviour
{
	[Token(Token = "0x2000005")]
	private struct ClipInfo
	{
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		public ICinemachineCamera vcam;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x8")]
		public float weight;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x10")]
		public double localTime;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		public double duration;
	}

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x10")]
	private CinemachineBrain mBrain;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x18")]
	private int mBrainOverrideId;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x1C")]
	private bool mPlaying;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x20")]
	private float mLastOverrideTime;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x18F9028", Offset = "0x18F9028", VA = "0x18F9028", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x18F90CC", Offset = "0x18F90CC", VA = "0x18F90CC", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x18F9100", Offset = "0x18F9100", VA = "0x18F9100", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x18F9728", Offset = "0x18F9728", VA = "0x18F9728")]
	private float GetDeltaTime(float deltaTime)
	{
		return default;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x18F97D0", Offset = "0x18F97D0", VA = "0x18F97D0")]
	public CinemachineMixer()
	{
	}
}
