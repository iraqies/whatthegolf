using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BAD")]
public class AddTempTimeline : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000BAE")]
	public class TempTimeline
	{
		[Token(Token = "0x4004128")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4004129")]
		[FieldOffset(Offset = "0x18")]
		public string ClockName;

		[Token(Token = "0x400412A")]
		[FieldOffset(Offset = "0x20")]
		public bool AddToChildren;

		[Token(Token = "0x6003862")]
		[Address(RVA = "0x1768EC4", Offset = "0x1768EC4", VA = "0x1768EC4")]
		public TempTimeline()
		{
		}
	}

	[Token(Token = "0x4004125")]
	[FieldOffset(Offset = "0x18")]
	public List<TempTimeline> ObjectsToAdd;

	[Token(Token = "0x4004126")]
	[FieldOffset(Offset = "0x20")]
	private List<Behaviour> timelineAdded;

	[Token(Token = "0x4004127")]
	[FieldOffset(Offset = "0x28")]
	private bool applicationIsQuitting;

	[Token(Token = "0x600385E")]
	[Address(RVA = "0x14080D0", Offset = "0x14080D0", VA = "0x14080D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600385F")]
	[Address(RVA = "0x140871C", Offset = "0x140871C", VA = "0x140871C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003860")]
	[Address(RVA = "0x1408974", Offset = "0x1408974", VA = "0x1408974")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6003861")]
	[Address(RVA = "0x1408980", Offset = "0x1408980", VA = "0x1408980")]
	public AddTempTimeline()
	{
	}
}
