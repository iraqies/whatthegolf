using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200072D")]
public class EnemyKillZone : MonoBehaviour
{
	[Token(Token = "0x40025E2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject EnemyRoot;

	[Token(Token = "0x40025E3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BoxCollider KillZone;

	[Token(Token = "0x40025E4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string playerTag;

	[Token(Token = "0x600211F")]
	[Address(RVA = "0x1444A24", Offset = "0x1444A24", VA = "0x1444A24")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x6002120")]
	[Address(RVA = "0x1444C4C", Offset = "0x1444C4C", VA = "0x1444C4C")]
	public EnemyKillZone()
	{
	}
}
