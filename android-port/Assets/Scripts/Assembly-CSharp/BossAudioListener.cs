using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000620")]
public class BossAudioListener : MonoBehaviour
{
	[Token(Token = "0x4001F9F")]
	[FieldOffset(Offset = "0x18")]
	public FinalBoss FinalBoss;

	[Token(Token = "0x4001FA0")]
	[FieldOffset(Offset = "0x20")]
	private GolfBallController currentController;

	[Token(Token = "0x4001FA1")]
	[FieldOffset(Offset = "0x28")]
	private bool foundController;

	[Token(Token = "0x6001BED")]
	[Address(RVA = "0x16FA194", Offset = "0x16FA194", VA = "0x16FA194")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001BEE")]
	[Address(RVA = "0x16FA198", Offset = "0x16FA198", VA = "0x16FA198")]
	private void OnStageStarted(BossStage bossStage)
	{
	}

	[Token(Token = "0x6001BEF")]
	[Address(RVA = "0x16FA2E8", Offset = "0x16FA2E8", VA = "0x16FA2E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0x16FA354", Offset = "0x16FA354", VA = "0x16FA354")]
	public BossAudioListener()
	{
	}
}
