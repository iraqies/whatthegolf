using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000386")]
public class AudioOnTriggerEnter : MonoBehaviour
{
	[Token(Token = "0x2000387")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F544", Offset = "0x3F544")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x400135E")]
		[FieldOffset(Offset = "0x10")]
		public AudioOnTriggerEnter _003C_003E4__this;

		[Token(Token = "0x400135F")]
		[FieldOffset(Offset = "0x18")]
		public Collider other;

		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x17700C0", Offset = "0x17700C0", VA = "0x17700C0")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60010B0")]
		[Address(RVA = "0x17700C8", Offset = "0x17700C8", VA = "0x17700C8")]
		internal void _003COnTriggerEnter_003Eb__0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0x18")]
	public GameObject objectToCollideWith;

	[Token(Token = "0x4001354")]
	[FieldOffset(Offset = "0x20")]
	public bool playSoundAtCollisionPosition;

	[Token(Token = "0x4001355")]
	[FieldOffset(Offset = "0x28")]
	public List<AudioClip> clips;

	[Token(Token = "0x4001356")]
	[FieldOffset(Offset = "0x30")]
	public float baseVolume;

	[Token(Token = "0x4001357")]
	[FieldOffset(Offset = "0x34")]
	public float volumeDeviance;

	[Token(Token = "0x4001358")]
	[FieldOffset(Offset = "0x38")]
	public float basePitch;

	[Token(Token = "0x4001359")]
	[FieldOffset(Offset = "0x3C")]
	public float pitchDeviance;

	[Token(Token = "0x400135A")]
	[FieldOffset(Offset = "0x40")]
	public float minDistance;

	[Token(Token = "0x400135B")]
	[FieldOffset(Offset = "0x44")]
	public float maxDistance;

	[Token(Token = "0x400135C")]
	[FieldOffset(Offset = "0x48")]
	public float cooldown;

	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x4C")]
	private float nextSoundTime;

	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x150AAD4", Offset = "0x150AAD4", VA = "0x150AAD4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x150AC98", Offset = "0x150AC98", VA = "0x150AC98")]
	public AudioOnTriggerEnter()
	{
	}
}
