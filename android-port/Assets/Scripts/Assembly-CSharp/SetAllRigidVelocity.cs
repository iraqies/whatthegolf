using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000356")]
public class SetAllRigidVelocity : MonoBehaviour
{
	[Token(Token = "0x4001266")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Rigidbody> rigids;

	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 velocity;

	[Token(Token = "0x4001268")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 angularVelocity;

	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x168AD24", Offset = "0x168AD24", VA = "0x168AD24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x168AE78", Offset = "0x168AE78", VA = "0x168AE78")]
	public void SetAll()
	{
	}

	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x168AE9C", Offset = "0x168AE9C", VA = "0x168AE9C")]
	public void SetAllVelocity()
	{
	}

	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x168AF60", Offset = "0x168AF60", VA = "0x168AF60")]
	public void SetAllAngularVelocity()
	{
	}

	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x168B024", Offset = "0x168B024", VA = "0x168B024")]
	public SetAllRigidVelocity()
	{
	}

	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x168B02C", Offset = "0x168B02C", VA = "0x168B02C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611DC", Offset = "0x611DC")]
	private void _003CSetAllVelocity_003Eb__5_0(Rigidbody r)
	{
	}

	[Token(Token = "0x6000F7B")]
	[Address(RVA = "0x168B050", Offset = "0x168B050", VA = "0x168B050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611EC", Offset = "0x611EC")]
	private void _003CSetAllAngularVelocity_003Eb__6_0(Rigidbody r)
	{
	}
}
