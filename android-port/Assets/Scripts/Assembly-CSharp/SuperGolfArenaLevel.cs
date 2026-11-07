using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200082E")]
public class SuperGolfArenaLevel : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200082F")]
	public class LevelEvent
	{
		[Token(Token = "0x4002C1A")]
		[FieldOffset(Offset = "0x10")]
		public List<GameObject> Enemies;

		[Token(Token = "0x4002C1B")]
		[FieldOffset(Offset = "0x18")]
		public UnityEvent Event;

		[Token(Token = "0x4002C1C")]
		[FieldOffset(Offset = "0x20")]
		public bool Invoked;

		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x185C37C", Offset = "0x185C37C", VA = "0x185C37C")]
		public LevelEvent()
		{
		}
	}

	[Token(Token = "0x4002C18")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnLevelStart;

	[Token(Token = "0x4002C19")]
	[FieldOffset(Offset = "0x20")]
	public List<LevelEvent> Events;

	[Token(Token = "0x60025A3")]
	[Address(RVA = "0x16E7E50", Offset = "0x16E7E50", VA = "0x16E7E50")]
	private void Start()
	{
	}

	[Token(Token = "0x60025A4")]
	[Address(RVA = "0x16E7E6C", Offset = "0x16E7E6C", VA = "0x16E7E6C")]
	private void Update()
	{
	}

	[Token(Token = "0x60025A5")]
	[Address(RVA = "0x16E81A4", Offset = "0x16E81A4", VA = "0x16E81A4")]
	public SuperGolfArenaLevel()
	{
	}
}
