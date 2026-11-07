using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B2")]
public class AsteroidsManager : MonoBehaviour
{
	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x18")]
	public float checkFrequency;

	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x1C")]
	private float checkTimer;

	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x20")]
	public Animator UFOAnimator;

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x142B2A0", Offset = "0x142B2A0", VA = "0x142B2A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x142B2AC", Offset = "0x142B2AC", VA = "0x142B2AC")]
	private void Update()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x142B2FC", Offset = "0x142B2FC", VA = "0x142B2FC")]
	public void RecountAsteroids()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x142B3C0", Offset = "0x142B3C0", VA = "0x142B3C0")]
	public AsteroidsManager()
	{
	}
}
