using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CE4")]
public class EasterEggPackstarter : MonoBehaviour
{
	[Token(Token = "0x4004616")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int StartMonth;

	[Token(Token = "0x4004617")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int StartDay;

	[Token(Token = "0x4004618")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int EndMonth;

	[Token(Token = "0x4004619")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int EndDay;

	[Token(Token = "0x400461A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool debug;

	[Token(Token = "0x400461B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string url;

	[Token(Token = "0x6003D01")]
	[Address(RVA = "0x143A458", Offset = "0x143A458", VA = "0x143A458")]
	private void Start()
	{
	}

	[Token(Token = "0x6003D02")]
	[Address(RVA = "0x143A630", Offset = "0x143A630", VA = "0x143A630")]
	public void StartPack()
	{
	}

	[Token(Token = "0x6003D03")]
	[Address(RVA = "0x143A510", Offset = "0x143A510", VA = "0x143A510")]
	private bool CheckTime()
	{
		return default;
	}

	[Token(Token = "0x6003D04")]
	[Address(RVA = "0x143A694", Offset = "0x143A694", VA = "0x143A694")]
	public EasterEggPackstarter()
	{
	}
}
