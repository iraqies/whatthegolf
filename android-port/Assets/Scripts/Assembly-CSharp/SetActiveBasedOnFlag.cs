using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000290")]
public class SetActiveBasedOnFlag : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000291")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E88C", Offset = "0x3E88C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000D9D")]
		[FieldOffset(Offset = "0x8")]
		public static Func<OverworldGoal, bool> _003C_003E9__6_0;

		[Token(Token = "0x4000D9E")]
		[FieldOffset(Offset = "0x10")]
		public static Func<OverworldGoal, bool> _003C_003E9__6_1;

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x18426B4", Offset = "0x18426B4", VA = "0x18426B4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x18426BC", Offset = "0x18426BC", VA = "0x18426BC")]
		internal bool _003CIsComplete_003Eb__6_0(OverworldGoal g)
		{
			return default;
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x18426D8", Offset = "0x18426D8", VA = "0x18426D8")]
		internal bool _003CIsComplete_003Eb__6_1(OverworldGoal g)
		{
			return default;
		}
	}

	[Token(Token = "0x4000D98")]
	[FieldOffset(Offset = "0x18")]
	public List<OverworldGoal> goals;

	[Token(Token = "0x4000D99")]
	[FieldOffset(Offset = "0x20")]
	public bool stateOnComplete;

	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0x21")]
	public bool stateOnIncomplete;

	[Token(Token = "0x4000D9B")]
	[FieldOffset(Offset = "0x22")]
	[SerializeField]
	private bool requireAll;

	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x168A714", Offset = "0x168A714", VA = "0x168A714")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x168AB2C", Offset = "0x168AB2C", VA = "0x168AB2C")]
	private void Goal_OnUpdateData(OverworldGoal g)
	{
	}

	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x168A91C", Offset = "0x168A91C", VA = "0x168A91C")]
	private bool IsComplete()
	{
		return default;
	}

	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x168AD14", Offset = "0x168AD14", VA = "0x168AD14")]
	public SetActiveBasedOnFlag()
	{
	}
}
