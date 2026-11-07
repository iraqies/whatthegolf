using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A9C")]
public class ArmBlobChangeTargetTrigger : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A9D")]
	public class ArmBlobTargetInfo
	{
		[Token(Token = "0x4003B18")]
		[FieldOffset(Offset = "0x10")]
		public ArmBlob arm;

		[Token(Token = "0x4003B19")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x176F00C", Offset = "0x176F00C", VA = "0x176F00C")]
		public ArmBlobTargetInfo()
		{
		}
	}

	[Token(Token = "0x4003B17")]
	[FieldOffset(Offset = "0x18")]
	public List<ArmBlobTargetInfo> arms;

	[Token(Token = "0x60032B1")]
	[Address(RVA = "0x1424A30", Offset = "0x1424A30", VA = "0x1424A30")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60032B2")]
	[Address(RVA = "0x1424CCC", Offset = "0x1424CCC", VA = "0x1424CCC")]
	public ArmBlobChangeTargetTrigger()
	{
	}
}
