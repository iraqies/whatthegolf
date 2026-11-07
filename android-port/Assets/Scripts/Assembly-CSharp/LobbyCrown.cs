using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C2")]
public class LobbyCrown : MonoBehaviour
{
	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody m_rigidbody;

	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x20")]
	public LobbyCrownStack Stack;

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x1539BF4", Offset = "0x1539BF4", VA = "0x1539BF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x1539C50", Offset = "0x1539C50", VA = "0x1539C50")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x1539E58", Offset = "0x1539E58", VA = "0x1539E58")]
	public LobbyCrown()
	{
	}
}
