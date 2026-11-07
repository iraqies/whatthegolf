using Hub;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CE6")]
public class ThankgivingTurkeyButton : MonoBehaviour
{
	[Token(Token = "0x400461E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FlagPackStarter _flagPackStarter;

	[Token(Token = "0x400461F")]
	[FieldOffset(Offset = "0x20")]
	private int _counter;

	[Token(Token = "0x4004620")]
	[FieldOffset(Offset = "0x28")]
	private double _cooldown;

	[Token(Token = "0x6003D07")]
	[Address(RVA = "0x1712908", Offset = "0x1712908", VA = "0x1712908")]
	private void Start()
	{
	}

	[Token(Token = "0x6003D08")]
	[Address(RVA = "0x17129A8", Offset = "0x17129A8", VA = "0x17129A8")]
	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	[Token(Token = "0x6003D09")]
	[Address(RVA = "0x1712A7C", Offset = "0x1712A7C", VA = "0x1712A7C")]
	public ThankgivingTurkeyButton()
	{
	}
}
