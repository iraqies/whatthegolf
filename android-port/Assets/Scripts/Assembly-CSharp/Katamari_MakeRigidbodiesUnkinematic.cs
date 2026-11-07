using System.Collections.Generic;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D94")]
public class Katamari_MakeRigidbodiesUnkinematic : MonoBehaviour
{
	[Token(Token = "0x40049EA")]
	[FieldOffset(Offset = "0x18")]
	public KatamariBall katamariController;

	[Token(Token = "0x40049EB")]
	[FieldOffset(Offset = "0x20")]
	public CinemachineVirtualCamera virtualCamera;

	[Token(Token = "0x40049EC")]
	[FieldOffset(Offset = "0x28")]
	public float sizeTreshold;

	[Token(Token = "0x40049ED")]
	[FieldOffset(Offset = "0x30")]
	public GameObject explosion;

	[Token(Token = "0x40049EE")]
	[FieldOffset(Offset = "0x38")]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x40049EF")]
	[FieldOffset(Offset = "0x40")]
	private float katamariSize;

	[Token(Token = "0x40049F0")]
	[FieldOffset(Offset = "0x44")]
	private bool madeUnkinematic;

	[Token(Token = "0x6003FD9")]
	[Address(RVA = "0x14FC6BC", Offset = "0x14FC6BC", VA = "0x14FC6BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6003FDA")]
	[Address(RVA = "0x14FC71C", Offset = "0x14FC71C", VA = "0x14FC71C")]
	private void MakeUnkinematic()
	{
	}

	[Token(Token = "0x6003FDB")]
	[Address(RVA = "0x14FC93C", Offset = "0x14FC93C", VA = "0x14FC93C")]
	public Katamari_MakeRigidbodiesUnkinematic()
	{
	}
}
