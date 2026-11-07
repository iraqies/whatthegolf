using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C62")]
public class ToggleObjectOnMouseHover : MonoBehaviour
{
	[Token(Token = "0x40043EF")]
	[FieldOffset(Offset = "0x18")]
	public bool StateWhenMouseOver;

	[Token(Token = "0x40043F0")]
	[FieldOffset(Offset = "0x20")]
	public List<MonoBehaviour> BehavioursToToggle;

	[Token(Token = "0x40043F1")]
	[FieldOffset(Offset = "0x28")]
	private float delay;

	[Token(Token = "0x6003ACF")]
	[Address(RVA = "0x171BC80", Offset = "0x171BC80", VA = "0x171BC80")]
	private void Update()
	{
	}

	[Token(Token = "0x6003AD0")]
	[Address(RVA = "0x171BE64", Offset = "0x171BE64", VA = "0x171BE64")]
	private void OnMouseOver()
	{
	}

	[Token(Token = "0x6003AD1")]
	[Address(RVA = "0x171BCDC", Offset = "0x171BCDC", VA = "0x171BCDC")]
	private void OnMouseExit()
	{
	}

	[Token(Token = "0x6003AD2")]
	[Address(RVA = "0x171BFC8", Offset = "0x171BFC8", VA = "0x171BFC8")]
	private void OnMouseUp()
	{
	}

	[Token(Token = "0x6003AD3")]
	[Address(RVA = "0x171BFD4", Offset = "0x171BFD4", VA = "0x171BFD4")]
	public ToggleObjectOnMouseHover()
	{
	}
}
