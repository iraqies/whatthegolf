using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000491")]
public class AntialisingQualityAdjuster : MonoBehaviour
{
	[Token(Token = "0x400182E")]
	[FieldOffset(Offset = "0x18")]
	private float _startTime;

	[Token(Token = "0x400182F")]
	[FieldOffset(Offset = "0x1C")]
	private float _endTime;

	[Token(Token = "0x4001830")]
	[FieldOffset(Offset = "0x20")]
	private int _startFrameCount;

	[Token(Token = "0x4001831")]
	[FieldOffset(Offset = "0x24")]
	private bool _started;

	[Token(Token = "0x4001832")]
	private const float MEASURE_DURATION = 2f;

	[Token(Token = "0x4001833")]
	private const float MEASURE_DELAY = 2f;

	[Token(Token = "0x4001834")]
	private const string QUALITY_MEASURED_KEY = "QUALITY_MEASURED";

	[Token(Token = "0x600152A")]
	[Address(RVA = "0x1418900", Offset = "0x1418900", VA = "0x1418900")]
	public void Init()
	{
	}

	[Token(Token = "0x600152B")]
	[Address(RVA = "0x1418A5C", Offset = "0x1418A5C", VA = "0x1418A5C")]
	public void OnLevelStarted(LevelData level)
	{
	}

	[Token(Token = "0x600152C")]
	[Address(RVA = "0x1418AA0", Offset = "0x1418AA0", VA = "0x1418AA0")]
	public void OnLevelEnded()
	{
	}

	[Token(Token = "0x600152D")]
	[Address(RVA = "0x1418AAC", Offset = "0x1418AAC", VA = "0x1418AAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600152E")]
	[Address(RVA = "0x1418E34", Offset = "0x1418E34", VA = "0x1418E34")]
	private void Deactivate()
	{
	}

	[Token(Token = "0x600152F")]
	[Address(RVA = "0x1418C60", Offset = "0x1418C60", VA = "0x1418C60")]
	private void LowerAntialisingIfNecessary(float fps)
	{
	}

	[Token(Token = "0x6001530")]
	[Address(RVA = "0x1419004", Offset = "0x1419004", VA = "0x1419004")]
	public AntialisingQualityAdjuster()
	{
	}

	[Token(Token = "0x6001531")]
	[Address(RVA = "0x141900C", Offset = "0x141900C", VA = "0x141900C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x622BC", Offset = "0x622BC")]
	private void _003CInit_003Eb__7_0()
	{
	}
}
