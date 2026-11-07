using Audio;
using Il2CppDummyDll;
using MPuppet;
using UnityEngine;

[Token(Token = "0x2000292")]
public class MPuppetAudio : MonoBehaviour
{
	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MPuppetController puppetController;

	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ClipSettingsCollection sfxOnFootStep;

	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private MPuppetGrabBehaviour grabBehaviour;

	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection sfxOnGrab;

	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ClipSettingsCollection sfxOnThrow;

	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x154C804", Offset = "0x154C804", VA = "0x154C804")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x154CB20", Offset = "0x154CB20", VA = "0x154CB20")]
	private void GrabBehaviour_OnThrow(GameObject arg1, Vector3 arg2)
	{
	}

	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x154CB70", Offset = "0x154CB70", VA = "0x154CB70")]
	private void GrabBehaviour_OnGrab(GameObject obj)
	{
	}

	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x154CBD4", Offset = "0x154CBD4", VA = "0x154CBD4")]
	private void PuppetController_OnFootstep()
	{
	}

	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x154CC38", Offset = "0x154CC38", VA = "0x154CC38")]
	public MPuppetAudio()
	{
	}
}
