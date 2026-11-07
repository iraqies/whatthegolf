using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000557")]
public class DailyChallengeScoreEntry : MonoBehaviour
{
	[Token(Token = "0x4001B9A")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI PositionText;

	[Token(Token = "0x4001B9B")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI NameText;

	[Token(Token = "0x4001B9C")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI ScoreText;

	[Token(Token = "0x4001B9D")]
	[FieldOffset(Offset = "0x30")]
	public Image bagground;

	[Token(Token = "0x4001B9E")]
	[FieldOffset(Offset = "0x38")]
	public CanvasGroup Alpha;

	[Token(Token = "0x4001B9F")]
	[FieldOffset(Offset = "0x0")]
	private static Color? nameColorNormal;

	[Token(Token = "0x4001BA0")]
	[FieldOffset(Offset = "0x40")]
	private bool focus;

	[Token(Token = "0x4001BA1")]
	[FieldOffset(Offset = "0x48")]
	public Image PositionBelow10Image;

	[Token(Token = "0x4001BA2")]
	[FieldOffset(Offset = "0x50")]
	public Image PositionAbove10Image;

	[Token(Token = "0x4001BA3")]
	[FieldOffset(Offset = "0x58")]
	public bool isEvenNumbered;

	[Token(Token = "0x4001BA4")]
	[FieldOffset(Offset = "0x18")]
	private static HashSet<char> legalCharacters;

	[Token(Token = "0x6001860")]
	[Address(RVA = "0x18CED88", Offset = "0x18CED88", VA = "0x18CED88")]
	private void Start()
	{
	}

	[Token(Token = "0x6001861")]
	[Address(RVA = "0x18CEED0", Offset = "0x18CEED0", VA = "0x18CEED0")]
	public void SetBaggroundColor(Color col)
	{
	}

	[Token(Token = "0x6001862")]
	[Address(RVA = "0x18CEEF4", Offset = "0x18CEEF4", VA = "0x18CEEF4")]
	private void Update()
	{
	}

	[Token(Token = "0x6001863")]
	[Address(RVA = "0x18CF084", Offset = "0x18CF084", VA = "0x18CF084")]
	public void SetNewColor()
	{
	}

	[Token(Token = "0x6001864")]
	[Address(RVA = "0x18CF088", Offset = "0x18CF088", VA = "0x18CF088")]
	private string ReplaceBadCharacters(string text)
	{
		return null;
	}

	[Token(Token = "0x6001865")]
	[Address(RVA = "0x18CF204", Offset = "0x18CF204", VA = "0x18CF204")]
	public void SetData(int position, string name, int score, bool focus = false, bool useLocalizedText = false)
	{
	}

	[Token(Token = "0x6001866")]
	[Address(RVA = "0x18CF5BC", Offset = "0x18CF5BC", VA = "0x18CF5BC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001867")]
	[Address(RVA = "0x18CF784", Offset = "0x18CF784", VA = "0x18CF784")]
	public DailyChallengeScoreEntry()
	{
	}
}
