using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D23")]
public class ABBLoop : MonoBehaviour
{
	[Token(Token = "0x4004741")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioSource start;

	[Token(Token = "0x4004742")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<AudioSource> loop;

	[Token(Token = "0x4004743")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float firstTransitionTime;

	[Token(Token = "0x4004744")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float loopTransitionTime;

	[Token(Token = "0x4004745")]
	[FieldOffset(Offset = "0x30")]
	private bool isLooping;

	[Token(Token = "0x4004746")]
	[FieldOffset(Offset = "0x34")]
	private int currentIndex;

	[Token(Token = "0x6003DFA")]
	[Address(RVA = "0x1403670", Offset = "0x1403670", VA = "0x1403670")]
	private void Start()
	{
	}

	[Token(Token = "0x6003DFB")]
	[Address(RVA = "0x140380C", Offset = "0x140380C", VA = "0x140380C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003DFC")]
	[Address(RVA = "0x14039E4", Offset = "0x14039E4", VA = "0x14039E4")]
	public ABBLoop()
	{
	}
}
