using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000E3A")]
public class CountdownTimerForTesting : MonoBehaviour
{
	[Token(Token = "0x4004D25")]
	[FieldOffset(Offset = "0x18")]
	public int hours;

	[Token(Token = "0x4004D26")]
	[FieldOffset(Offset = "0x1C")]
	public float timeRemaining;

	[Token(Token = "0x4004D27")]
	[FieldOffset(Offset = "0x20")]
	public bool timerIsRunning;

	[Token(Token = "0x4004D28")]
	[FieldOffset(Offset = "0x28")]
	public TMP_Text timeText;

	[Token(Token = "0x60042B1")]
	[Address(RVA = "0x18BAA24", Offset = "0x18BAA24", VA = "0x18BAA24")]
	private void Start()
	{
	}

	[Token(Token = "0x60042B2")]
	[Address(RVA = "0x18BAA30", Offset = "0x18BAA30", VA = "0x18BAA30")]
	private void Update()
	{
	}

	[Token(Token = "0x60042B3")]
	[Address(RVA = "0x18BAAF8", Offset = "0x18BAAF8", VA = "0x18BAAF8")]
	private void DisplayTime(float timeToDisplay)
	{
	}

	[Token(Token = "0x60042B4")]
	[Address(RVA = "0x18BAC48", Offset = "0x18BAC48", VA = "0x18BAC48")]
	public CountdownTimerForTesting()
	{
	}
}
