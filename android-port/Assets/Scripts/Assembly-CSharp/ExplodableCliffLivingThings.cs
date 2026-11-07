using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D72")]
public class ExplodableCliffLivingThings : MonoBehaviour, IExplodable
{
	[Token(Token = "0x400491C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnityEvent _OnExplode;

	[Token(Token = "0x6003F3C")]
	[Address(RVA = "0x144EF4C", Offset = "0x144EF4C", VA = "0x144EF4C", Slot = "4")]
	public void OnExplode()
	{
	}

	[Token(Token = "0x6003F3D")]
	[Address(RVA = "0x144EFB8", Offset = "0x144EFB8", VA = "0x144EFB8")]
	public ExplodableCliffLivingThings()
	{
	}
}
