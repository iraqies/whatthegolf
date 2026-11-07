using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004A4")]
public class GameObjectPool : MonoBehaviour
{
	[Token(Token = "0x4001876")]
	[FieldOffset(Offset = "0x0")]
	private static GameObjectPool instance;

	[Token(Token = "0x4001877")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<GameObject, List<GameObject>> instances;

	[Token(Token = "0x1700025B")]
	public static GameObjectPool Instance
	{
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x147E52C", Offset = "0x147E52C", VA = "0x147E52C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001569")]
	[Address(RVA = "0x147E654", Offset = "0x147E654", VA = "0x147E654")]
	public GameObject Pop(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x600156A")]
	[Address(RVA = "0x147E99C", Offset = "0x147E99C", VA = "0x147E99C")]
	public void Push(GameObject gameObject)
	{
	}

	[Token(Token = "0x600156B")]
	[Address(RVA = "0x147E8B0", Offset = "0x147E8B0", VA = "0x147E8B0")]
	private List<GameObject> GetGameObjects(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x600156C")]
	[Address(RVA = "0x147EA30", Offset = "0x147EA30", VA = "0x147EA30")]
	public GameObjectPool()
	{
	}
}
