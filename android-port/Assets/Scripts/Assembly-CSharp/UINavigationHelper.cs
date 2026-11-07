using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001C3")]
public class UINavigationHelper : MonoBehaviour
{
	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0x18")]
	public bool canNavigateOutsideOfGroupHorizontally;

	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0x19")]
	public bool canNavigateOutsideOfGroupVertically;

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x1736EE8", Offset = "0x1736EE8", VA = "0x1736EE8")]
	public Selectable GetFollowingSelectable(Selectable current, int increment)
	{
		return null;
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x1736FC0", Offset = "0x1736FC0", VA = "0x1736FC0")]
	public static void SetExplicit1DNavigation(List<Selectable> ordered)
	{
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x173717C", Offset = "0x173717C", VA = "0x173717C")]
	public UINavigationHelper()
	{
	}
}
