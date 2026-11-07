using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005BE")]
public class GhostRef : MonoBehaviour
{
	[Token(Token = "0x4001D5B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Prefab;

	[Token(Token = "0x170002D2")]
	public string PrefabID
	{
		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x1485F30", Offset = "0x1485F30", VA = "0x1485F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001A17")]
	[Address(RVA = "0x1485FF4", Offset = "0x1485FF4", VA = "0x1485FF4")]
	public GhostRef()
	{
	}
}
