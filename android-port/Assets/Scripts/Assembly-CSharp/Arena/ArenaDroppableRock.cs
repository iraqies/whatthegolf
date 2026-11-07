using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x200121C")]
	public class ArenaDroppableRock : ArenaDroppable
	{
		[Token(Token = "0x40061DE")]
		[FieldOffset(Offset = "0x50")]
		public float sphereCheckRadius;

		[Token(Token = "0x40061DF")]
		[FieldOffset(Offset = "0x58")]
		public GameObject[] CliffObjects;

		[Token(Token = "0x600536A")]
		[Address(RVA = "0x1422F60", Offset = "0x1422F60", VA = "0x1422F60", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600536B")]
		[Address(RVA = "0x142302C", Offset = "0x142302C", VA = "0x142302C", Slot = "6")]
		public override Collider[] GetHitColliders()
		{
			return null;
		}

		[Token(Token = "0x600536C")]
		[Address(RVA = "0x1423064", Offset = "0x1423064", VA = "0x1423064")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600536D")]
		[Address(RVA = "0x14230A0", Offset = "0x14230A0", VA = "0x14230A0")]
		public ArenaDroppableRock()
		{
		}
	}
}
