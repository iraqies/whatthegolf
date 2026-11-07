using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D7")]
public class SetTimelineScale : MonoBehaviour
{
	[Token(Token = "0x40023D2")]
	[FieldOffset(Offset = "0x18")]
	public string timeline;

	[Token(Token = "0x40023D3")]
	[FieldOffset(Offset = "0x0")]
	public static float scale;

	[Token(Token = "0x40023D4")]
	[FieldOffset(Offset = "0x20")]
	private Clock clock;

	[Token(Token = "0x40023D5")]
	[FieldOffset(Offset = "0x28")]
	private float maxScale;

	[Token(Token = "0x6001F92")]
	[Address(RVA = "0x169011C", Offset = "0x169011C", VA = "0x169011C")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x65644", Offset = "0x65644")]
	private static void Init()
	{
	}

	[Token(Token = "0x6001F93")]
	[Address(RVA = "0x1690168", Offset = "0x1690168", VA = "0x1690168")]
	private void Start()
	{
	}

	[Token(Token = "0x6001F94")]
	[Address(RVA = "0x1690228", Offset = "0x1690228", VA = "0x1690228")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001F95")]
	[Address(RVA = "0x16902CC", Offset = "0x16902CC", VA = "0x16902CC")]
	public SetTimelineScale()
	{
	}
}
