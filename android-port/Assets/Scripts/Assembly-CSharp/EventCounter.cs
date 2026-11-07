using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E13")]
public class EventCounter : MonoBehaviour
{
	[Token(Token = "0x4004C7C")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnCounterComplete;

	[Token(Token = "0x4004C7D")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnCounterZero;

	[Token(Token = "0x4004C7E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_delayBetweenActions;

	[Token(Token = "0x4004C7F")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int m_counterNeeded;

	[Token(Token = "0x4004C80")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_currentlyActivated;

	[Token(Token = "0x6004221")]
	[Address(RVA = "0x1446C90", Offset = "0x1446C90", VA = "0x1446C90")]
	public void AddToCounter(GameObject sender)
	{
	}

	[Token(Token = "0x6004222")]
	[Address(RVA = "0x1446D80", Offset = "0x1446D80", VA = "0x1446D80")]
	public void RemoveFromCounter(GameObject sender)
	{
	}

	[Token(Token = "0x6004223")]
	[Address(RVA = "0x1446D64", Offset = "0x1446D64", VA = "0x1446D64")]
	private void CallAction()
	{
	}

	[Token(Token = "0x6004224")]
	[Address(RVA = "0x1446E4C", Offset = "0x1446E4C", VA = "0x1446E4C")]
	public EventCounter()
	{
	}
}
