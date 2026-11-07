using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003D9")]
public class SimpleStepSequencer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003DA")]
	public class Step
	{
		[Token(Token = "0x400151B")]
		[FieldOffset(Offset = "0x10")]
		public bool Active;

		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0x14")]
		public int MidiNoteNumber;

		[Token(Token = "0x400151D")]
		[FieldOffset(Offset = "0x18")]
		public double Duration;

		[Token(Token = "0x6001223")]
		[Address(RVA = "0x184F19C", Offset = "0x184F19C", VA = "0x184F19C")]
		public Step()
		{
		}
	}

	[Token(Token = "0x20003DB")]
	public delegate void HandleTick(double tickTime);

	[Token(Token = "0x4001516")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D3E4", Offset = "0x4D3E4")]
	private HandleTick m_Ticked;

	[Token(Token = "0x4001517")]
	[FieldOffset(Offset = "0x20")]
	public bool Suspend;

	[Token(Token = "0x4001518")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Metronome _metronome;

	[Token(Token = "0x4001519")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Step> _steps;

	[Token(Token = "0x400151A")]
	[FieldOffset(Offset = "0x38")]
	private int _currentTick;

	[Token(Token = "0x14000018")]
	public event HandleTick Ticked
	{
		[Token(Token = "0x600121D")]
		[Address(RVA = "0x16AF11C", Offset = "0x16AF11C", VA = "0x16AF11C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B3C", Offset = "0x61B3C")]
		add
		{
		}
		[Token(Token = "0x600121E")]
		[Address(RVA = "0x16AF310", Offset = "0x16AF310", VA = "0x16AF310")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B4C", Offset = "0x61B4C")]
		remove
		{
		}
	}

	[Token(Token = "0x600121F")]
	[Address(RVA = "0x16AF988", Offset = "0x16AF988", VA = "0x16AF988")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001220")]
	[Address(RVA = "0x16AFA98", Offset = "0x16AFA98", VA = "0x16AFA98")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001221")]
	[Address(RVA = "0x16AFBA8", Offset = "0x16AFBA8", VA = "0x16AFBA8")]
	public void HandleTicked(double tickTime)
	{
	}

	[Token(Token = "0x6001222")]
	[Address(RVA = "0x16AFC78", Offset = "0x16AFC78", VA = "0x16AFC78")]
	public SimpleStepSequencer()
	{
	}
}
