using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000105")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x13003D4", Offset = "0x13003D4", VA = "0x13003D4", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x13003F8", Offset = "0x13003F8", VA = "0x13003F8", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x13003FC", Offset = "0x13003FC", VA = "0x13003FC", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1300400", Offset = "0x1300400", VA = "0x1300400", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1300404", Offset = "0x1300404", VA = "0x1300404", Slot = "18")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1300440", Offset = "0x1300440", VA = "0x1300440", Slot = "20")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1300444", Offset = "0x1300444", VA = "0x1300444", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x130044C", Offset = "0x130044C", VA = "0x130044C", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1300454", Offset = "0x1300454", VA = "0x1300454")]
		public BehaviourTemplate()
		{
		}
	}
}
