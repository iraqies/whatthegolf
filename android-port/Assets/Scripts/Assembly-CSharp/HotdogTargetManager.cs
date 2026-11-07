using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000301")]
public class HotdogTargetManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000302")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EDFC", Offset = "0x3EDFC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x8")]
		public static Func<HotdogTargetBehaviour, bool> _003C_003E9__3_0;

		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x17C0288", Offset = "0x17C0288", VA = "0x17C0288")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x17C0290", Offset = "0x17C0290", VA = "0x17C0290")]
		internal bool _003CCheckTargets_003Eb__3_0(HotdogTargetBehaviour t)
		{
			return default;
		}
	}

	[Token(Token = "0x40010B3")]
	[FieldOffset(Offset = "0x18")]
	private List<HotdogTargetBehaviour> Targets;

	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnAllTargetsHit;

	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x14DD350", Offset = "0x14DD350", VA = "0x14DD350")]
	private void Start()
	{
	}

	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x14DD5B0", Offset = "0x14DD5B0", VA = "0x14DD5B0")]
	private void CheckTargets(HotdogTargetBehaviour target)
	{
	}

	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x14DD7B4", Offset = "0x14DD7B4", VA = "0x14DD7B4")]
	public HotdogTargetManager()
	{
	}
}
