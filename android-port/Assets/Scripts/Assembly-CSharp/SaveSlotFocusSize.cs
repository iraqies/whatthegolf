using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008E3")]
public class SaveSlotFocusSize : MonoBehaviour
{
	[Token(Token = "0x40030AB")]
	[FieldOffset(Offset = "0x18")]
	public float SpeedSwing;

	[Token(Token = "0x40030AC")]
	[FieldOffset(Offset = "0x1C")]
	public float CurvePercentage;

	[Token(Token = "0x40030AD")]
	[FieldOffset(Offset = "0x20")]
	private float sizeX;

	[Token(Token = "0x40030AE")]
	[FieldOffset(Offset = "0x24")]
	private float sizeY;

	[Token(Token = "0x40030AF")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform rectTransform;

	[Token(Token = "0x6002920")]
	[Address(RVA = "0x16771C4", Offset = "0x16771C4", VA = "0x16771C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002921")]
	[Address(RVA = "0x1677248", Offset = "0x1677248", VA = "0x1677248")]
	private void Update()
	{
	}

	[Token(Token = "0x6002922")]
	[Address(RVA = "0x16772B0", Offset = "0x16772B0", VA = "0x16772B0")]
	public SaveSlotFocusSize()
	{
	}
}
