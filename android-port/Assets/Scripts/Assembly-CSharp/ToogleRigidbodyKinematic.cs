using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C67")]
public class ToogleRigidbodyKinematic : MonoBehaviour
{
	[Token(Token = "0x4004404")]
	[FieldOffset(Offset = "0x18")]
	public bool Recursively;

	[Token(Token = "0x4004405")]
	[FieldOffset(Offset = "0x20")]
	private List<Rigidbody> rigids;

	[Token(Token = "0x6003AE1")]
	[Address(RVA = "0x171D6E0", Offset = "0x171D6E0", VA = "0x171D6E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003AE2")]
	[Address(RVA = "0x171DAE0", Offset = "0x171DAE0", VA = "0x171DAE0")]
	public void Toggle(bool state)
	{
	}

	[Token(Token = "0x6003AE3")]
	[Address(RVA = "0x171D76C", Offset = "0x171D76C", VA = "0x171D76C")]
	private void TryAddRigid(Transform go)
	{
	}

	[Token(Token = "0x6003AE4")]
	[Address(RVA = "0x171DC38", Offset = "0x171DC38", VA = "0x171DC38")]
	public ToogleRigidbodyKinematic()
	{
	}
}
