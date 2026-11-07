using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x200060F")]
public class BossIslandPart : MonoBehaviour
{
	[Token(Token = "0x4001F44")]
	[FieldOffset(Offset = "0x18")]
	public Transform EndPoint;

	[Token(Token = "0x4001F45")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> DriveNodes;

	[Token(Token = "0x4001F46")]
	[FieldOffset(Offset = "0x28")]
	public ObjectPool<BossIslandPart> OwnerPool;

	[Token(Token = "0x4001F47")]
	[FieldOffset(Offset = "0x30")]
	public MeshRenderer IslandMesh;

	[Token(Token = "0x6001B99")]
	[Address(RVA = "0x16FD448", Offset = "0x16FD448", VA = "0x16FD448")]
	public BossIslandPart()
	{
	}
}
