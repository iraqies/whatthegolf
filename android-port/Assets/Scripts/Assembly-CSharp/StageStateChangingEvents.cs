using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20006A4")]
public class StageStateChangingEvents : MonoBehaviour
{
	[Token(Token = "0x40022B9")]
	[FieldOffset(Offset = "0x18")]
	public FinalBoss FinalBoss;

	[Token(Token = "0x40022BA")]
	[FieldOffset(Offset = "0x20")]
	public BossStage OnlyOnThisStage;

	[Token(Token = "0x40022BB")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent StageBeginning;

	[Token(Token = "0x40022BC")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent StageEnding;

	[Token(Token = "0x6001E81")]
	[Address(RVA = "0x16DA2AC", Offset = "0x16DA2AC", VA = "0x16DA2AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001E82")]
	[Address(RVA = "0x16DA400", Offset = "0x16DA400", VA = "0x16DA400")]
	private void OnStageStarted(BossStage bossStage)
	{
	}

	[Token(Token = "0x6001E83")]
	[Address(RVA = "0x16DA574", Offset = "0x16DA574", VA = "0x16DA574")]
	private void OnStageEnding(BossStage bossStage)
	{
	}

	[Token(Token = "0x6001E84")]
	[Address(RVA = "0x16DA654", Offset = "0x16DA654", VA = "0x16DA654")]
	public StageStateChangingEvents()
	{
	}

	[Token(Token = "0x6001E85")]
	[Address(RVA = "0x16DA65C", Offset = "0x16DA65C", VA = "0x16DA65C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x64FAC", Offset = "0x64FAC")]
	private void _003COnStageStarted_003Eb__5_0()
	{
	}

	[Token(Token = "0x6001E86")]
	[Address(RVA = "0x16DA678", Offset = "0x16DA678", VA = "0x16DA678")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x64FBC", Offset = "0x64FBC")]
	private void _003COnStageStarted_003Eb__5_1()
	{
	}
}
