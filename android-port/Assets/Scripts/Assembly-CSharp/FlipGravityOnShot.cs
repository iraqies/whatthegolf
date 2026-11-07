using System.Collections.Generic;
using Il2CppDummyDll;
using Menu;
using UnityEngine;

[Token(Token = "0x2000BEA")]
public class FlipGravityOnShot : MonoBehaviour
{
	[Token(Token = "0x40041FD")]
	[FieldOffset(Offset = "0x18")]
	public Transform RoomFollow;

	[Token(Token = "0x40041FE")]
	[FieldOffset(Offset = "0x20")]
	private ConstantForce2D[] constantForces;

	[Token(Token = "0x40041FF")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<Rigidbody2D, ResetInfo2D> savedResetInfo;

	[Token(Token = "0x4004200")]
	[FieldOffset(Offset = "0x30")]
	private bool savedGravity;

	[Token(Token = "0x4004201")]
	[FieldOffset(Offset = "0x31")]
	private bool inverseGravity;

	[Token(Token = "0x4004202")]
	[FieldOffset(Offset = "0x38")]
	private InGameMenu menu;

	[Token(Token = "0x4004203")]
	[FieldOffset(Offset = "0x40")]
	private bool savePosition;

	[Token(Token = "0x600391C")]
	[Address(RVA = "0x146C56C", Offset = "0x146C56C", VA = "0x146C56C")]
	private void Start()
	{
	}

	[Token(Token = "0x600391D")]
	[Address(RVA = "0x146C7C0", Offset = "0x146C7C0", VA = "0x146C7C0")]
	private void InstanceOnOnGolfStroke(Vector3 i)
	{
	}

	[Token(Token = "0x600391E")]
	[Address(RVA = "0x146CAA0", Offset = "0x146CAA0", VA = "0x146CAA0")]
	public void SetRoomPosition(Transform room)
	{
	}

	[Token(Token = "0x600391F")]
	[Address(RVA = "0x146CB08", Offset = "0x146CB08", VA = "0x146CB08")]
	public void ResetAtCurrentScreen()
	{
	}

	[Token(Token = "0x6003920")]
	[Address(RVA = "0x146C9AC", Offset = "0x146C9AC", VA = "0x146C9AC")]
	private void FlipGravity()
	{
	}

	[Token(Token = "0x6003921")]
	[Address(RVA = "0x146CE74", Offset = "0x146CE74", VA = "0x146CE74")]
	public FlipGravityOnShot()
	{
	}
}
