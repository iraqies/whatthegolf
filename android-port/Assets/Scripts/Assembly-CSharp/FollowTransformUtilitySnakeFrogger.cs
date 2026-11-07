using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D7B")]
[Attribute(Name = "RequireComponent", RVA = "0x44A00", Offset = "0x44A00")]
public class FollowTransformUtilitySnakeFrogger : MonoBehaviour
{
	[Token(Token = "0x4004952")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Transform Target;

	[Token(Token = "0x4004953")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool ignoreY;

	[Token(Token = "0x4004954")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool moveRigidWithVelocity;

	[Token(Token = "0x4004955")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float FollowSpeed;

	[Token(Token = "0x4004956")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float FollowDistance;

	[Token(Token = "0x4004957")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x4004958")]
	[FieldOffset(Offset = "0x38")]
	private Transform previousChild;

	[Token(Token = "0x4004959")]
	[FieldOffset(Offset = "0x40")]
	private bool isDestroyed;

	[Token(Token = "0x6003F66")]
	[Address(RVA = "0x147102C", Offset = "0x147102C", VA = "0x147102C")]
	public void SetFollowDistance(int d)
	{
	}

	[Token(Token = "0x6003F67")]
	[Address(RVA = "0x1471038", Offset = "0x1471038", VA = "0x1471038")]
	public void SetFollowTransform(Transform t)
	{
	}

	[Token(Token = "0x6003F68")]
	[Address(RVA = "0x1471040", Offset = "0x1471040", VA = "0x1471040")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003F69")]
	[Address(RVA = "0x147109C", Offset = "0x147109C", VA = "0x147109C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003F6A")]
	[Address(RVA = "0x1471368", Offset = "0x1471368", VA = "0x1471368")]
	private Vector3 GetPosition()
	{
		return default;
	}

	[Token(Token = "0x6003F6B")]
	[Address(RVA = "0x147149C", Offset = "0x147149C", VA = "0x147149C")]
	public FollowTransformUtilitySnakeFrogger()
	{
	}
}
