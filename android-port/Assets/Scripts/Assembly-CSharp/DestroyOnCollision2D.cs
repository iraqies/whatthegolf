using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BD6")]
public class DestroyOnCollision2D : MonoBehaviour
{
	[Token(Token = "0x40041CB")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask DestroyLayers;

	[Token(Token = "0x40041CC")]
	[FieldOffset(Offset = "0x20")]
	public List<AudioClip> DestroyClips;

	[Token(Token = "0x40041CD")]
	[FieldOffset(Offset = "0x28")]
	public float Volume;

	[Token(Token = "0x60038E5")]
	[Address(RVA = "0x18DB15C", Offset = "0x18DB15C", VA = "0x18DB15C")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x60038E6")]
	[Address(RVA = "0x18DB2D4", Offset = "0x18DB2D4", VA = "0x18DB2D4")]
	public DestroyOnCollision2D()
	{
	}

	[Token(Token = "0x60038E7")]
	[Address(RVA = "0x18DB2E4", Offset = "0x18DB2E4", VA = "0x18DB2E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B178", Offset = "0x6B178")]
	private void _003COnCollisionEnter2D_003Eb__3_0(AudioSource m)
	{
	}
}
