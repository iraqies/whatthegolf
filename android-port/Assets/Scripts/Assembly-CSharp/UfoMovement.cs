using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200088F")]
public class UfoMovement : MonoBehaviour
{
	[Token(Token = "0x4002EFB")]
	[FieldOffset(Offset = "0x18")]
	public float FlightHeight;

	[Token(Token = "0x4002EFC")]
	[FieldOffset(Offset = "0x1C")]
	public float MaxShipRotation;

	[Token(Token = "0x4002EFD")]
	[FieldOffset(Offset = "0x20")]
	public float ShipRotationSpeed;

	[Token(Token = "0x4002EFE")]
	[FieldOffset(Offset = "0x24")]
	public float HoverSpeed;

	[Token(Token = "0x4002EFF")]
	[FieldOffset(Offset = "0x28")]
	private ConstantForce constForce;

	[Token(Token = "0x4002F00")]
	[FieldOffset(Offset = "0x30")]
	private float hoverMod;

	[Token(Token = "0x4002F01")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 targetRot;

	[Token(Token = "0x4002F02")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody rigidbodyC;

	[Token(Token = "0x6002788")]
	[Address(RVA = "0x1738984", Offset = "0x1738984", VA = "0x1738984")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6002789")]
	[Address(RVA = "0x1738A04", Offset = "0x1738A04", VA = "0x1738A04")]
	private void Update()
	{
	}

	[Token(Token = "0x600278A")]
	[Address(RVA = "0x1738CB8", Offset = "0x1738CB8", VA = "0x1738CB8")]
	public UfoMovement()
	{
	}
}
