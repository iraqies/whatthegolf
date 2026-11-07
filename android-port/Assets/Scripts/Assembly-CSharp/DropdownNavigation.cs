using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000B7D")]
[Attribute(Name = "RequireComponent", RVA = "0x43920", Offset = "0x43920")]
public class DropdownNavigation : MonoBehaviour
{
	[Token(Token = "0x400400E")]
	[FieldOffset(Offset = "0x18")]
	private TMP_Dropdown _dropdown;

	[Token(Token = "0x400400F")]
	[FieldOffset(Offset = "0x20")]
	private int _dirVertical;

	[Token(Token = "0x4004010")]
	[FieldOffset(Offset = "0x24")]
	private int _selected;

	[Token(Token = "0x4004011")]
	[FieldOffset(Offset = "0x28")]
	private float _navigationDelay;

	[Token(Token = "0x4004012")]
	[FieldOffset(Offset = "0x2C")]
	private float _currDelay;

	[Token(Token = "0x6003771")]
	[Address(RVA = "0x1436FF4", Offset = "0x1436FF4", VA = "0x1436FF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003772")]
	[Address(RVA = "0x1437150", Offset = "0x1437150", VA = "0x1437150")]
	private void Update()
	{
	}

	[Token(Token = "0x6003773")]
	[Address(RVA = "0x1437214", Offset = "0x1437214", VA = "0x1437214")]
	private void Navigate(int direction)
	{
	}

	[Token(Token = "0x6003774")]
	[Address(RVA = "0x14372CC", Offset = "0x14372CC", VA = "0x14372CC")]
	public DropdownNavigation()
	{
	}

	[Token(Token = "0x6003775")]
	[Address(RVA = "0x14372E0", Offset = "0x14372E0", VA = "0x14372E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AC74", Offset = "0x6AC74")]
	private void _003CAwake_003Eb__5_0(int s)
	{
	}
}
