using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DDA")]
public class SingingBlanket : MonoBehaviour
{
	[Token(Token = "0x4004B69")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem _nodes;

	[Token(Token = "0x4004B6A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioSource _audio;

	[Token(Token = "0x600413E")]
	[Address(RVA = "0x16B24B8", Offset = "0x16B24B8", VA = "0x16B24B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600413F")]
	[Address(RVA = "0x16B2524", Offset = "0x16B2524", VA = "0x16B2524")]
	private void StartSinging()
	{
	}

	[Token(Token = "0x6004140")]
	[Address(RVA = "0x16B24BC", Offset = "0x16B24BC", VA = "0x16B24BC")]
	private void StopSinging()
	{
	}

	[Token(Token = "0x6004141")]
	[Address(RVA = "0x16B25AC", Offset = "0x16B25AC", VA = "0x16B25AC")]
	public SingingBlanket()
	{
	}
}
