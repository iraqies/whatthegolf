using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000994")]
public class OverworldBoatCameraBlender : MonoBehaviour
{
	[Token(Token = "0x40034CC")]
	[FieldOffset(Offset = "0x18")]
	public OverworldCameraSettings boatCameraSettings;

	[Token(Token = "0x40034CD")]
	[FieldOffset(Offset = "0x20")]
	private Coroutine current;

	[Token(Token = "0x40034CE")]
	[FieldOffset(Offset = "0x28")]
	private bool isInBoatMode;

	[Token(Token = "0x6002CE5")]
	[Address(RVA = "0x15A5DD8", Offset = "0x15A5DD8", VA = "0x15A5DD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002CE6")]
	[Address(RVA = "0x15A606C", Offset = "0x15A606C", VA = "0x15A606C")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES shape)
	{
	}

	[Token(Token = "0x6002CE7")]
	[Address(RVA = "0x15A5F30", Offset = "0x15A5F30", VA = "0x15A5F30")]
	private void CheckBoatMode(Transmogrif.BALLSHAPES shape)
	{
	}

	[Token(Token = "0x6002CE8")]
	[Address(RVA = "0x15A6070", Offset = "0x15A6070", VA = "0x15A6070")]
	public OverworldBoatCameraBlender()
	{
	}

	[Token(Token = "0x6002CE9")]
	[Address(RVA = "0x15A6078", Offset = "0x15A6078", VA = "0x15A6078")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68294", Offset = "0x68294")]
	private void _003CCheckBoatMode_003Eb__5_0(float t)
	{
	}

	[Token(Token = "0x6002CEA")]
	[Address(RVA = "0x15A60AC", Offset = "0x15A60AC", VA = "0x15A60AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A4", Offset = "0x682A4")]
	private void _003CCheckBoatMode_003Eb__5_1(float t)
	{
	}
}
