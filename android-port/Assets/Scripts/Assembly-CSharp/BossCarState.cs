using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000622")]
public class BossCarState : MonoBehaviour
{
	[Token(Token = "0x2000623")]
	public enum CarStateEnum
	{
		[Token(Token = "0x4001FAB")]
		Driving = 0,
		[Token(Token = "0x4001FAC")]
		Flying = 1,
		[Token(Token = "0x4001FAD")]
		Resetting = 2
	}

	[Token(Token = "0x4001FA5")]
	[FieldOffset(Offset = "0x18")]
	public CarStateEnum CarState;

	[Token(Token = "0x4001FA6")]
	[FieldOffset(Offset = "0x20")]
	public Animator BossMonitorAnimator;

	[Token(Token = "0x4001FA7")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem[] WheelParticles;

	[Token(Token = "0x4001FA8")]
	[FieldOffset(Offset = "0x30")]
	public BossStage Stage;

	[Token(Token = "0x4001FA9")]
	[FieldOffset(Offset = "0x38")]
	public List<BossWheels> Wheels;

	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0x16FBEE0", Offset = "0x16FBEE0", VA = "0x16FBEE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0x16FC090", Offset = "0x16FC090", VA = "0x16FC090")]
	private void OnChallengeEnd()
	{
	}

	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x16FC094", Offset = "0x16FC094", VA = "0x16FC094")]
	private void OnChallengeBegin()
	{
	}

	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0x16FC09C", Offset = "0x16FC09C", VA = "0x16FC09C")]
	public void SetState(CarStateEnum state)
	{
	}

	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x16FC3E8", Offset = "0x16FC3E8", VA = "0x16FC3E8")]
	public BossCarState()
	{
	}
}
