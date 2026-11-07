using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BA")]
public class GolfAudioManager : MonoBehaviour
{
	[Token(Token = "0x4001490")]
	[FieldOffset(Offset = "0x18")]
	private GolfPullAudioHandler activePull;

	[Token(Token = "0x4001491")]
	[FieldOffset(Offset = "0x20")]
	private List<GolfPullAudioHandler> multiplayerPulls;

	[Token(Token = "0x4001492")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController overworldBall;

	[Token(Token = "0x4001493")]
	[FieldOffset(Offset = "0x30")]
	public GolfPullAudioHandler defaultPull;

	[Token(Token = "0x4001494")]
	[FieldOffset(Offset = "0x38")]
	private Level currentLevel;

	[Token(Token = "0x4001495")]
	[FieldOffset(Offset = "0x40")]
	private bool initialized;

	[Token(Token = "0x4001496")]
	[FieldOffset(Offset = "0x44")]
	private float nextCheckTime;

	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x148F01C", Offset = "0x148F01C", VA = "0x148F01C")]
	public void SetOverworldBall(GolfBallController controller)
	{
	}

	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x148F0CC", Offset = "0x148F0CC", VA = "0x148F0CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x148F0D0", Offset = "0x148F0D0", VA = "0x148F0D0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x148F3A4", Offset = "0x148F3A4", VA = "0x148F3A4")]
	public void OnLevelDesignerReset()
	{
	}

	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x148F448", Offset = "0x148F448", VA = "0x148F448")]
	private void OnNewOverworldBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x148F514", Offset = "0x148F514", VA = "0x148F514")]
	public void InitializeNewScene()
	{
	}

	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x148FA60", Offset = "0x148FA60", VA = "0x148FA60")]
	public void AddMultiplayerPull(GolfBallController controller)
	{
	}

	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x148FB8C", Offset = "0x148FB8C", VA = "0x148FB8C")]
	public void RemoveMultiplayerPull(GolfBallController controller)
	{
	}

	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x148FDB0", Offset = "0x148FDB0", VA = "0x148FDB0")]
	public void OnLevelWillUnload()
	{
	}

	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x148FDEC", Offset = "0x148FDEC", VA = "0x148FDEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x1490050", Offset = "0x1490050", VA = "0x1490050")]
	private bool ValidBall(GolfBallController ball)
	{
		return default;
	}

	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x148F26C", Offset = "0x148F26C", VA = "0x148F26C")]
	private void NewPull(GolfPullAudioHandler newPull)
	{
	}

	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x14900F4", Offset = "0x14900F4", VA = "0x14900F4")]
	public GolfAudioManager()
	{
	}
}
