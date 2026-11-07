using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BAA")]
public class AddForce : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000BAB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43BC0", Offset = "0x43BC0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400411C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400411D")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__11_0;

		[Token(Token = "0x6003859")]
		[Address(RVA = "0x1768BEC", Offset = "0x1768BEC", VA = "0x1768BEC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600385A")]
		[Address(RVA = "0x1768BF4", Offset = "0x1768BF4", VA = "0x1768BF4")]
		internal void _003CExecute_003Eb__11_0(float t)
		{
		}
	}

	[Token(Token = "0x4004112")]
	[FieldOffset(Offset = "0x18")]
	public bool onAwake;

	[Token(Token = "0x4004113")]
	[FieldOffset(Offset = "0x19")]
	public bool useTransformAsTarget;

	[Token(Token = "0x4004114")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4004115")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 forceDir;

	[Token(Token = "0x4004116")]
	[FieldOffset(Offset = "0x34")]
	public float forceMagnitude;

	[Token(Token = "0x4004117")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 rotationDir;

	[Token(Token = "0x4004118")]
	[FieldOffset(Offset = "0x44")]
	public float rotationForce;

	[Token(Token = "0x4004119")]
	[FieldOffset(Offset = "0x48")]
	public float delay;

	[Token(Token = "0x400411A")]
	[FieldOffset(Offset = "0x4C")]
	public ForceMode mode;

	[Token(Token = "0x400411B")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rigid;

	[Token(Token = "0x6003852")]
	[Address(RVA = "0x14063D8", Offset = "0x14063D8", VA = "0x14063D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003853")]
	[Address(RVA = "0x1406454", Offset = "0x1406454", VA = "0x1406454")]
	public void Execute()
	{
	}

	[Token(Token = "0x6003854")]
	[Address(RVA = "0x1406744", Offset = "0x1406744", VA = "0x1406744")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003855")]
	[Address(RVA = "0x1406688", Offset = "0x1406688", VA = "0x1406688")]
	private void SetForceDirAndRot()
	{
	}

	[Token(Token = "0x6003856")]
	[Address(RVA = "0x14069DC", Offset = "0x14069DC", VA = "0x14069DC")]
	public AddForce()
	{
	}

	[Token(Token = "0x6003857")]
	[Address(RVA = "0x14069E4", Offset = "0x14069E4", VA = "0x14069E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B0B0", Offset = "0x6B0B0")]
	private void _003CExecute_003Eb__11_1()
	{
	}
}
