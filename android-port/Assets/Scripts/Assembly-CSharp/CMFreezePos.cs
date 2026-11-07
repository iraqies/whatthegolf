using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200022A")]
[ExecuteInEditMode]
public class CMFreezePos : CinemachineExtension
{
	[Token(Token = "0x4000B09")]
	[FieldOffset(Offset = "0x28")]
	public bool continious;

	[Token(Token = "0x4000B0A")]
	[FieldOffset(Offset = "0x29")]
	public bool lockX;

	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x2C")]
	public float xPosition;

	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0x30")]
	public bool lockY;

	[Token(Token = "0x4000B0D")]
	[FieldOffset(Offset = "0x34")]
	public float yPosition;

	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0x38")]
	public bool lockZ;

	[Token(Token = "0x4000B0F")]
	[FieldOffset(Offset = "0x3C")]
	public float zPosition;

	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x17E380C", Offset = "0x17E380C", VA = "0x17E380C", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x17E3888", Offset = "0x17E3888", VA = "0x17E3888")]
	public void Lock(bool b)
	{
	}

	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x17E3898", Offset = "0x17E3898", VA = "0x17E3898", Slot = "7")]
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}

	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x17E3914", Offset = "0x17E3914", VA = "0x17E3914")]
	public CMFreezePos()
	{
	}
}
