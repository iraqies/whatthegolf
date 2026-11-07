using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000C6A")]
public class UnityEventOnChallengeButtons : MonoBehaviour
{
	[Token(Token = "0x2000C6B")]
	public enum ButtonCallbackType
	{
		[Token(Token = "0x400440A")]
		OnAnyPressedDown = 0,
		[Token(Token = "0x400440B")]
		OnAllPressedDown = 1,
		[Token(Token = "0x400440C")]
		OnAnyPressedUp = 2,
		[Token(Token = "0x400440D")]
		OnAllPressedUp = 3
	}

	[Token(Token = "0x4004406")]
	[FieldOffset(Offset = "0x18")]
	public ButtonCallbackType DoActionOn;

	[Token(Token = "0x4004407")]
	[FieldOffset(Offset = "0x20")]
	public List<ChallengeButton> Buttons;

	[Token(Token = "0x4004408")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent OnAction;

	[Token(Token = "0x6003AF1")]
	[Address(RVA = "0x173B38C", Offset = "0x173B38C", VA = "0x173B38C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003AF2")]
	[Address(RVA = "0x173B4C4", Offset = "0x173B4C4", VA = "0x173B4C4")]
	private void OnButtonTrigger(ChallengeButton button)
	{
	}

	[Token(Token = "0x6003AF3")]
	[Address(RVA = "0x173B6AC", Offset = "0x173B6AC", VA = "0x173B6AC")]
	public UnityEventOnChallengeButtons()
	{
	}
}
