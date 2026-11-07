using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000440")]
public class ChallengeAIRoller : MonoBehaviour
{
	[Token(Token = "0x4001736")]
	[FieldOffset(Offset = "0x18")]
	public Transform chaseTarget;

	[Token(Token = "0x4001737")]
	[FieldOffset(Offset = "0x20")]
	private RollingCowShooter _rollingCowShooter;

	[Token(Token = "0x4001738")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 _oldTargetDirection;

	[Token(Token = "0x4001739")]
	[FieldOffset(Offset = "0x34")]
	public float aimSpeed;

	[Token(Token = "0x400173A")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4D67C", Offset = "0x4D67C")]
	public float lookDistance;

	[Token(Token = "0x400173B")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool DisableKinematicOnEnable;

	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x1892538", Offset = "0x1892538", VA = "0x1892538")]
	private void Start()
	{
	}

	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x1892594", Offset = "0x1892594", VA = "0x1892594")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x1892630", Offset = "0x1892630", VA = "0x1892630")]
	private void Update()
	{
	}

	[Token(Token = "0x60013FE")]
	[Address(RVA = "0x18927D8", Offset = "0x18927D8", VA = "0x18927D8")]
	public ChallengeAIRoller()
	{
	}
}
