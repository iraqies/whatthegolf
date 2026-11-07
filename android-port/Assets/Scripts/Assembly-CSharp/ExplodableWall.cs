using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000128")]
public class ExplodableWall : MonoBehaviour, IExplodable
{
	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform centerOfForce;

	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float explosionForce;

	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x24")]
	private bool didCollapse;

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x144EFC0", Offset = "0x144EFC0", VA = "0x144EFC0", Slot = "4")]
	public void OnExplode()
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x144F18C", Offset = "0x144F18C", VA = "0x144F18C")]
	public ExplodableWall()
	{
	}
}
