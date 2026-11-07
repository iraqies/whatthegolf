using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003F6")]
public class GyroShake : MonoBehaviour
{
	[Token(Token = "0x400159A")]
	[FieldOffset(Offset = "0x18")]
	private float rotationMagnitude;

	[Token(Token = "0x400159B")]
	[FieldOffset(Offset = "0x1C")]
	private float xMagnitude;

	[Token(Token = "0x400159C")]
	[FieldOffset(Offset = "0x20")]
	private float yMagnitude;

	[Token(Token = "0x400159D")]
	[FieldOffset(Offset = "0x24")]
	public float perLevelMagnitude;

	[Token(Token = "0x400159E")]
	[FieldOffset(Offset = "0x28")]
	private float adjustmentMagnitude;

	[Token(Token = "0x6001295")]
	[Address(RVA = "0x14C0894", Offset = "0x14C0894", VA = "0x14C0894")]
	public void Init(CameraManager cameraManager)
	{
	}

	[Token(Token = "0x6001296")]
	[Address(RVA = "0x14C0A44", Offset = "0x14C0A44", VA = "0x14C0A44")]
	private void Update()
	{
	}

	[Token(Token = "0x6001297")]
	[Address(RVA = "0x14C0BF4", Offset = "0x14C0BF4", VA = "0x14C0BF4")]
	public GyroShake()
	{
	}
}
