using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009B4")]
public class Fire : MonoBehaviour
{
	[Token(Token = "0x400354E")]
	[FieldOffset(Offset = "0x18")]
	public bool StartOff;

	[Token(Token = "0x400354F")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem ps;

	[Token(Token = "0x4003550")]
	[FieldOffset(Offset = "0x28")]
	public ClipSettingsCollection flameSfx;

	[Token(Token = "0x6002D99")]
	[Address(RVA = "0x1465B94", Offset = "0x1465B94", VA = "0x1465B94")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D9A")]
	[Address(RVA = "0x1465CAC", Offset = "0x1465CAC", VA = "0x1465CAC")]
	public void ToggleFire(bool state)
	{
	}

	[Token(Token = "0x6002D9B")]
	[Address(RVA = "0x1465DE8", Offset = "0x1465DE8", VA = "0x1465DE8")]
	public Fire()
	{
	}
}
