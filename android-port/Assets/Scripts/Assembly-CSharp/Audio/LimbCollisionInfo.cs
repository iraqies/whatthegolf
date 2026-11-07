using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200137F")]
	public class LimbCollisionInfo : MonoBehaviour
	{
		[Token(Token = "0x2001380")]
		public struct LimbHitInfo
		{
			[Token(Token = "0x400689C")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 point;

			[Token(Token = "0x400689D")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 impactOnNormal;

			[Token(Token = "0x400689E")]
			[FieldOffset(Offset = "0x18")]
			public Transform limb;

			[Token(Token = "0x400689F")]
			[FieldOffset(Offset = "0x20")]
			public Transform hit;
		}

		[Token(Token = "0x400689B")]
		[FieldOffset(Offset = "0x18")]
		public Action<LimbHitInfo> onCollision;

		[Token(Token = "0x6005B12")]
		[Address(RVA = "0x1531F00", Offset = "0x1531F00", VA = "0x1531F00")]
		private void OnCollisionEnter(Collision col)
		{
		}

		[Token(Token = "0x6005B13")]
		[Address(RVA = "0x1532060", Offset = "0x1532060", VA = "0x1532060")]
		private void OnCollisionEnter2D(Collision2D col)
		{
		}

		[Token(Token = "0x6005B14")]
		[Address(RVA = "0x15321C8", Offset = "0x15321C8", VA = "0x15321C8")]
		public LimbCollisionInfo()
		{
		}
	}
}
