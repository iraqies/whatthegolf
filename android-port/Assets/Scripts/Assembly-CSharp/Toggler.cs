using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C65")]
public class Toggler : MonoBehaviour
{
	[Token(Token = "0x40043FC")]
	[FieldOffset(Offset = "0x18")]
	public bool startOn;

	[Token(Token = "0x40043FD")]
	[FieldOffset(Offset = "0x1C")]
	public float startDelay;

	[Token(Token = "0x40043FE")]
	[FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x40043FF")]
	[FieldOffset(Offset = "0x24")]
	public float interval;

	[Token(Token = "0x4004400")]
	[FieldOffset(Offset = "0x28")]
	public Transform toggleableContainer;

	[Token(Token = "0x4004401")]
	[FieldOffset(Offset = "0x30")]
	private IToggleable toggleable;

	[Token(Token = "0x4004402")]
	[FieldOffset(Offset = "0x38")]
	private float durationTimer;

	[Token(Token = "0x4004403")]
	[FieldOffset(Offset = "0x3C")]
	private float startTimer;

	[Token(Token = "0x6003ADC")]
	[Address(RVA = "0x171CED0", Offset = "0x171CED0", VA = "0x171CED0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003ADD")]
	[Address(RVA = "0x171CFA4", Offset = "0x171CFA4", VA = "0x171CFA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003ADE")]
	[Address(RVA = "0x171D1A4", Offset = "0x171D1A4", VA = "0x171D1A4")]
	public Toggler()
	{
	}
}
