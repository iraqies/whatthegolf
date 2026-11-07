using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000B04")]
public class ExplosionEvents : MonoBehaviour, IExplodable
{
	[Token(Token = "0x4003D8B")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnExplosion;

	[Token(Token = "0x6003498")]
	[Address(RVA = "0x14537DC", Offset = "0x14537DC", VA = "0x14537DC", Slot = "4")]
	public void OnExplode()
	{
	}

	[Token(Token = "0x6003499")]
	[Address(RVA = "0x145381C", Offset = "0x145381C", VA = "0x145381C")]
	public ExplosionEvents()
	{
	}
}
