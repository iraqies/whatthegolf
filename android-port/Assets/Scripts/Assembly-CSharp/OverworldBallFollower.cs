using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AAD")]
public class OverworldBallFollower : MonoBehaviour
{
	[Token(Token = "0x4003B5F")]
	[FieldOffset(Offset = "0x18")]
	public bool isFollowing;

	[Token(Token = "0x4003B60")]
	[FieldOffset(Offset = "0x20")]
	private Transform target;

	[Token(Token = "0x4003B61")]
	[FieldOffset(Offset = "0x28")]
	public OverworldCamera camera;

	[Token(Token = "0x60032FC")]
	[Address(RVA = "0x15A37AC", Offset = "0x15A37AC", VA = "0x15A37AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60032FD")]
	[Address(RVA = "0x15A3AD0", Offset = "0x15A3AD0", VA = "0x15A3AD0")]
	private void Camera_OnPreLateUpdate()
	{
	}

	[Token(Token = "0x60032FE")]
	[Address(RVA = "0x15A3B30", Offset = "0x15A3B30", VA = "0x15A3B30")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x60032FF")]
	[Address(RVA = "0x15A3B6C", Offset = "0x15A3B6C", VA = "0x15A3B6C")]
	public void SetTarget(Transform target)
	{
	}

	[Token(Token = "0x6003300")]
	[Address(RVA = "0x15A3B74", Offset = "0x15A3B74", VA = "0x15A3B74")]
	public OverworldBallFollower()
	{
	}
}
