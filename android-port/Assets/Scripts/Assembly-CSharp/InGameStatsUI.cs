using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x20008E1")]
public class InGameStatsUI : MonoBehaviour
{
	[Token(Token = "0x400309A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform parStrokesTransform;

	[Token(Token = "0x400309B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI parStrokesText;

	[Token(Token = "0x400309C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform catsCountTransform;

	[Token(Token = "0x400309D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float spacing;

	[Token(Token = "0x400309E")]
	[FieldOffset(Offset = "0x38")]
	private List<RectTransform> elements;

	[Token(Token = "0x400309F")]
	[FieldOffset(Offset = "0x40")]
	private List<RectTransform> activeElements;

	[Token(Token = "0x6002913")]
	[Address(RVA = "0x14EC3D0", Offset = "0x14EC3D0", VA = "0x14EC3D0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6002914")]
	[Address(RVA = "0x14EC460", Offset = "0x14EC460", VA = "0x14EC460")]
	public void Load(LevelData levelData)
	{
	}

	[Token(Token = "0x6002915")]
	[Address(RVA = "0x14EC4C8", Offset = "0x14EC4C8", VA = "0x14EC4C8")]
	private void UpdateElementPositions()
	{
	}

	[Token(Token = "0x6002916")]
	[Address(RVA = "0x14EC75C", Offset = "0x14EC75C", VA = "0x14EC75C")]
	public InGameStatsUI()
	{
	}
}
