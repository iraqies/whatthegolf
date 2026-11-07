using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000367")]
public class ChangeCameraAngle : MonoBehaviour
{
	[Token(Token = "0x40012B1")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 posOffset;

	[Token(Token = "0x40012B2")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 newRotation;

	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0x30")]
	public Transform target;

	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0x38")]
	private bool move;

	[Token(Token = "0x6000FC1")]
	[Address(RVA = "0x1896184", Offset = "0x1896184", VA = "0x1896184")]
	public void StartMovement()
	{
	}

	[Token(Token = "0x6000FC2")]
	[Address(RVA = "0x1896190", Offset = "0x1896190", VA = "0x1896190")]
	private void Update()
	{
	}

	[Token(Token = "0x6000FC3")]
	[Address(RVA = "0x1896354", Offset = "0x1896354", VA = "0x1896354")]
	public ChangeCameraAngle()
	{
	}
}
