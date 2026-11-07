using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F39")]
public class CheckUser : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000F3A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x457E0", Offset = "0x457E0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005237")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005238")]
		[FieldOffset(Offset = "0x8")]
		public static Action<UserCriteria> _003C_003E9__1_0;

		[Token(Token = "0x600472C")]
		[Address(RVA = "0x17834CC", Offset = "0x17834CC", VA = "0x17834CC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600472D")]
		[Address(RVA = "0x17834D4", Offset = "0x17834D4", VA = "0x17834D4")]
		internal void _003CStart_003Eb__1_0(UserCriteria u)
		{
		}
	}

	[Token(Token = "0x4005236")]
	[FieldOffset(Offset = "0x18")]
	public List<UserCriteria> users;

	[Token(Token = "0x6004729")]
	[Address(RVA = "0x1898B18", Offset = "0x1898B18", VA = "0x1898B18")]
	private void Start()
	{
	}

	[Token(Token = "0x600472A")]
	[Address(RVA = "0x1898C4C", Offset = "0x1898C4C", VA = "0x1898C4C")]
	public CheckUser()
	{
	}
}
