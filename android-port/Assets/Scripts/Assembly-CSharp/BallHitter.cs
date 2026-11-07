using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200011D")]
public class BallHitter : MonoBehaviour
{
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float HitForce;

	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x20")]
	public ClipSettingsCollection HitClips;

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x1519030", Offset = "0x1519030", VA = "0x1519030")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x15191A4", Offset = "0x15191A4", VA = "0x15191A4")]
	public BallHitter()
	{
	}
}
