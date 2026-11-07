using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B87")]
[Attribute(Name = "RequireComponent", RVA = "0x43A78", Offset = "0x43A78")]
public class ApplicationExitGameSaver : MonoBehaviour
{
	[Token(Token = "0x4004024")]
	[FieldOffset(Offset = "0x18")]
	private float timeOverworldLoaded;

	[Token(Token = "0x4004025")]
	[FieldOffset(Offset = "0x20")]
	private OverworldCompletionPercentage completion;

	[Token(Token = "0x4004026")]
	[FieldOffset(Offset = "0x28")]
	private float timePlayed;

	[Token(Token = "0x4004027")]
	[FieldOffset(Offset = "0x2C")]
	private bool skipFrame;

	[Token(Token = "0x4004028")]
	[FieldOffset(Offset = "0x2D")]
	private bool paused;

	[Token(Token = "0x6003799")]
	[Address(RVA = "0x141C324", Offset = "0x141C324", VA = "0x141C324")]
	private void Awake()
	{
	}

	[Token(Token = "0x600379A")]
	[Address(RVA = "0x141C388", Offset = "0x141C388", VA = "0x141C388")]
	private void Start()
	{
	}

	[Token(Token = "0x600379B")]
	[Address(RVA = "0x141C394", Offset = "0x141C394", VA = "0x141C394")]
	private void Update()
	{
	}

	[Token(Token = "0x600379C")]
	[Address(RVA = "0x141C53C", Offset = "0x141C53C", VA = "0x141C53C")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600379D")]
	[Address(RVA = "0x141C570", Offset = "0x141C570", VA = "0x141C570")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600379E")]
	[Address(RVA = "0x141C47C", Offset = "0x141C47C", VA = "0x141C47C")]
	private void Save(bool gameClosing = false)
	{
	}

	[Token(Token = "0x600379F")]
	[Address(RVA = "0x141C578", Offset = "0x141C578", VA = "0x141C578")]
	public int GetPreviousPlayedTime()
	{
		return default;
	}

	[Token(Token = "0x60037A0")]
	[Address(RVA = "0x141C5D4", Offset = "0x141C5D4", VA = "0x141C5D4")]
	public void Pause(bool pause = true)
	{
	}

	[Token(Token = "0x60037A1")]
	[Address(RVA = "0x141C5DC", Offset = "0x141C5DC", VA = "0x141C5DC")]
	public float GetTimePlayedThisSession()
	{
		return default;
	}

	[Token(Token = "0x60037A2")]
	[Address(RVA = "0x141C5E4", Offset = "0x141C5E4", VA = "0x141C5E4")]
	public ApplicationExitGameSaver()
	{
	}
}
