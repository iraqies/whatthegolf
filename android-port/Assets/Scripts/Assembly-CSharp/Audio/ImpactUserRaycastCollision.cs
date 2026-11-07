using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001361")]
	public class ImpactUserRaycastCollision : ImpactUser
	{
		[Serializable]
		[Token(Token = "0x2001362")]
		public class RaycastPoint
		{
			[Token(Token = "0x40067C7")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40067C8")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A160", Offset = "0x5A160")]
			private bool IsTouching__BackingField;

			[Token(Token = "0x17000A36")]
			public bool IsTouching
			{
				[Token(Token = "0x6005A70")]
				[Address(RVA = "0x17C36C8", Offset = "0x17C36C8", VA = "0x17C36C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72348", Offset = "0x72348")]
				get
				{
					return default;
				}
				[Token(Token = "0x6005A71")]
				[Address(RVA = "0x17C36D0", Offset = "0x17C36D0", VA = "0x17C36D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72358", Offset = "0x72358")]
				set
				{
				}
			}

			[Token(Token = "0x6005A72")]
			[Address(RVA = "0x17C36D8", Offset = "0x17C36D8", VA = "0x17C36D8")]
			public RaycastPoint()
			{
			}
		}

		[Token(Token = "0x40067C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Rigidbody rigid;

		[Token(Token = "0x40067C2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RaycastPoint[] raycastPoints;

		[Token(Token = "0x40067C3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float raycastDistance;

		[Token(Token = "0x40067C4")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private LayerMask layerMask;

		[Token(Token = "0x40067C5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float overlapSize;

		[Token(Token = "0x40067C6")]
		private const int MAX_HIT = 1;

		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0x14E8814", Offset = "0x14E8814", VA = "0x14E8814")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x14E8BB0", Offset = "0x14E8BB0", VA = "0x14E8BB0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0x14E8C7C", Offset = "0x14E8C7C", VA = "0x14E8C7C")]
		public ImpactUserRaycastCollision()
		{
		}
	}
}
