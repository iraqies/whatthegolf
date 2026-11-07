using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C72")]
public class AutoHideCursor : MonoBehaviour
{
	[Token(Token = "0x4004421")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float timeBeforeHide;

	[Token(Token = "0x4004422")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool hidden;

	[Token(Token = "0x4004423")]
	[FieldOffset(Offset = "0x20")]
	private float timer;

	[Token(Token = "0x4004424")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 mousePosLastFrame;

	[Token(Token = "0x4004425")]
	[FieldOffset(Offset = "0x30")]
	private bool updatePosition;

	[Token(Token = "0x6003B0E")]
	[Address(RVA = "0x1514EE4", Offset = "0x1514EE4", VA = "0x1514EE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003B0F")]
	[Address(RVA = "0x1514F24", Offset = "0x1514F24", VA = "0x1514F24")]
	private void Start()
	{
	}

	[Token(Token = "0x6003B10")]
	[Address(RVA = "0x1514FD0", Offset = "0x1514FD0", VA = "0x1514FD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B11")]
	[Address(RVA = "0x1514F84", Offset = "0x1514F84", VA = "0x1514F84")]
	private void Toggle(bool isVisible)
	{
	}

	[Token(Token = "0x6003B12")]
	[Address(RVA = "0x15150F8", Offset = "0x15150F8", VA = "0x15150F8")]
	public AutoHideCursor()
	{
	}
}
