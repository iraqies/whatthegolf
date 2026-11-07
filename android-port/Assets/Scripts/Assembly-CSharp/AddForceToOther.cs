using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DFB")]
public class AddForceToOther : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000DFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44E18", Offset = "0x44E18")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004C25")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004C26")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__10_0;

		[Token(Token = "0x60041D7")]
		[Address(RVA = "0x1768EB8", Offset = "0x1768EB8", VA = "0x1768EB8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60041D8")]
		[Address(RVA = "0x1768EC0", Offset = "0x1768EC0", VA = "0x1768EC0")]
		internal void _003CExecute_003Eb__10_0(float t)
		{
		}
	}

	[Token(Token = "0x4004C1B")]
	[FieldOffset(Offset = "0x18")]
	public bool onAwake;

	[Token(Token = "0x4004C1C")]
	[FieldOffset(Offset = "0x19")]
	public bool useTransformAsTarget;

	[Token(Token = "0x4004C1D")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4004C1E")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 forceDir;

	[Token(Token = "0x4004C1F")]
	[FieldOffset(Offset = "0x34")]
	public float forceMagnitude;

	[Token(Token = "0x4004C20")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 rotationDir;

	[Token(Token = "0x4004C21")]
	[FieldOffset(Offset = "0x44")]
	public float rotationForce;

	[Token(Token = "0x4004C22")]
	[FieldOffset(Offset = "0x48")]
	public float delay;

	[Token(Token = "0x4004C23")]
	[FieldOffset(Offset = "0x4C")]
	public ForceMode mode;

	[Token(Token = "0x4004C24")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rigid;

	[Token(Token = "0x60041D0")]
	[Address(RVA = "0x14075F0", Offset = "0x14075F0", VA = "0x14075F0")]
	public void Execute()
	{
	}

	[Token(Token = "0x60041D1")]
	[Address(RVA = "0x14078E0", Offset = "0x14078E0", VA = "0x14078E0")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60041D2")]
	[Address(RVA = "0x1407824", Offset = "0x1407824", VA = "0x1407824")]
	private void SetForceDirAndRot()
	{
	}

	[Token(Token = "0x60041D3")]
	[Address(RVA = "0x1407B78", Offset = "0x1407B78", VA = "0x1407B78")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60041D4")]
	[Address(RVA = "0x1407C1C", Offset = "0x1407C1C", VA = "0x1407C1C")]
	public AddForceToOther()
	{
	}

	[Token(Token = "0x60041D5")]
	[Address(RVA = "0x1407C24", Offset = "0x1407C24", VA = "0x1407C24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D564", Offset = "0x6D564")]
	private void _003CExecute_003Eb__10_1()
	{
	}
}
