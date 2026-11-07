using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002FA")]
public class HoleToSpawn : MonoBehaviour
{
	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x20")]
	public string tagToLookFor;

	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x28")]
	public float timeToKeepOpen;

	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x2C")]
	private bool isOpen;

	[Token(Token = "0x4001077")]
	[FieldOffset(Offset = "0x2D")]
	private bool shouldOpen;

	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x30")]
	private float time;

	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x14D0FB8", Offset = "0x14D0FB8", VA = "0x14D0FB8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x14D1010", Offset = "0x14D1010", VA = "0x14D1010")]
	private void Update()
	{
	}

	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x14D10CC", Offset = "0x14D10CC", VA = "0x14D10CC")]
	public void IsOpen()
	{
	}

	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x14D10D8", Offset = "0x14D10D8", VA = "0x14D10D8")]
	public void Closing()
	{
	}

	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x14D10E0", Offset = "0x14D10E0", VA = "0x14D10E0")]
	public HoleToSpawn()
	{
	}
}
