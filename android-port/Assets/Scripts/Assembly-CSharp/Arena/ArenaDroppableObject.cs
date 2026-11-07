using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x2001218")]
	public class ArenaDroppableObject : ArenaDroppable
	{
		[Token(Token = "0x2001219")]
		public enum OverlapType
		{
			[Token(Token = "0x40061D2")]
			OverlapBox = 0,
			[Token(Token = "0x40061D3")]
			OverlapSphere = 1
		}

		[Token(Token = "0x40061CF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private OverlapType overlapType;

		[Token(Token = "0x40061D0")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 overlapObjectSize;

		[Token(Token = "0x6005357")]
		[Address(RVA = "0x14228D0", Offset = "0x14228D0", VA = "0x14228D0", Slot = "6")]
		public override Collider[] GetHitColliders()
		{
			return null;
		}

		[Token(Token = "0x6005358")]
		[Address(RVA = "0x1422978", Offset = "0x1422978", VA = "0x1422978")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6005359")]
		[Address(RVA = "0x1422A04", Offset = "0x1422A04", VA = "0x1422A04")]
		public ArenaDroppableObject()
		{
		}
	}
}
