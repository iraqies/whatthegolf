using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000395")]
public class EventStepSequencer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000396")]
	public class Step
	{
		[Token(Token = "0x40013CC")]
		[FieldOffset(Offset = "0x10")]
		public bool Active;

		[Token(Token = "0x40013CD")]
		[FieldOffset(Offset = "0x14")]
		public int MidiNoteNumber;

		[Token(Token = "0x40013CE")]
		[FieldOffset(Offset = "0x18")]
		public double Duration;

		[Token(Token = "0x60010F8")]
		[Address(RVA = "0x17A0088", Offset = "0x17A0088", VA = "0x17A0088")]
		public Step()
		{
		}
	}

	[Token(Token = "0x40013C5")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent _onStart;

	[Token(Token = "0x40013C6")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent _onTick;

	[Token(Token = "0x40013C7")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent _onStop;

	[Token(Token = "0x40013C8")]
	[FieldOffset(Offset = "0x30")]
	public bool Suspend;

	[Token(Token = "0x40013C9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Metronome _metronome;

	[Token(Token = "0x40013CA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<Step> _steps;

	[Token(Token = "0x40013CB")]
	[FieldOffset(Offset = "0x48")]
	private int _currentTick;

	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x14470E0", Offset = "0x14470E0", VA = "0x14470E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x1447294", Offset = "0x1447294", VA = "0x1447294")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x1447448", Offset = "0x1447448", VA = "0x1447448")]
	public void HandleTicked(double tickTime)
	{
	}

	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x1447508", Offset = "0x1447508", VA = "0x1447508")]
	private void OnStop()
	{
	}

	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x144751C", Offset = "0x144751C", VA = "0x144751C")]
	private void OnStart()
	{
	}

	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x1447530", Offset = "0x1447530", VA = "0x1447530")]
	public EventStepSequencer()
	{
	}
}
