using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x20005F9")]
public class BossPrototypeIndicator : MonoBehaviour
{
	[Token(Token = "0x4001E83")]
	[FieldOffset(Offset = "0x18")]
	public bool Is2D;

	[Token(Token = "0x4001E84")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Canvas2D;

	[Token(Token = "0x4001E85")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Canvas3D;

	[Token(Token = "0x4001E86")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI Text2D;

	[Token(Token = "0x4001E87")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI Text3D;

	[Token(Token = "0x4001E88")]
	[FieldOffset(Offset = "0x40")]
	public string MobileText;

	[Token(Token = "0x4001E89")]
	[FieldOffset(Offset = "0x48")]
	public string StandaloneText;

	[Token(Token = "0x6001B2A")]
	[Address(RVA = "0x16FFFE0", Offset = "0x16FFFE0", VA = "0x16FFFE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0x1700104", Offset = "0x1700104", VA = "0x1700104")]
	public BossPrototypeIndicator()
	{
	}
}
