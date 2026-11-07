using Audio;
using Il2CppDummyDll;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x2000293")]
public class PuppetLocomotionAudio : MonoBehaviour
{
	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float runCycleDuration;

	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B1A4", Offset = "0x4B1A4")]
	[SerializeField]
	private float leftFootAnimationOffset;

	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B1E4", Offset = "0x4B1E4")]
	[SerializeField]
	private float rightFootAnimationOffset;

	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ClipSettingsCollection oneshotFootstepSfx;

	[Token(Token = "0x4000DA8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection jumpSfx;

	[Token(Token = "0x4000DA9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ClipSettingsCollection landSfx;

	[Token(Token = "0x4000DAA")]
	[FieldOffset(Offset = "0x40")]
	private PuppetMaster puppetMaster;

	[Token(Token = "0x4000DAB")]
	[FieldOffset(Offset = "0x48")]
	private CharacterPuppet characterPuppet;

	[Token(Token = "0x4000DAC")]
	[FieldOffset(Offset = "0x50")]
	private Animator animator;

	[Token(Token = "0x4000DAD")]
	[FieldOffset(Offset = "0x58")]
	private CharacterAnimationThirdPerson animationThirdPerson;

	[Token(Token = "0x4000DAE")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody hipRigidbody;

	[Token(Token = "0x4000DAF")]
	[FieldOffset(Offset = "0x68")]
	private bool didJump;

	[Token(Token = "0x4000DB0")]
	[FieldOffset(Offset = "0x69")]
	private bool wasGrounded;

	[Token(Token = "0x4000DB1")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 lastHipVelocity;

	[Token(Token = "0x4000DB2")]
	[FieldOffset(Offset = "0x78")]
	private float lastTimeInRunAnimation;

	[Token(Token = "0x4000DB3")]
	[FieldOffset(Offset = "0x7C")]
	private float timeInRun;

	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x162C888", Offset = "0x162C888", VA = "0x162C888")]
	private void Start()
	{
	}

	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x162C9F4", Offset = "0x162C9F4", VA = "0x162C9F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x162CBE4", Offset = "0x162CBE4", VA = "0x162CBE4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x162CD64", Offset = "0x162CD64", VA = "0x162CD64")]
	private void HandleLanding()
	{
	}

	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x162CAC4", Offset = "0x162CAC4", VA = "0x162CAC4")]
	private void HandleFootsteps()
	{
	}

	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x162CCE8", Offset = "0x162CCE8", VA = "0x162CCE8")]
	private void HandleJump()
	{
	}

	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x162CDE4", Offset = "0x162CDE4", VA = "0x162CDE4")]
	public PuppetLocomotionAudio()
	{
	}
}
