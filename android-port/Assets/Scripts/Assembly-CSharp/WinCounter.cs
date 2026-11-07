using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000C70")]
public class WinCounter : MonoBehaviour
{
	[Token(Token = "0x400441B")]
	[FieldOffset(Offset = "0x18")]
	public int Goal;

	[Token(Token = "0x400441C")]
	[FieldOffset(Offset = "0x20")]
	public Text ShowText;

	[Token(Token = "0x400441D")]
	[FieldOffset(Offset = "0x28")]
	public string message;

	[Token(Token = "0x400441E")]
	[FieldOffset(Offset = "0x30")]
	private int currentCounter;

	[Token(Token = "0x6003B05")]
	[Address(RVA = "0x17544A4", Offset = "0x17544A4", VA = "0x17544A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6003B06")]
	[Address(RVA = "0x17545DC", Offset = "0x17545DC", VA = "0x17545DC")]
	public void CountUp()
	{
	}

	[Token(Token = "0x6003B07")]
	[Address(RVA = "0x17546E0", Offset = "0x17546E0", VA = "0x17546E0")]
	public void CountDown()
	{
	}

	[Token(Token = "0x6003B08")]
	[Address(RVA = "0x1754540", Offset = "0x1754540", VA = "0x1754540")]
	private void UpdateText()
	{
	}

	[Token(Token = "0x6003B09")]
	[Address(RVA = "0x1754788", Offset = "0x1754788", VA = "0x1754788")]
	public WinCounter()
	{
	}
}
