using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C29")]
public class RotateAxis : MonoBehaviour
{
	[Token(Token = "0x400430D")]
	[FieldOffset(Offset = "0x18")]
	public bool UsePhysics;

	[Token(Token = "0x400430E")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 Axis;

	[Token(Token = "0x400430F")]
	[FieldOffset(Offset = "0x28")]
	public float Speed;

	[Token(Token = "0x4004310")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4004311")]
	[FieldOffset(Offset = "0x38")]
	private Timeline timeline;

	[Token(Token = "0x6003A23")]
	[Address(RVA = "0x165EA8C", Offset = "0x165EA8C", VA = "0x165EA8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003A24")]
	[Address(RVA = "0x165EB0C", Offset = "0x165EB0C", VA = "0x165EB0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A25")]
	[Address(RVA = "0x165EC50", Offset = "0x165EC50", VA = "0x165EC50")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003A26")]
	[Address(RVA = "0x165EB90", Offset = "0x165EB90", VA = "0x165EB90")]
	private float GetDelta()
	{
		return default;
	}

	[Token(Token = "0x6003A27")]
	[Address(RVA = "0x165ED80", Offset = "0x165ED80", VA = "0x165ED80")]
	public RotateAxis()
	{
	}
}
