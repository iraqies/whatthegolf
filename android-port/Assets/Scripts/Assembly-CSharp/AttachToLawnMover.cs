using Cinemachine;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000239")]
public class AttachToLawnMover : MonoBehaviour
{
	[Token(Token = "0x4000B5D")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FakeVike;

	[Token(Token = "0x4000B5F")]
	[FieldOffset(Offset = "0x28")]
	public CinemachineDollyCart Dolly;

	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0x30")]
	public float DollyMaxSpeed;

	[Token(Token = "0x4000B61")]
	[FieldOffset(Offset = "0x38")]
	public Animator CameraController;

	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x40")]
	public Animator LawnMoverSequenceAnimator;

	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x48")]
	private bool hasAttached;

	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x142BDAC", Offset = "0x142BDAC", VA = "0x142BDAC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x142BF70", Offset = "0x142BF70", VA = "0x142BF70")]
	public AttachToLawnMover()
	{
	}
}
