using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003F0")]
public class CBTightFollow : CameraBehaviorPerspective
{
	[Token(Token = "0x4001584")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 offset;

	[Token(Token = "0x4001585")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Vector3 rotation;

	[Token(Token = "0x4001586")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool useBallForward;

	[Token(Token = "0x600127B")]
	[Address(RVA = "0x17E3478", Offset = "0x17E3478", VA = "0x17E3478", Slot = "7")]
	public override Quaternion CalculateRotation()
	{
		return default;
	}

	[Token(Token = "0x600127C")]
	[Address(RVA = "0x17E34CC", Offset = "0x17E34CC", VA = "0x17E34CC", Slot = "8")]
	protected override Vector3 CalculatePosition()
	{
		return default;
	}

	[Token(Token = "0x600127D")]
	[Address(RVA = "0x17E3610", Offset = "0x17E3610", VA = "0x17E3610")]
	public CBTightFollow()
	{
	}
}
