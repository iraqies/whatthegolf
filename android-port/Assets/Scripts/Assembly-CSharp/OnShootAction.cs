using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20001D0")]
public class OnShootAction : MonoBehaviour
{
	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool onlyOnce;

	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEvent action;

	[Token(Token = "0x6000820")]
	[Address(RVA = "0x159A3F0", Offset = "0x159A3F0", VA = "0x159A3F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000821")]
	[Address(RVA = "0x159A500", Offset = "0x159A500", VA = "0x159A500")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000822")]
	[Address(RVA = "0x159A610", Offset = "0x159A610", VA = "0x159A610")]
	private void Controller_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6000823")]
	[Address(RVA = "0x159A664", Offset = "0x159A664", VA = "0x159A664")]
	public OnShootAction()
	{
	}
}
