using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000819")]
public class RunnerGolfLevelManager : MonoBehaviour
{
	[Token(Token = "0x200081A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x417C0", Offset = "0x417C0")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4002B92")]
		[FieldOffset(Offset = "0x10")]
		public GameObject lastSpawnedIsland;

		[Token(Token = "0x4002B93")]
		[FieldOffset(Offset = "0x18")]
		public Func<GameObject, bool> _003C_003E9__0;

		[Token(Token = "0x6002533")]
		[Address(RVA = "0x1836804", Offset = "0x1836804", VA = "0x1836804")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6002534")]
		[Address(RVA = "0x183680C", Offset = "0x183680C", VA = "0x183680C")]
		internal bool _003CStart_003Eb__0(GameObject island)
		{
			return default;
		}
	}

	[Token(Token = "0x4002B8D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject StartIsland;

	[Token(Token = "0x4002B8E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EndIsland;

	[Token(Token = "0x4002B8F")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> LevelTemplates;

	[Token(Token = "0x4002B90")]
	[FieldOffset(Offset = "0x30")]
	public int LevelLength;

	[Token(Token = "0x4002B91")]
	[FieldOffset(Offset = "0x34")]
	public float Padding;

	[Token(Token = "0x6002531")]
	[Address(RVA = "0x1663DD0", Offset = "0x1663DD0", VA = "0x1663DD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002532")]
	[Address(RVA = "0x1664240", Offset = "0x1664240", VA = "0x1664240")]
	public RunnerGolfLevelManager()
	{
	}
}
