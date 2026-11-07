using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009AD")]
public class EnableOnPortal : MonoBehaviour
{
	[Token(Token = "0x400353B")]
	[FieldOffset(Offset = "0x18")]
	public SimplePortal portal;

	[Token(Token = "0x400353C")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> toDisableWhenPortalIsReady;

	[Token(Token = "0x400353D")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> toEnableWhenPortalIsReady;

	[Token(Token = "0x6002D82")]
	[Address(RVA = "0x14432A8", Offset = "0x14432A8", VA = "0x14432A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D83")]
	[Address(RVA = "0x1443464", Offset = "0x1443464", VA = "0x1443464")]
	private void Portal_OnPortalEnabledIfDidntStartEnabled()
	{
	}

	[Token(Token = "0x6002D84")]
	[Address(RVA = "0x1443344", Offset = "0x1443344", VA = "0x1443344")]
	private void UpdateStates()
	{
	}

	[Token(Token = "0x6002D85")]
	[Address(RVA = "0x1443468", Offset = "0x1443468", VA = "0x1443468")]
	public EnableOnPortal()
	{
	}
}
