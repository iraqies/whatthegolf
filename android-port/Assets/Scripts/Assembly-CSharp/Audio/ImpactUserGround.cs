using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001360")]
	public class ImpactUserGround : ImpactUser
	{
		[Token(Token = "0x40067BC")]
		[FieldOffset(Offset = "0x40")]
		public float thresholdY;

		[Token(Token = "0x40067BD")]
		[FieldOffset(Offset = "0x44")]
		public float topLayerSkin;

		[Token(Token = "0x40067BE")]
		[FieldOffset(Offset = "0x48")]
		private MeshCollider m_MeshCollider;

		[Token(Token = "0x40067BF")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 top;

		[Token(Token = "0x40067C0")]
		[FieldOffset(Offset = "0x5C")]
		private float startcooldown;

		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0x14E84A0", Offset = "0x14E84A0", VA = "0x14E84A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0x14E85B4", Offset = "0x14E85B4", VA = "0x14E85B4", Slot = "8")]
		protected override bool Validate(HitInfo info)
		{
			return default;
		}

		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x14E87E0", Offset = "0x14E87E0", VA = "0x14E87E0")]
		public ImpactUserGround()
		{
		}
	}
}
