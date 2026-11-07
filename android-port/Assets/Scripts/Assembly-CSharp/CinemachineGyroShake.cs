using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000333")]
[ExecuteInEditMode]
public class CinemachineGyroShake : CinemachineExtension
{
	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_RotationMagnitude;

	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float m_xMagnitude;

	[Token(Token = "0x40011BA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_yMagnitude;

	[Token(Token = "0x40011BB")]
	[FieldOffset(Offset = "0x34")]
	private float adjustmentMagnitude;

	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0x38")]
	private float perLevelMagnitude;

	[Token(Token = "0x40011BD")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsActive;

	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x189DC30", Offset = "0x189DC30", VA = "0x189DC30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0x189DD64", Offset = "0x189DD64", VA = "0x189DD64", Slot = "7")]
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}

	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x189DF18", Offset = "0x189DF18", VA = "0x189DF18")]
	public CinemachineGyroShake()
	{
	}
}
