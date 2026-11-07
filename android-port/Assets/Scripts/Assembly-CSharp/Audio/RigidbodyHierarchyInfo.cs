using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001337")]
	public struct RigidbodyHierarchyInfo
	{
		[Token(Token = "0x40066C6")]
		[FieldOffset(Offset = "0x0")]
		public Rigidbody rootRB;

		[Token(Token = "0x40066C7")]
		[FieldOffset(Offset = "0x8")]
		public Rigidbody[] allRigids;

		[Token(Token = "0x40066C8")]
		[FieldOffset(Offset = "0x10")]
		public List<Rigidbody> rigidsOnice;

		[Token(Token = "0x60059A2")]
		[Address(RVA = "0x1657B8C", Offset = "0x1657B8C", VA = "0x1657B8C")]
		public RigidbodyHierarchyInfo(Rigidbody rootRB, Rigidbody initRigid)
		{
		}
	}
}
