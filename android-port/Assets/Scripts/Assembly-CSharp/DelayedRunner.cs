using Audio;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200022C")]
public class DelayedRunner : MonoBehaviour
{
	[Token(Token = "0x4000B13")]
	[FieldOffset(Offset = "0x18")]
	public CinemachineDollyCart CartToStart;

	[Token(Token = "0x4000B14")]
	[FieldOffset(Offset = "0x20")]
	public PuppetAutoRun Runner;

	[Token(Token = "0x4000B15")]
	[FieldOffset(Offset = "0x28")]
	public ClipSettingsCollection StartClip;

	[Token(Token = "0x4000B16")]
	[FieldOffset(Offset = "0x30")]
	private bool hasStarted;

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x18D9804", Offset = "0x18D9804", VA = "0x18D9804")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x18D98E8", Offset = "0x18D98E8", VA = "0x18D98E8")]
	public DelayedRunner()
	{
	}
}
