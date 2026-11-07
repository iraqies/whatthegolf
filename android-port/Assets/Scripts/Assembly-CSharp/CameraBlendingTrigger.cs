using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003F3")]
public class CameraBlendingTrigger : MonoBehaviour
{
	[Token(Token = "0x4001589")]
	[FieldOffset(Offset = "0x18")]
	public CBBlend Blender;

	[Token(Token = "0x400158A")]
	[FieldOffset(Offset = "0x20")]
	public float BlendSpeed;

	[Token(Token = "0x400158B")]
	[FieldOffset(Offset = "0x24")]
	private float targetBlend;

	[Token(Token = "0x400158C")]
	[FieldOffset(Offset = "0x28")]
	private float currentBlend;

	[Token(Token = "0x6001282")]
	[Address(RVA = "0x17E4418", Offset = "0x17E4418", VA = "0x17E4418")]
	private void Update()
	{
	}

	[Token(Token = "0x6001283")]
	[Address(RVA = "0x17E447C", Offset = "0x17E447C", VA = "0x17E447C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001284")]
	[Address(RVA = "0x17E4530", Offset = "0x17E4530", VA = "0x17E4530")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6001285")]
	[Address(RVA = "0x17E45E0", Offset = "0x17E45E0", VA = "0x17E45E0")]
	public CameraBlendingTrigger()
	{
	}
}
