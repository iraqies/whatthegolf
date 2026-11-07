using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006F5")]
public class FPGHelper : MonoBehaviour
{
	[Token(Token = "0x4002485")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string downHelp;

	[Token(Token = "0x4002486")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x4E6B4", Offset = "0x4E6B4")]
	private float threshold;

	[Token(Token = "0x4002487")]
	[FieldOffset(Offset = "0x28")]
	private CBPerspecitveGyroscope gyro;

	[Token(Token = "0x4002488")]
	[FieldOffset(Offset = "0x30")]
	private GolfBallController controller;

	[Token(Token = "0x4002489")]
	[FieldOffset(Offset = "0x38")]
	private bool levelWon;

	[Token(Token = "0x400248A")]
	[FieldOffset(Offset = "0x3C")]
	private float warmup;

	[Token(Token = "0x6002019")]
	[Address(RVA = "0x14590E4", Offset = "0x14590E4", VA = "0x14590E4")]
	public void Init(CBPerspecitveGyroscope camBehaviour, GolfBallController controller)
	{
	}

	[Token(Token = "0x600201A")]
	[Address(RVA = "0x1459228", Offset = "0x1459228", VA = "0x1459228")]
	private void Update()
	{
	}

	[Token(Token = "0x600201B")]
	[Address(RVA = "0x14593CC", Offset = "0x14593CC", VA = "0x14593CC")]
	public FPGHelper()
	{
	}

	[Token(Token = "0x600201C")]
	[Address(RVA = "0x14593DC", Offset = "0x14593DC", VA = "0x14593DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x658B8", Offset = "0x658B8")]
	private void _003CInit_003Eb__6_0(Level.CompletedState s)
	{
	}
}
