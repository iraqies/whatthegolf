using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000933")]
public class ChangeOverworldMusicZone : OverworldMusicChanger
{
	[Token(Token = "0x400322E")]
	[FieldOffset(Offset = "0x20")]
	public OverworldMusicData music;

	[Token(Token = "0x400322F")]
	[FieldOffset(Offset = "0x28")]
	public bool requireBallType;

	[Token(Token = "0x4003230")]
	[FieldOffset(Offset = "0x2C")]
	public Transmogrif.BALLSHAPES ballShape;

	[Token(Token = "0x4003231")]
	[FieldOffset(Offset = "0x30")]
	public List<GameObject> FlagContainers;

	[Token(Token = "0x4003232")]
	[FieldOffset(Offset = "0x38")]
	private List<OverworldGoal> flags;

	[Token(Token = "0x6002A9B")]
	[Address(RVA = "0x1897768", Offset = "0x1897768", VA = "0x1897768", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6002A9C")]
	[Address(RVA = "0x1897CF4", Offset = "0x1897CF4", VA = "0x1897CF4")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6002A9D")]
	[Address(RVA = "0x1897E88", Offset = "0x1897E88", VA = "0x1897E88")]
	public ChangeOverworldMusicZone()
	{
	}
}
