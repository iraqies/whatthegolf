using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009BD")]
public class GridviewMenu : MonoBehaviour
{
	[Token(Token = "0x4003568")]
	[FieldOffset(Offset = "0x18")]
	public GridData data;

	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x14BD73C", Offset = "0x14BD73C", VA = "0x14BD73C")]
	public List<LevelData> GetAllLevels()
	{
		return null;
	}

	[Token(Token = "0x6002DB7")]
	[Address(RVA = "0x14BD98C", Offset = "0x14BD98C", VA = "0x14BD98C")]
	public GridviewMenu()
	{
	}
}
