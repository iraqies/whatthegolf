using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200013E")]
	public class Constraints
	{
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35A90", Offset = "0x35A90")]
		public float positionWeight;

		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35AA8", Offset = "0x35AA8")]
		public float rotationWeight;

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x1362050", Offset = "0x1362050", VA = "0x1362050")]
		public bool IsValid()
		{
			return default;
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x13620CC", Offset = "0x13620CC", VA = "0x13620CC")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x1362120", Offset = "0x1362120", VA = "0x1362120")]
		public void Update()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x1362430", Offset = "0x1362430", VA = "0x1362430")]
		public Constraints()
		{
		}
	}
}
