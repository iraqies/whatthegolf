using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000392")]
public class OnCollisionManyAudio : MonoBehaviour
{
	[Token(Token = "0x2000393")]
	public class AudioCollisionCounter
	{
		[Token(Token = "0x40013B7")]
		[FieldOffset(Offset = "0x10")]
		public float startTime;

		[Token(Token = "0x40013B8")]
		[FieldOffset(Offset = "0x14")]
		public float endTime;

		[Token(Token = "0x40013B9")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x180AA8C", Offset = "0x180AA8C", VA = "0x180AA8C")]
		public AudioCollisionCounter()
		{
		}
	}

	[Token(Token = "0x40013AF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int amount;

	[Token(Token = "0x40013B0")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float time;

	[Token(Token = "0x40013B1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float cooldownTimeBeforeStartingNewCount;

	[Token(Token = "0x40013B2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<OnCollisionAudio> collisionAudios;

	[Token(Token = "0x40013B3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<AudioClip> clips;

	[Token(Token = "0x40013B4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<RumbleEventAsset> rumbles;

	[Token(Token = "0x40013B5")]
	[FieldOffset(Offset = "0x40")]
	private List<AudioCollisionCounter> counters;

	[Token(Token = "0x40013B6")]
	[FieldOffset(Offset = "0x48")]
	private float nextPlay;

	[Token(Token = "0x60010E6")]
	[Address(RVA = "0x15995D0", Offset = "0x15995D0", VA = "0x15995D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60010E7")]
	[Address(RVA = "0x15998A4", Offset = "0x15998A4", VA = "0x15998A4")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x60010E8")]
	[Address(RVA = "0x15998E0", Offset = "0x15998E0", VA = "0x15998E0")]
	private void Ca_OnAudioPlay()
	{
	}

	[Token(Token = "0x60010E9")]
	[Address(RVA = "0x1599C54", Offset = "0x1599C54", VA = "0x1599C54")]
	public OnCollisionManyAudio()
	{
	}
}
