using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003DD")]
public class StepSequencer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003DE")]
	public class Step
	{
		[Token(Token = "0x4001529")]
		[FieldOffset(Offset = "0x10")]
		public bool Active;

		[Token(Token = "0x400152A")]
		[FieldOffset(Offset = "0x14")]
		public int MidiNoteNumber;

		[Token(Token = "0x400152B")]
		[FieldOffset(Offset = "0x18")]
		public double Duration;

		[Token(Token = "0x6001230")]
		[Address(RVA = "0x185B3DC", Offset = "0x185B3DC", VA = "0x185B3DC")]
		public Step()
		{
		}
	}

	[Token(Token = "0x20003DF")]
	public delegate void HandleTick(double tickTime, int midiNoteNumber, double duration);

	[Token(Token = "0x4001524")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D4CC", Offset = "0x4D4CC")]
	private HandleTick m_Ticked;

	[Token(Token = "0x4001525")]
	[FieldOffset(Offset = "0x20")]
	public bool Suspend;

	[Token(Token = "0x4001526")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Metronome _metronome;

	[Token(Token = "0x4001527")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Step> _steps;

	[Token(Token = "0x4001528")]
	[FieldOffset(Offset = "0x38")]
	private int _currentTick;

	[Token(Token = "0x14000019")]
	public event HandleTick Ticked
	{
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x16DEA78", Offset = "0x16DEA78", VA = "0x16DEA78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B5C", Offset = "0x61B5C")]
		add
		{
		}
		[Token(Token = "0x600122B")]
		[Address(RVA = "0x16DEB1C", Offset = "0x16DEB1C", VA = "0x16DEB1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B6C", Offset = "0x61B6C")]
		remove
		{
		}
	}

	[Token(Token = "0x600122C")]
	[Address(RVA = "0x16DEBC0", Offset = "0x16DEBC0", VA = "0x16DEBC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600122D")]
	[Address(RVA = "0x16DECD0", Offset = "0x16DECD0", VA = "0x16DECD0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600122E")]
	[Address(RVA = "0x16DEDE0", Offset = "0x16DEDE0", VA = "0x16DEDE0")]
	public void HandleTicked(double tickTime)
	{
	}

	[Token(Token = "0x600122F")]
	[Address(RVA = "0x16DEEB8", Offset = "0x16DEEB8", VA = "0x16DEEB8")]
	public StepSequencer()
	{
	}
}
