using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200034E")]
public class OnAimEvent : MonoBehaviour
{
	[Token(Token = "0x4001247")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x4001248")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent _event;

	[Token(Token = "0x6000F57")]
	[Address(RVA = "0x159605C", Offset = "0x159605C", VA = "0x159605C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F58")]
	[Address(RVA = "0x15960F0", Offset = "0x15960F0", VA = "0x15960F0")]
	private void TriggerEvent()
	{
	}

	[Token(Token = "0x6000F59")]
	[Address(RVA = "0x15961B0", Offset = "0x15961B0", VA = "0x15961B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0x1596244", Offset = "0x1596244", VA = "0x1596244")]
	public OnAimEvent()
	{
	}
}
