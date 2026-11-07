using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C4")]
[Attribute(Name = "RequireComponent", RVA = "0x3E0A8", Offset = "0x3E0A8")]
public class WideScreenCanvasScaler : MonoBehaviour
{
	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0x18")]
	private float maxRatio;

	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float magicNumber;

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x1754390", Offset = "0x1754390", VA = "0x1754390")]
	private void Start()
	{
	}

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x175448C", Offset = "0x175448C", VA = "0x175448C")]
	public WideScreenCanvasScaler()
	{
	}
}
