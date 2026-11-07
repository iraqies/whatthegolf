using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E20")]
public class OnShootTriggerDetection : MonoBehaviour
{
	[Token(Token = "0x4004CB2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x4004CB3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent action;

	[Token(Token = "0x4004CB4")]
	[FieldOffset(Offset = "0x28")]
	private bool isInTrigger;

	[Token(Token = "0x600424C")]
	[Address(RVA = "0x159A66C", Offset = "0x159A66C", VA = "0x159A66C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600424D")]
	[Address(RVA = "0x159A71C", Offset = "0x159A71C", VA = "0x159A71C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600424E")]
	[Address(RVA = "0x159A7CC", Offset = "0x159A7CC", VA = "0x159A7CC")]
	private void Controller_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600424F")]
	[Address(RVA = "0x159A7F8", Offset = "0x159A7F8", VA = "0x159A7F8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6004250")]
	[Address(RVA = "0x159A874", Offset = "0x159A874", VA = "0x159A874")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6004251")]
	[Address(RVA = "0x159A8EC", Offset = "0x159A8EC", VA = "0x159A8EC")]
	public OnShootTriggerDetection()
	{
	}
}
