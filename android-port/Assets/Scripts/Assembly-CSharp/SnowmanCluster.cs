using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D1E")]
public class SnowmanCluster : MonoBehaviour
{
	[Token(Token = "0x4004729")]
	[FieldOffset(Offset = "0x18")]
	public int maxNumberOfSnowmenSpawned;

	[Token(Token = "0x400472A")]
	[FieldOffset(Offset = "0x20")]
	public ObjectHiddenInSnow[] snowmen;

	[Token(Token = "0x400472B")]
	[FieldOffset(Offset = "0x28")]
	private int currentNumberOfSnowmenSpawned;

	[Token(Token = "0x6003DE2")]
	[Address(RVA = "0x16BD174", Offset = "0x16BD174", VA = "0x16BD174")]
	private void Start()
	{
	}

	[Token(Token = "0x6003DE3")]
	[Address(RVA = "0x16BD178", Offset = "0x16BD178", VA = "0x16BD178")]
	private void Update()
	{
	}

	[Token(Token = "0x6003DE4")]
	[Address(RVA = "0x16BD17C", Offset = "0x16BD17C", VA = "0x16BD17C")]
	public void SnowmanActivated()
	{
	}

	[Token(Token = "0x6003DE5")]
	[Address(RVA = "0x16BD19C", Offset = "0x16BD19C", VA = "0x16BD19C")]
	private void DeactiveHiddenSnowmen()
	{
	}

	[Token(Token = "0x6003DE6")]
	[Address(RVA = "0x16BD230", Offset = "0x16BD230", VA = "0x16BD230")]
	public SnowmanCluster()
	{
	}
}
