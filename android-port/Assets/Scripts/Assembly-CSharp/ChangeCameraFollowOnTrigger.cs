using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000120")]
public class ChangeCameraFollowOnTrigger : MonoBehaviour
{
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x18")]
	public CameraManager Manager;

	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController OtherBall;

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x189635C", Offset = "0x189635C", VA = "0x189635C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x18964C8", Offset = "0x18964C8", VA = "0x18964C8")]
	public ChangeCameraFollowOnTrigger()
	{
	}
}
