using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E81")]
public class FlagHitCheck : MonoBehaviour
{
	[Token(Token = "0x4004E64")]
	[FieldOffset(Offset = "0x18")]
	public GlobalBool globalBoolScript;

	[Token(Token = "0x4004E65")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnHit;

	[Token(Token = "0x60043C7")]
	[Address(RVA = "0x146A760", Offset = "0x146A760", VA = "0x146A760")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60043C8")]
	[Address(RVA = "0x146A814", Offset = "0x146A814", VA = "0x146A814")]
	public FlagHitCheck()
	{
	}
}
