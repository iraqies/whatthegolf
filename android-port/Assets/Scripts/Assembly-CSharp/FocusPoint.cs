using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000701")]
public class FocusPoint : MonoBehaviour
{
	[Token(Token = "0x40024D2")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4E704", Offset = "0x4E704")]
	public float focusRange;

	[Token(Token = "0x40024D3")]
	[FieldOffset(Offset = "0x20")]
	public Transform focusStart;

	[Token(Token = "0x40024D4")]
	[FieldOffset(Offset = "0x28")]
	public Transform focusEnd;

	[Token(Token = "0x6002059")]
	[Address(RVA = "0x146E7B4", Offset = "0x146E7B4", VA = "0x146E7B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600205A")]
	[Address(RVA = "0x146E86C", Offset = "0x146E86C", VA = "0x146E86C")]
	public FocusPoint()
	{
	}
}
