using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E31")]
public class SpawnObject : MonoBehaviour
{
	[Token(Token = "0x4004D02")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_prefab;

	[Token(Token = "0x4004D03")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_spawnPosition;

	[Token(Token = "0x4004D04")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEvent<GameObject> onObjectSpawned;

	[Token(Token = "0x6004293")]
	[Address(RVA = "0x16C8908", Offset = "0x16C8908", VA = "0x16C8908")]
	public void SpawnTheThing()
	{
	}

	[Token(Token = "0x6004294")]
	[Address(RVA = "0x16C8A5C", Offset = "0x16C8A5C", VA = "0x16C8A5C")]
	public SpawnObject()
	{
	}
}
