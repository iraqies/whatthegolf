using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005CA")]
public class GifTriggerOnExplosion : MonoBehaviour
{
	[Token(Token = "0x4001D94")]
	[FieldOffset(Offset = "0x18")]
	public ExplosionBarrel barrel;

	[Token(Token = "0x4001D95")]
	[FieldOffset(Offset = "0x20")]
	private GifMomentTrigger trigger;

	[Token(Token = "0x6001A57")]
	[Address(RVA = "0x1488E88", Offset = "0x1488E88", VA = "0x1488E88")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A58")]
	[Address(RVA = "0x1488F60", Offset = "0x1488F60", VA = "0x1488F60")]
	private void Barrel_OnExplode(Collider arg1, ExplosionBarrel arg2)
	{
	}

	[Token(Token = "0x6001A59")]
	[Address(RVA = "0x1489000", Offset = "0x1489000", VA = "0x1489000")]
	public GifTriggerOnExplosion()
	{
	}
}
