using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D4")]
public class DrawDominos : MonoBehaviour
{
	[Token(Token = "0x40023BA")]
	[FieldOffset(Offset = "0x18")]
	private Transform start;

	[Token(Token = "0x40023BB")]
	[FieldOffset(Offset = "0x20")]
	private Transform end;

	[Token(Token = "0x40023BC")]
	[FieldOffset(Offset = "0x28")]
	private Transform control;

	[Token(Token = "0x40023BD")]
	[FieldOffset(Offset = "0x30")]
	public Transform[] drawingPoints;

	[Token(Token = "0x40023BE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject brush;

	[Token(Token = "0x40023BF")]
	[FieldOffset(Offset = "0x40")]
	private float totalLength;

	[Token(Token = "0x40023C0")]
	[FieldOffset(Offset = "0x44")]
	private float currentLength;

	[Token(Token = "0x40023C1")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4E52C", Offset = "0x4E52C")]
	public float stepDetail;

	[Token(Token = "0x40023C2")]
	[FieldOffset(Offset = "0x4C")]
	private float t;

	[Token(Token = "0x40023C3")]
	[FieldOffset(Offset = "0x50")]
	public List<GameObject> dominos;

	[Token(Token = "0x40023C4")]
	[FieldOffset(Offset = "0x58")]
	private int[] controlIndex;

	[Token(Token = "0x40023C5")]
	[FieldOffset(Offset = "0x60")]
	private int[] endIndex;

	[Token(Token = "0x40023C6")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve dominoScale;

	[Token(Token = "0x40023C7")]
	[FieldOffset(Offset = "0x70")]
	public bool resetOnOutOfBounds;

	[Token(Token = "0x40023C8")]
	[FieldOffset(Offset = "0x78")]
	public Transform endTransform;

	[Token(Token = "0x40023C9")]
	[FieldOffset(Offset = "0x80")]
	private float detail;

	[Token(Token = "0x40023CA")]
	[FieldOffset(Offset = "0x0")]
	public static float boxY;

	[Token(Token = "0x40023CB")]
	[FieldOffset(Offset = "0x84")]
	public bool followDomino;

	[Token(Token = "0x6001F86")]
	[Address(RVA = "0x1434D10", Offset = "0x1434D10", VA = "0x1434D10")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x65630", Offset = "0x65630")]
	private static void Init()
	{
	}

	[Token(Token = "0x6001F87")]
	[Address(RVA = "0x1434D5C", Offset = "0x1434D5C", VA = "0x1434D5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001F88")]
	[Address(RVA = "0x1435690", Offset = "0x1435690", VA = "0x1435690")]
	private float DetermineLength()
	{
		return default;
	}

	[Token(Token = "0x6001F89")]
	[Address(RVA = "0x1435824", Offset = "0x1435824", VA = "0x1435824")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0x1435588", Offset = "0x1435588", VA = "0x1435588")]
	private void UpdateIndexes()
	{
	}

	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0x1435E24", Offset = "0x1435E24", VA = "0x1435E24")]
	public DrawDominos()
	{
	}
}
