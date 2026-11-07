using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D76")]
public class ExplosionEvents2D : MonoBehaviour
{
	[Token(Token = "0x400493E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnityEvent _onExplode;

	[Token(Token = "0x6003F51")]
	[Address(RVA = "0x1453824", Offset = "0x1453824", VA = "0x1453824")]
	private void Start()
	{
	}

	[Token(Token = "0x6003F52")]
	[Address(RVA = "0x145395C", Offset = "0x145395C", VA = "0x145395C")]
	public void OnExplode(Collider2D obj)
	{
	}

	[Token(Token = "0x6003F53")]
	[Address(RVA = "0x1453970", Offset = "0x1453970", VA = "0x1453970")]
	public ExplosionEvents2D()
	{
	}
}
