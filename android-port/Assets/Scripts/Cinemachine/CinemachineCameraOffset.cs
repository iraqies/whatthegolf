using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
[ExecuteAlways]
public class CinemachineCameraOffset : CinemachineExtension
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_Offset;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x34")]
	public CinemachineCore.Stage m_ApplyAfter;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x38")]
	public bool m_PreserveComposition;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x18E7488", Offset = "0x18E7488", VA = "0x18E7488", Slot = "7")]
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x18E7620", Offset = "0x18E7620", VA = "0x18E7620")]
	public CinemachineCameraOffset()
	{
	}
}
