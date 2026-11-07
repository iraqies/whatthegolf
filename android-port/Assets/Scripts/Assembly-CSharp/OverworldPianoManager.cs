using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003B2")]
public class OverworldPianoManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003B3")]
	public class Octave
	{
		[Token(Token = "0x400145B")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip baseNoteClip;

		[Token(Token = "0x400145C")]
		[FieldOffset(Offset = "0x18")]
		public List<OverworldPianoKey> childNotes;

		[Token(Token = "0x600118D")]
		[Address(RVA = "0x181CBC0", Offset = "0x181CBC0", VA = "0x181CBC0")]
		public Octave()
		{
		}
	}

	[Token(Token = "0x4001459")]
	[FieldOffset(Offset = "0x18")]
	public float volume;

	[Token(Token = "0x400145A")]
	[FieldOffset(Offset = "0x20")]
	public List<Octave> octaves;

	[Token(Token = "0x600118B")]
	[Address(RVA = "0x15C8D80", Offset = "0x15C8D80", VA = "0x15C8D80")]
	private void Awake()
	{
	}

	[Token(Token = "0x600118C")]
	[Address(RVA = "0x15C8F04", Offset = "0x15C8F04", VA = "0x15C8F04")]
	public OverworldPianoManager()
	{
	}
}
