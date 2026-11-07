using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000997")]
public class OverworldEndBallCameraBlender : GolfBehaviour
{
	[Token(Token = "0x40034D5")]
	[FieldOffset(Offset = "0x20")]
	public OverworldCameraSettings endCameraSettings;

	[Token(Token = "0x40034D6")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine current;

	[Token(Token = "0x40034D7")]
	[FieldOffset(Offset = "0x30")]
	public Color baseBackground;

	[Token(Token = "0x40034D8")]
	[FieldOffset(Offset = "0x40")]
	public Color endBackground;

	[Token(Token = "0x40034D9")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer backgroundRenderer;

	[Token(Token = "0x40034DA")]
	[FieldOffset(Offset = "0x58")]
	private Coroutine currentColor;

	[Token(Token = "0x40034DB")]
	[FieldOffset(Offset = "0x60")]
	private bool isInEndMode;

	[Token(Token = "0x6002CF9")]
	[Address(RVA = "0x15B4A50", Offset = "0x15B4A50", VA = "0x15B4A50", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002CFA")]
	[Address(RVA = "0x15B4A58", Offset = "0x15B4A58", VA = "0x15B4A58")]
	private void Start()
	{
	}

	[Token(Token = "0x6002CFB")]
	[Address(RVA = "0x15B4D74", Offset = "0x15B4D74", VA = "0x15B4D74")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES shape)
	{
	}

	[Token(Token = "0x6002CFC")]
	[Address(RVA = "0x15B4B54", Offset = "0x15B4B54", VA = "0x15B4B54")]
	private void CheckEndMode(Transmogrif.BALLSHAPES shape)
	{
	}

	[Token(Token = "0x6002CFD")]
	[Address(RVA = "0x15B4D78", Offset = "0x15B4D78", VA = "0x15B4D78")]
	public OverworldEndBallCameraBlender()
	{
	}

	[Token(Token = "0x6002CFE")]
	[Address(RVA = "0x15B4D80", Offset = "0x15B4D80", VA = "0x15B4D80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68324", Offset = "0x68324")]
	private void _003CCheckEndMode_003Eb__10_0(float t)
	{
	}

	[Token(Token = "0x6002CFF")]
	[Address(RVA = "0x15B4E04", Offset = "0x15B4E04", VA = "0x15B4E04")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68334", Offset = "0x68334")]
	private void _003CCheckEndMode_003Eb__10_1(float t)
	{
	}

	[Token(Token = "0x6002D00")]
	[Address(RVA = "0x15B4E9C", Offset = "0x15B4E9C", VA = "0x15B4E9C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68344", Offset = "0x68344")]
	private void _003CCheckEndMode_003Eb__10_2(float t)
	{
	}

	[Token(Token = "0x6002D01")]
	[Address(RVA = "0x15B4F28", Offset = "0x15B4F28", VA = "0x15B4F28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68354", Offset = "0x68354")]
	private void _003CCheckEndMode_003Eb__10_3(float t)
	{
	}
}
