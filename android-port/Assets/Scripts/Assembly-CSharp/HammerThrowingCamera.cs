using Audio;
using Cinemachine;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x2000214")]
public class HammerThrowingCamera : MonoBehaviour
{
	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0x18")]
	public Animator CamAnimator;

	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x20")]
	public PuppetMaster Puppet;

	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x28")]
	public PuppetMasterProp Prop;

	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x30")]
	public float ResetTime;

	[Token(Token = "0x4000A54")]
	[FieldOffset(Offset = "0x34")]
	public bool ShowParticlesWhenReequipping;

	[Token(Token = "0x4000A55")]
	[FieldOffset(Offset = "0x38")]
	public ClipSettingsCollection particleSfx;

	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem Particles;

	[Token(Token = "0x4000A57")]
	[FieldOffset(Offset = "0x48")]
	private float resetTimer;

	[Token(Token = "0x4000A58")]
	private const string followingPlayerName = "FollowingPlayer";

	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x4C")]
	private bool propThrown;

	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x50")]
	private CinemachineStateDrivenCamera camera;

	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0x58")]
	private bool waitForBlend;

	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0x59")]
	private bool showParticles;

	[Token(Token = "0x600094A")]
	[Address(RVA = "0x14C1DE8", Offset = "0x14C1DE8", VA = "0x14C1DE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0x14C1F24", Offset = "0x14C1F24", VA = "0x14C1F24")]
	private void OnDropProp(PuppetMasterProp prop)
	{
	}

	[Token(Token = "0x600094C")]
	[Address(RVA = "0x14C1F8C", Offset = "0x14C1F8C", VA = "0x14C1F8C")]
	private void Update()
	{
	}

	[Token(Token = "0x600094D")]
	[Address(RVA = "0x14C1814", Offset = "0x14C1814", VA = "0x14C1814")]
	public void ForceReset(bool showParticles)
	{
	}

	[Token(Token = "0x600094E")]
	[Address(RVA = "0x14C214C", Offset = "0x14C214C", VA = "0x14C214C")]
	public HammerThrowingCamera()
	{
	}
}
