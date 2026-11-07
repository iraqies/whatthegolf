using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000891")]
public class AddForceLocalSpace : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000892")]
	public class Target
	{
		[Token(Token = "0x4002F08")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody rigidbody;

		[Token(Token = "0x4002F09")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 forceDirection;

		[Token(Token = "0x4002F0A")]
		[FieldOffset(Offset = "0x24")]
		public float forceMagnitude;

		[Token(Token = "0x4002F0B")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 localPoint;

		[Token(Token = "0x600278F")]
		[Address(RVA = "0x1768BF8", Offset = "0x1768BF8", VA = "0x1768BF8")]
		public Target()
		{
		}
	}

	[Token(Token = "0x4002F07")]
	[FieldOffset(Offset = "0x18")]
	public Target[] targets;

	[Token(Token = "0x600278D")]
	[Address(RVA = "0x1406D78", Offset = "0x1406D78", VA = "0x1406D78")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x600278E")]
	[Address(RVA = "0x1406F58", Offset = "0x1406F58", VA = "0x1406F58")]
	public AddForceLocalSpace()
	{
	}
}
