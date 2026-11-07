using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x20002C6")]
public class PuppetKnockawayRigidbodiesOnGetup : MonoBehaviour
{
	[Token(Token = "0x4000F2C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BehaviourPuppet puppet;

	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BehaviourFall fallBehaviour;

	[Token(Token = "0x4000F2E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float radius;

	[Token(Token = "0x4000F2F")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private LayerMask layerMask;

	[Token(Token = "0x4000F30")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float startAfterTime;

	[Token(Token = "0x4000F31")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float knockAwayForce;

	[Token(Token = "0x4000F32")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float upwardModifier;

	[Token(Token = "0x4000F33")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private ForceMode forceMode;

	[Token(Token = "0x4000F34")]
	[FieldOffset(Offset = "0x40")]
	private float timeInUnpinnedOrGetupState;

	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x162C3C0", Offset = "0x162C3C0", VA = "0x162C3C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x162C654", Offset = "0x162C654", VA = "0x162C654")]
	private void OnPostMuscleCollision(MuscleCollision collision)
	{
	}

	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x162C720", Offset = "0x162C720", VA = "0x162C720")]
	private void OnPostMuscleHitInFall(MuscleHit hit)
	{
	}

	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x162C724", Offset = "0x162C724", VA = "0x162C724")]
	private void OnLoseBalance()
	{
	}

	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0x162C728", Offset = "0x162C728", VA = "0x162C728")]
	private void OnLoseBalanceFromGetup()
	{
	}

	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x162C79C", Offset = "0x162C79C", VA = "0x162C79C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0x162C818", Offset = "0x162C818", VA = "0x162C818")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x162C868", Offset = "0x162C868", VA = "0x162C868")]
	public PuppetKnockawayRigidbodiesOnGetup()
	{
	}
}
