using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D6")]
public class DollyCartSpeedManager : MonoBehaviour
{
	[Token(Token = "0x4000F89")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform Follower;

	[Token(Token = "0x4000F8A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float FollowThreshold;

	[Token(Token = "0x4000F8B")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool useDistance;

	[Token(Token = "0x4000F8C")]
	[FieldOffset(Offset = "0x28")]
	private float dollySpeed;

	[Token(Token = "0x4000F8D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CinemachineDollyCart dolly;

	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x1430588", Offset = "0x1430588", VA = "0x1430588")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x14305A8", Offset = "0x14305A8", VA = "0x14305A8")]
	internal void SetNewFollower(Transform newCamFollow)
	{
	}

	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x14305B0", Offset = "0x14305B0", VA = "0x14305B0")]
	public void SetNewSpeed(float s)
	{
	}

	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x14305D0", Offset = "0x14305D0", VA = "0x14305D0")]
	public DollyCartSpeedManager()
	{
	}
}
