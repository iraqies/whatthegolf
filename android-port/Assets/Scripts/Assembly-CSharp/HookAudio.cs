using System.Collections.Generic;
using Audio.Rumble;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200039D")]
public class HookAudio : MonoBehaviour
{
	[Token(Token = "0x200039E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F6DC", Offset = "0x3F6DC")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x40013F9")]
		[FieldOffset(Offset = "0x10")]
		public HookAudio _003C_003E4__this;

		[Token(Token = "0x40013FA")]
		[FieldOffset(Offset = "0x18")]
		public float finalPitch;

		[Token(Token = "0x6001122")]
		[Address(RVA = "0x17BF6B8", Offset = "0x17BF6B8", VA = "0x17BF6B8")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6001123")]
		[Address(RVA = "0x17BF6C0", Offset = "0x17BF6C0", VA = "0x17BF6C0")]
		internal void _003CPlayConnectionAudio_003Eb__0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x40013EE")]
	[FieldOffset(Offset = "0x18")]
	private GrapplingHook hook;

	[Token(Token = "0x40013EF")]
	[FieldOffset(Offset = "0x20")]
	private GrapplingHook2D hook2D;

	[Token(Token = "0x40013F0")]
	[FieldOffset(Offset = "0x28")]
	private float nextSound;

	[Token(Token = "0x40013F1")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float volume;

	[Token(Token = "0x40013F2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float pitch;

	[Token(Token = "0x40013F3")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float pitchDeviance;

	[Token(Token = "0x40013F4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float cooldown;

	[Token(Token = "0x40013F5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<AudioClip> onConnectAudioClips;

	[Token(Token = "0x40013F6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<RumbleEventAsset> onConnectRumbles;

	[Token(Token = "0x40013F7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RumbleEventAsset rumbleOnConnect;

	[Token(Token = "0x40013F8")]
	[FieldOffset(Offset = "0x58")]
	private GolfBallController controller;

	[Token(Token = "0x600111B")]
	[Address(RVA = "0x14D4094", Offset = "0x14D4094", VA = "0x14D4094")]
	public void SetController(GolfBallController _controller)
	{
	}

	[Token(Token = "0x600111C")]
	[Address(RVA = "0x14D409C", Offset = "0x14D409C", VA = "0x14D409C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600111D")]
	[Address(RVA = "0x14D434C", Offset = "0x14D434C", VA = "0x14D434C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600111E")]
	[Address(RVA = "0x14D4544", Offset = "0x14D4544", VA = "0x14D4544")]
	private void OnCollision(Rigidbody rb)
	{
	}

	[Token(Token = "0x600111F")]
	[Address(RVA = "0x14D474C", Offset = "0x14D474C", VA = "0x14D474C")]
	private void OnCollision2D(Rigidbody2D rb)
	{
	}

	[Token(Token = "0x6001120")]
	[Address(RVA = "0x14D4548", Offset = "0x14D4548", VA = "0x14D4548")]
	private void PlayConnectionAudio()
	{
	}

	[Token(Token = "0x6001121")]
	[Address(RVA = "0x14D4750", Offset = "0x14D4750", VA = "0x14D4750")]
	public HookAudio()
	{
	}
}
