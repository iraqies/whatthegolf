using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CEC")]
public class FollowTransform : MonoBehaviour
{
	[Token(Token = "0x400463A")]
	[FieldOffset(Offset = "0x18")]
	public Transform Target;

	[Token(Token = "0x400463B")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 FollowAxis;

	[Token(Token = "0x400463C")]
	[FieldOffset(Offset = "0x2C")]
	public float FollowSpeed;

	[Token(Token = "0x400463D")]
	[FieldOffset(Offset = "0x30")]
	public bool UsePhysics;

	[Token(Token = "0x400463E")]
	[FieldOffset(Offset = "0x31")]
	public bool FollowUpVector;

	[Token(Token = "0x400463F")]
	[FieldOffset(Offset = "0x32")]
	public bool FollowRotation;

	[Token(Token = "0x4004640")]
	[FieldOffset(Offset = "0x33")]
	public bool TransformPositionOffset;

	[Token(Token = "0x4004641")]
	[FieldOffset(Offset = "0x34")]
	public bool InverseTransformPositionOffset;

	[Token(Token = "0x4004642")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 RotationOffset;

	[Token(Token = "0x4004643")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 PositionOffset;

	[Token(Token = "0x4004644")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 LookDirectionAxis;

	[Token(Token = "0x4004645")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2 HeightRange;

	[Token(Token = "0x4004646")]
	[FieldOffset(Offset = "0x68")]
	private Rigidbody rigid;

	[Token(Token = "0x4004647")]
	[FieldOffset(Offset = "0x70")]
	public float LookSpeed;

	[Token(Token = "0x4004648")]
	[FieldOffset(Offset = "0x74")]
	public bool LookAtTarget;

	[Token(Token = "0x6003D1D")]
	[Address(RVA = "0x147041C", Offset = "0x147041C", VA = "0x147041C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003D1E")]
	[Address(RVA = "0x1470478", Offset = "0x1470478", VA = "0x1470478")]
	public void ManualFollowUpdate()
	{
	}

	[Token(Token = "0x6003D1F")]
	[Address(RVA = "0x14706D0", Offset = "0x14706D0", VA = "0x14706D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6003D20")]
	[Address(RVA = "0x147048C", Offset = "0x147048C", VA = "0x147048C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003D21")]
	[Address(RVA = "0x1470888", Offset = "0x1470888", VA = "0x1470888")]
	private Vector3 GetPosition()
	{
		return default;
	}

	[Token(Token = "0x6003D22")]
	[Address(RVA = "0x1470C38", Offset = "0x1470C38", VA = "0x1470C38")]
	private Quaternion GetRotation()
	{
		return default;
	}

	[Token(Token = "0x6003D23")]
	[Address(RVA = "0x1470AD4", Offset = "0x1470AD4", VA = "0x1470AD4")]
	private Quaternion GetLookRotation()
	{
		return default;
	}

	[Token(Token = "0x6003D24")]
	[Address(RVA = "0x1470CBC", Offset = "0x1470CBC", VA = "0x1470CBC")]
	public FollowTransform()
	{
	}
}
