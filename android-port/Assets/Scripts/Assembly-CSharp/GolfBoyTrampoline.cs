using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B4")]
public class GolfBoyTrampoline : MonoBehaviour
{
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float additionalForce;

	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ClipSettingsCollection jumpClip;

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x149A0B4", Offset = "0x149A0B4", VA = "0x149A0B4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x149A290", Offset = "0x149A290", VA = "0x149A290")]
	public GolfBoyTrampoline()
	{
	}
}
