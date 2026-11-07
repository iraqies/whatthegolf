using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BD2")]
public class CutRopeOnCollision : MonoBehaviour
{
	[Token(Token = "0x40041C6")]
	[FieldOffset(Offset = "0x18")]
	public AudioClipSettings cutSounds;

	[Token(Token = "0x40041C7")]
	[FieldOffset(Offset = "0x20")]
	public float DisableDurationAfterCut;

	[Token(Token = "0x60038D9")]
	[Address(RVA = "0x18C7748", Offset = "0x18C7748", VA = "0x18C7748")]
	private void Update()
	{
	}

	[Token(Token = "0x60038DA")]
	[Address(RVA = "0x18C7788", Offset = "0x18C7788", VA = "0x18C7788")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60038DB")]
	[Address(RVA = "0x18C78A8", Offset = "0x18C78A8", VA = "0x18C78A8")]
	public CutRopeOnCollision()
	{
	}
}
