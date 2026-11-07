using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000348")]
[Attribute(Name = "RequireComponent", RVA = "0x3F148", Offset = "0x3F148")]
public class FollowTransformUtility : MonoBehaviour
{
	[Token(Token = "0x4001221")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Transform Target;

	[Token(Token = "0x4001222")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool ignoreY;

	[Token(Token = "0x4001223")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool moveRigidWithVelocity;

	[Token(Token = "0x4001224")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float FollowSpeed;

	[Token(Token = "0x4001225")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float FollowDistance;

	[Token(Token = "0x4001226")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x1470CE8", Offset = "0x1470CE8", VA = "0x1470CE8")]
	public void SetFollowDistance(int d)
	{
	}

	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x1470CF4", Offset = "0x1470CF4", VA = "0x1470CF4")]
	public void SetFollowTransform(Transform t)
	{
	}

	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0x1470CFC", Offset = "0x1470CFC", VA = "0x1470CFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0x1470D58", Offset = "0x1470D58", VA = "0x1470D58")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0x1470EE0", Offset = "0x1470EE0", VA = "0x1470EE0")]
	private Vector3 GetPosition()
	{
		return default;
	}

	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x1471014", Offset = "0x1471014", VA = "0x1471014")]
	public FollowTransformUtility()
	{
	}
}
