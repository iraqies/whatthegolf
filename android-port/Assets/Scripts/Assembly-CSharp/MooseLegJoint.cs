using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200003E")]
public class MooseLegJoint : MonoBehaviour
{
	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Axis;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x28")]
	public HingeJoint Joint;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x30")]
	public float RunSpeed;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x34")]
	public float StartOffset;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 AngleRange;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x40")]
	private float timer;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x44")]
	private JointMotor motor;

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x156F704", Offset = "0x156F704", VA = "0x156F704")]
	public void UpdateJoint(float speed)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x156EB48", Offset = "0x156EB48", VA = "0x156EB48")]
	public void Toggle(bool state)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x156EB08", Offset = "0x156EB08", VA = "0x156EB08")]
	public void Init()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x156F98C", Offset = "0x156F98C", VA = "0x156F98C")]
	public MooseLegJoint()
	{
	}
}
