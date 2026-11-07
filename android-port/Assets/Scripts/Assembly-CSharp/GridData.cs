using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20009BB")]
public class GridData : ScriptableObject
{
	[Token(Token = "0x4003564")]
	[FieldOffset(Offset = "0x18")]
	public int cols;

	[Token(Token = "0x4003565")]
	[FieldOffset(Offset = "0x1C")]
	public int rows;

	[Token(Token = "0x4003566")]
	[FieldOffset(Offset = "0x20")]
	public List<GridIcon> grid;

	[Token(Token = "0x6002DB1")]
	[Address(RVA = "0x14B9438", Offset = "0x14B9438", VA = "0x14B9438")]
	public void Set(int x, int y, GridIcon icon)
	{
	}

	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x14B95E0", Offset = "0x14B95E0", VA = "0x14B95E0")]
	public GridIcon Get(int x, int y)
	{
		return null;
	}

	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x14B94C4", Offset = "0x14B94C4", VA = "0x14B94C4")]
	private void UpdateArray(int index)
	{
	}

	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x14B9674", Offset = "0x14B9674", VA = "0x14B9674")]
	public GridData()
	{
	}
}
