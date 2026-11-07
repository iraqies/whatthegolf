using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BE0")]
[ExecuteInEditMode]
public class ElmastGenerator : MonoBehaviour
{
	[Token(Token = "0x40041D2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MastTemplate;

	[Token(Token = "0x40041D3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LineSegment;

	[Token(Token = "0x40041D4")]
	[FieldOffset(Offset = "0x28")]
	public List<Transform> MastPositions;

	[Token(Token = "0x40041D5")]
	[FieldOffset(Offset = "0x30")]
	public float SegmentsLength;

	[Token(Token = "0x40041D6")]
	[FieldOffset(Offset = "0x34")]
	public float MassPerLine;

	[Token(Token = "0x40041D7")]
	[FieldOffset(Offset = "0x38")]
	public bool DoUpdate;

	[Token(Token = "0x40041D8")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> SpawnedMasts;

	[Token(Token = "0x40041D9")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<GameObject, List<GameObject>> lines;

	[Token(Token = "0x60038F5")]
	[Address(RVA = "0x144020C", Offset = "0x144020C", VA = "0x144020C")]
	private void Update()
	{
	}

	[Token(Token = "0x60038F6")]
	[Address(RVA = "0x144117C", Offset = "0x144117C", VA = "0x144117C")]
	private void BuildLines(Transform previousMast, Transform currentMast)
	{
	}

	[Token(Token = "0x60038F7")]
	[Address(RVA = "0x14418BC", Offset = "0x14418BC", VA = "0x14418BC")]
	public ElmastGenerator()
	{
	}
}
