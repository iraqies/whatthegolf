using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E53")]
public class HideAreaOnConsoles : MonoBehaviour
{
	[Token(Token = "0x2000E54")]
	private enum PlatformCondition
	{
		[Token(Token = "0x4004DB8")]
		IsContainedInList = 0,
		[Token(Token = "0x4004DB9")]
		IsNotContainedInList = 1
	}

	[Token(Token = "0x4004DB3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Store> stores;

	[Token(Token = "0x4004DB4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PlatformCondition applyWhenCurrentPlatform;

	[Token(Token = "0x4004DB5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<GameObject> m_objectsToShow;

	[Token(Token = "0x4004DB6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<GameObject> m_objectsToHide;

	[Token(Token = "0x6004308")]
	[Address(RVA = "0x14C6FA8", Offset = "0x14C6FA8", VA = "0x14C6FA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6004309")]
	[Address(RVA = "0x14C6FAC", Offset = "0x14C6FAC", VA = "0x14C6FAC")]
	public void HideAndShow()
	{
	}

	[Token(Token = "0x600430A")]
	[Address(RVA = "0x14C7230", Offset = "0x14C7230", VA = "0x14C7230")]
	public HideAreaOnConsoles()
	{
	}
}
