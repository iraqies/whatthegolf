using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200135D")]
	public class ImpactRagdollUser : ImpactUser
	{
		[Token(Token = "0x40067A8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LimbGroupType limbGroupType;

		[Token(Token = "0x40067A9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RagdollLimbSettings ragdollSettings;

		[Token(Token = "0x40067AA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool useCooldownFromShot;

		[Token(Token = "0x40067AB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GolfBallController controller;

		[Token(Token = "0x40067AC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float cooldown;

		[Token(Token = "0x40067AD")]
		[FieldOffset(Offset = "0x64")]
		private float lastShotTime;

		[Token(Token = "0x6005A52")]
		[Address(RVA = "0x14E7758", Offset = "0x14E7758", VA = "0x14E7758")]
		private void Start()
		{
		}

		[Token(Token = "0x6005A53")]
		[Address(RVA = "0x14E7A1C", Offset = "0x14E7A1C", VA = "0x14E7A1C")]
		private void Controller_OnPreShoot(Vector3 obj)
		{
		}

		[Token(Token = "0x6005A54")]
		[Address(RVA = "0x14E7A44", Offset = "0x14E7A44", VA = "0x14E7A44", Slot = "8")]
		protected override bool Validate(HitInfo info)
		{
			return default;
		}

		[Token(Token = "0x6005A55")]
		[Address(RVA = "0x14E7AEC", Offset = "0x14E7AEC", VA = "0x14E7AEC")]
		public ImpactRagdollUser()
		{
		}
	}
}
