using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200032F")]
public class ActionAfterNumEvents : MonoBehaviour
{
	[Token(Token = "0x40011A4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int NumTicks;

	[Token(Token = "0x40011A5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent m_Event;

	[Token(Token = "0x40011A6")]
	[FieldOffset(Offset = "0x28")]
	private int ticks;

	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x14045B0", Offset = "0x14045B0", VA = "0x14045B0")]
	public float Progress()
	{
		return default;
	}

	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x14045C8", Offset = "0x14045C8", VA = "0x14045C8")]
	public int TotalTicks()
	{
		return default;
	}

	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x14045D0", Offset = "0x14045D0", VA = "0x14045D0")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0x1404608", Offset = "0x1404608", VA = "0x1404608")]
	public ActionAfterNumEvents()
	{
	}
}
