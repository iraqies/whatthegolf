using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F0A")]
public class DPIApplyForce : BaseDailyPrizeInteractions
{
	[Token(Token = "0x4005123")]
	[FieldOffset(Offset = "0x22")]
	[SerializeField]
	private bool UseDirection;

	[Token(Token = "0x4005124")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform TowardsSomewhere;

	[Token(Token = "0x4005125")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody rigidBody;

	[Token(Token = "0x4005126")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float multiply;

	[Token(Token = "0x4005127")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float randomTorque;

	[Token(Token = "0x4005128")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 defaultVectorIfZero;

	[Token(Token = "0x6004650")]
	[Address(RVA = "0x18C7B34", Offset = "0x18C7B34", VA = "0x18C7B34", Slot = "8")]
	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x6004651")]
	[Address(RVA = "0x18C7D50", Offset = "0x18C7D50", VA = "0x18C7D50")]
	private float RandomTourqueFloat(Vector3 b)
	{
		return default;
	}

	[Token(Token = "0x6004652")]
	[Address(RVA = "0x18C7DA0", Offset = "0x18C7DA0", VA = "0x18C7DA0", Slot = "6")]
	public override void OnAimNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x6004653")]
	[Address(RVA = "0x18C7C94", Offset = "0x18C7C94", VA = "0x18C7C94")]
	private Vector3 GetDir(Vector3 b)
	{
		return default;
	}

	[Token(Token = "0x6004654")]
	[Address(RVA = "0x18C7E48", Offset = "0x18C7E48", VA = "0x18C7E48")]
	public DPIApplyForce()
	{
	}
}
