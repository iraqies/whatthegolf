using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BBB")]
public class BeamableObject : MonoBehaviour
{
	[Token(Token = "0x4004153")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Root;

	[Token(Token = "0x4004154")]
	[FieldOffset(Offset = "0x20")]
	public bool isDestroyable;

	[Token(Token = "0x4004155")]
	[FieldOffset(Offset = "0x28")]
	public Action<BeamableObject> onBeamed;

	[Token(Token = "0x4004156")]
	[FieldOffset(Offset = "0x30")]
	public bool isBeamAble;

	[Token(Token = "0x4004157")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x4004158")]
	[FieldOffset(Offset = "0x40")]
	private Transform _currentBeamPoint;

	[Token(Token = "0x4004159")]
	[FieldOffset(Offset = "0x48")]
	public float beamPower;

	[Token(Token = "0x6003887")]
	[Address(RVA = "0x160CA44", Offset = "0x160CA44", VA = "0x160CA44")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003888")]
	[Address(RVA = "0x160CB04", Offset = "0x160CB04", VA = "0x160CB04")]
	public void BeamMeUp(Transform beamPoint)
	{
	}

	[Token(Token = "0x6003889")]
	[Address(RVA = "0x160CB10", Offset = "0x160CB10", VA = "0x160CB10")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600388A")]
	[Address(RVA = "0x160CD80", Offset = "0x160CD80", VA = "0x160CD80")]
	public BeamableObject()
	{
	}
}
