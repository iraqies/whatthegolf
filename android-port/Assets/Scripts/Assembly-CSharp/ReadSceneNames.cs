using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BA8")]
public class ReadSceneNames : MonoBehaviour
{
	[Token(Token = "0x4004106")]
	[FieldOffset(Offset = "0x0")]
	private static object _lock;

	[Token(Token = "0x4004107")]
	[FieldOffset(Offset = "0x8")]
	private static bool applicationIsQuitting;

	[Token(Token = "0x4004108")]
	[FieldOffset(Offset = "0x10")]
	private static ReadSceneNames instance;

	[Token(Token = "0x4004109")]
	[FieldOffset(Offset = "0x18")]
	public string sceneFilename;

	[Token(Token = "0x400410A")]
	[FieldOffset(Offset = "0x20")]
	public string[] scenes;

	[Token(Token = "0x170005ED")]
	public static ReadSceneNames Instance
	{
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x1642280", Offset = "0x1642280", VA = "0x1642280")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003849")]
	[Address(RVA = "0x1642768", Offset = "0x1642768", VA = "0x1642768")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6B09C", Offset = "0x6B09C")]
	private static void Init()
	{
	}

	[Token(Token = "0x600384A")]
	[Address(RVA = "0x16427CC", Offset = "0x16427CC", VA = "0x16427CC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600384B")]
	[Address(RVA = "0x1642838", Offset = "0x1642838", VA = "0x1642838")]
	private string BuildLoadFilename()
	{
		return null;
	}

	[Token(Token = "0x600384C")]
	[Address(RVA = "0x164252C", Offset = "0x164252C", VA = "0x164252C")]
	private void LoadLevelNames()
	{
	}

	[Token(Token = "0x600384D")]
	[Address(RVA = "0x1642890", Offset = "0x1642890", VA = "0x1642890")]
	public ReadSceneNames()
	{
	}
}
