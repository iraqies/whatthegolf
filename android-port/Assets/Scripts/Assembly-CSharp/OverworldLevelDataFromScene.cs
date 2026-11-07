using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004C7")]
public class OverworldLevelDataFromScene : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20004C8")]
	public class SectionData
	{
		[Token(Token = "0x40018FD")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40018FE")]
		[FieldOffset(Offset = "0x18")]
		public string number;

		[Token(Token = "0x40018FF")]
		[FieldOffset(Offset = "0x20")]
		public List<GameObject> sections;

		[Token(Token = "0x4001900")]
		[FieldOffset(Offset = "0x28")]
		public Transmogrif.BALLSHAPES ballShape;

		[Token(Token = "0x4001901")]
		[FieldOffset(Offset = "0x30")]
		public OverworldID unlockTrigger;

		[Token(Token = "0x6001602")]
		[Address(RVA = "0x181262C", Offset = "0x181262C", VA = "0x181262C")]
		public SectionData()
		{
		}
	}

	[Token(Token = "0x40018FC")]
	[FieldOffset(Offset = "0x18")]
	public List<SectionData> sections;

	[Token(Token = "0x6001601")]
	[Address(RVA = "0x15BAC18", Offset = "0x15BAC18", VA = "0x15BAC18")]
	public OverworldLevelDataFromScene()
	{
	}
}
