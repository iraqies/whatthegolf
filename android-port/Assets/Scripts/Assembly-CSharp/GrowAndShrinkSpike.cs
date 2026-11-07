using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000AF")]
public class GrowAndShrinkSpike : MonoBehaviour
{
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve GrowCurve;

	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x20")]
	private float growTimer;

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x14BDE0C", Offset = "0x14BDE0C", VA = "0x14BDE0C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x14BDE84", Offset = "0x14BDE84", VA = "0x14BDE84")]
	public GrowAndShrinkSpike()
	{
	}
}
