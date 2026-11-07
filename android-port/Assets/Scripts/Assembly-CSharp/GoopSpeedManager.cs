using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D88")]
public class GoopSpeedManager : MonoBehaviour
{
	[Token(Token = "0x4004994")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform Follower;

	[Token(Token = "0x4004995")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float FollowThreshold;

	[Token(Token = "0x4004996")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool useDistance;

	[Token(Token = "0x4004997")]
	[FieldOffset(Offset = "0x28")]
	private float dollySpeed;

	[Token(Token = "0x4004998")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CinemachineDollyCart dolly;

	[Token(Token = "0x6003F99")]
	[Address(RVA = "0x14AE750", Offset = "0x14AE750", VA = "0x14AE750")]
	private void Start()
	{
	}

	[Token(Token = "0x6003F9A")]
	[Address(RVA = "0x14AE770", Offset = "0x14AE770", VA = "0x14AE770")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003F9B")]
	[Address(RVA = "0x14AE834", Offset = "0x14AE834", VA = "0x14AE834")]
	public GoopSpeedManager()
	{
	}
}
