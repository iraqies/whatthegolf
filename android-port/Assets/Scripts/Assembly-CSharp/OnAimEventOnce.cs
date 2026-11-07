using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E8E")]
public class OnAimEventOnce : MonoBehaviour
{
	[Token(Token = "0x4004EAB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x4004EAC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent _event;

	[Token(Token = "0x4004EAD")]
	[FieldOffset(Offset = "0x28")]
	private bool hasFired;

	[Token(Token = "0x60043FC")]
	[Address(RVA = "0x159624C", Offset = "0x159624C", VA = "0x159624C")]
	private void Start()
	{
	}

	[Token(Token = "0x60043FD")]
	[Address(RVA = "0x15962E0", Offset = "0x15962E0", VA = "0x15962E0")]
	private void TriggerEvent()
	{
	}

	[Token(Token = "0x60043FE")]
	[Address(RVA = "0x15963B4", Offset = "0x15963B4", VA = "0x15963B4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60043FF")]
	[Address(RVA = "0x1596448", Offset = "0x1596448", VA = "0x1596448")]
	public OnAimEventOnce()
	{
	}
}
